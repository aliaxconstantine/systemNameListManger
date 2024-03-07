using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Sunny.UI;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;

namespace System_Variable_Editor
{
    public partial class SystemInEditor : UIForm
    {
        private string jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");

        public SystemInEditor()
        {
            InitializeComponent();
        }
        private void SystemInEditor_Load(object sender, EventArgs e)
        {
            bool hasAdminRights = new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
            if (!hasAdminRights)
            {
                MessageBox.Show("未用管理员权限打开，环境变量可能设置失败");
            }

            readConfig();
        }

        private void readConfig()
        {
            string jsonString = File.ReadAllText(jsonPath);
            JObject jsonObject = JObject.Parse(jsonString);

            foreach (var property in jsonObject.Properties())
            {
                if (property.Value.HasValues)
                {
                    foreach (var value in property.Value)
                    {
                        var pValue = (JProperty)value;
                        dataViewTypeValue.AddRow(new object[] { property.Name, pValue.Name, pValue.Value });
                    }
                }
            }
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            IDictionary envVariables = Environment.GetEnvironmentVariables();

            var pathVariableValue = new StringBuilder(Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.Machine));

            foreach (DataGridViewRow row in dataViewTypeValue.Rows)
            {
                if (row.IsNewRow) continue;

                string propertyName = row.Cells[0].Value?.ToString() ?? string.Empty;
                string valueName = row.Cells[1].Value?.ToString() ?? string.Empty;
                string value = row.Cells[2].Value?.ToString() ?? string.Empty;

                if (!string.IsNullOrEmpty(propertyName))
                {
                    if (!envVariables.Contains(valueName))
                    {
                        Environment.SetEnvironmentVariable(valueName, value, EnvironmentVariableTarget.Machine);
                    }

                    if (valueName == "Path")
                    {
                        if (!pathVariableValue.ToString().Split(';').Contains(value))
                        {
                            pathVariableValue.Append(Path.PathSeparator + value);
                            Environment.SetEnvironmentVariable("Path", pathVariableValue.ToString(), EnvironmentVariableTarget.Machine);
                        }
                        else
                        {
                            MessageBox.Show($"{value}已设置过");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"{valueName} 的值已被设置过");
                    }
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            JObject jsonObject = new JObject();

            foreach (DataGridViewRow row in dataViewTypeValue.Rows)
            {
                if (row.IsNewRow) continue;
                string propertyName = row.Cells[0].Value?.ToString() ?? string.Empty;
                string valueName = row.Cells[1].Value?.ToString() ?? string.Empty;
                string value = row.Cells[2].Value?.ToString() ?? string.Empty;


                if (!string.IsNullOrEmpty(propertyName))
                {
                    var propertyObject = jsonObject.GetValue(propertyName) as JObject;
                    if (propertyObject == null)
                    {
                        propertyObject = new JObject();
                        jsonObject.Add(propertyName, propertyObject);
                    }

                    if (valueName != null)
                    {
                        propertyObject[valueName] = value;
                    }
                }
                else
                {
                    var propertyObject = jsonObject.Last;
                    var lastObject = propertyObject as JObject;
                    if (lastObject != null && valueName != null)
                    {
                        lastObject[valueName] = value;
                    }
                }
            }

            string jsonString = jsonObject.ToString();
            File.WriteAllText(jsonPath, jsonString);
            MessageBox.Show("保存成功");
        }

        private void InstallsButton_Click(object sender, EventArgs e)
        {
            try
            {
                Download download = new Download();
                download.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("下载异常:" + ex.Message.ToString());
            }
        }
    }
}
