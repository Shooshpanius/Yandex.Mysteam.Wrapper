using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using YandexMystem.Wrapper.Enums;
using YandexMystem.Wrapper.Extensions;

namespace YandexMystem.Wrapper
{
    /// <summary>
    /// Базовый класс
    /// </summary>
    public class Mysteam
    {
        public readonly string FilePath;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mystemFilePath">Полный путь до mystem.exe</param>
        public Mysteam(string mystemFilePath = null)
        {
            FilePath = (string.IsNullOrWhiteSpace(mystemFilePath))
                ? Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "mystem.exe")
                : mystemFilePath;
        }

        public void GetResult(string text, bool leaveTempFile = false)
        {
            if(!File.Exists(FilePath))
                throw new FileNotFoundException($"{FilePath} not founded");

            var fileInput = "_tmp_mysteam_input.txt";

            var p = new Process
            {
                StartInfo =
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    FileName = FilePath,
                    StandardOutputEncoding = Encoding.UTF8,
                    Arguments = 
                        Tools.MystemOptionsTool.GetStringArgs(MystemExecuteOptions.GetGramms | MystemExecuteOptions.GroupGramms | MystemExecuteOptions.ShowWeights)
                        + Tools.MystemOptionsTool.GetStringArgs(MystemExecuteOptions.UseFormat, "json").Preppend(" ")
                        + fileInput.Preppend(" ")
                }
            };

            var rootPath = Path.GetDirectoryName(FilePath);
            File.WriteAllText(Path.Combine(rootPath, fileInput), text, Encoding.UTF8);

            p.Start();
            var output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            if (!leaveTempFile)
                File.Delete(fileInput);
        }
    }
}
