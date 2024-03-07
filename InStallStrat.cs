using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace System_Variable_Editor
{
    public static class InStallStrat
    {
        public static List<InstallExe> InitRead()
        {
            return new List<InstallExe>();
        }
        public static async Task<string> GetFileNameFromUrl(string url)
        {
            try
            {
                // 创建一个HttpClient实例
                HttpClient client = new HttpClient();
                // 发送一个HEAD请求以获取响应头，而不下载整个文件
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Head, url);
                HttpResponseMessage response = await client.SendAsync(request);
                string? contentDisposition = response.Content.Headers.ContentDisposition?.ToString();
                if (!string.IsNullOrEmpty(contentDisposition))
                {
                    string? fileName = new System.Net.Mime.ContentDisposition(contentDisposition).FileName;
                    if (!string.IsNullOrEmpty(fileName))
                    {
                        return fileName;
                    }
                }
                // 如果响应头中没有文件名信息，则返回URL中的文件名
                return Path.GetFileName(url);
            }
            catch (Exception ex)
            {
                throw new Exception($"下载错误，原因{ex.Message}");
            }
        }
        //安装后缀为zip的应用程序
        public static void StartInstallerAsync(InstallExe installExe, string t)
        {
            //应用程序存储文件夹
            string? installDirectory = installExe.SavePath;
            string? param = installExe.InCmd;
            //安装包保存文件夹
            string? installerPath = installExe.SavePath;
            if (installDirectory == null && param == null && installDirectory == null)
            {
                throw new Exception("配置读取错误");
            }
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = installerPath;
            startInfo.Arguments = $"{param}\"{installDirectory}\""; // 使用参数指定安装目录和其他选项
            startInfo.UseShellExecute = false;

            t = installExe.Name + "正在安装中";
            if (installerPath == null)
            {
                throw new Exception("下载地址为空");
            }
            string inP = Path.GetExtension(installerPath);
            string? fileDirectory = Path.GetDirectoryName(installerPath);
            //如果是压缩包    
            if (inP == ".zip" || inP == ".rar")
            {
                if (fileDirectory == null)
                {
                    throw new Exception("下载地址为空");
                }
                try
                {
                    ZipFile.ExtractToDirectory(installerPath, fileDirectory);
                }
                catch { throw new Exception("安装错误"); }
            }
        }

        //下载软件
        public static async void InStallEXEAsync(InstallExe installExe, IProgress<int> progress,Func<Boolean> installFunc)
        {
            try
            {
                var url = installExe.Url;
                var savePath = installExe.SavePath;
                if (savePath == null)
                {
                    throw new Exception($"保存地址为空{savePath}");
                }
                if (!Directory.Exists(Path.GetFullPath(savePath)))
                {
                    throw new Exception($"保存地址错误:{Environment.NewLine}{savePath}");
                }
                if (url == null)
                {
                    throw new Exception($"url为空{url}");
                }
                int progressInt = 0;
                using (var httpClient = new HttpClient())
                {
                    // 发起GET请求，并获取响应消息
                    HttpResponseMessage response = await httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead);
                    // 确保响应成功
                    response.EnsureSuccessStatusCode();

                    // 使用响应流异步保存文件
                    await using (Stream stream = await response.Content.ReadAsStreamAsync())
                    {
                        installExe.SavePath = Path.Combine(savePath, await GetFileNameFromUrl(url));
                        using (FileStream fileStream = new FileStream(Path.Combine(savePath, await GetFileNameFromUrl(url)), FileMode.Create, FileAccess.Write))
                        {
                            // 定义缓冲区大小
                            byte[] buffer = new byte[8192];
                            int bytesRead;
                            long totalBytesRead = 0;
                            // 读取响应流，并写入文件流
                            while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                            {
                                await fileStream.WriteAsync(buffer, 0, bytesRead);
                                totalBytesRead += bytesRead;
                                if (response.Content.Headers.ContentLength > 0)
                                {
                                    double progressPercentage = (double)((double)totalBytesRead / response.Content.Headers.ContentLength * 100);
                                    progressInt = (int)progressPercentage;
                                    progress.Report((int)progressPercentage);
                                }
                                else throw new Exception("下载出错");
                            }
                        }
                    }
                    if(progressInt == 100)
                    {
                        //执行下载安装程序
                        installFunc.Invoke();
                    }
                    else
                    {
                        //如果下载异常就删除
                        MessageBox.Show("下载异常");
                        try
                        {
                            File.Delete(installExe.SavePath);
                        }
                        catch(Exception e) { MessageBox.Show(e.Message); }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                if (installExe.SavePath != null && File.Exists(installExe.SavePath))
                {
                    File.Delete(installExe.SavePath);
                }
            }
        }
    }
}
