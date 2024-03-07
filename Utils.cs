using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Variable_Editor
{
    public static class Utils
    {
        /// <summary>
        /// 检查指定文件路径是否存在，并且文件具有指定的扩展名。
        /// </summary>
        /// <param name="filePath">要检查的文件路径</param>
        /// <param name="expectedExtension">期望的文件扩展名，不包括点号</param>
        /// <returns>如果文件存在且具有指定的扩展名则返回 true，否则返回 false</returns>
        public static bool CheckFileExistsWithExtension(string filePath, string expectedExtension)
        {
            bool fileExists = File.Exists(filePath);
            if (!fileExists)
            {
                return false;
            }
            string actualExtension = Path.GetExtension(filePath);

            return string.Equals(actualExtension, $".{expectedExtension}", StringComparison.OrdinalIgnoreCase);
        }

    }
}
