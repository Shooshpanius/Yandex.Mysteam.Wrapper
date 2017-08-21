using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using YandexMystem.Wrapper.Enums;
using YandexMystem.Wrapper.Extensions;
using YandexMystem.Wrapper.Models;
using YandexMystem.Wrapper.Models.Mystem;

namespace YandexMystem.Wrapper
{
    /// <summary>
    /// Базовый класс
    /// </summary>
    public class Mysteam
    {
        public readonly string FilePath;
        public readonly string TmpFolder = "tmp";



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

        /// <summary>
        /// Чистый ответ от mysteam
        /// </summary>
        /// <param name="text">Строка запроса</param>
        /// <returns></returns>
        internal MystemResult GetResult(string text)
        {
            var result = new MystemResult
            {
                Request = text
            };

            if (!File.Exists(FilePath))
                throw new FileNotFoundException($"{FilePath} not founded");

            var rootPath = Path.GetDirectoryName(FilePath);
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            string fileRandomName = rnd.Next(1000000, 9999999).ToString()+"_tmp_mysteam_input.txt";
            var fileInput = Path.Combine(rootPath, TmpFolder, fileRandomName);

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
                        + Tools.MystemOptionsTool.GetStringArgs(MystemExecuteOptions.UseFormat, "json").Prepend(" ")
                        + fileInput.Prepend(" \"").Append("\"")
                }
            };

            
            File.WriteAllText(fileInput, result.Request, Encoding.UTF8);

            p.Start();
            result.Response = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            File.Delete(fileInput);

            result.Results = JsonConvert.DeserializeObject<MystemWord[]>(result.Response);

            return result;
        }

        public List<WordModel> GetWords(string text)
        {
            return GetResult(text).Results
                .Select(x => new WordModel(x))
                .ToList();
        }
    }
}
