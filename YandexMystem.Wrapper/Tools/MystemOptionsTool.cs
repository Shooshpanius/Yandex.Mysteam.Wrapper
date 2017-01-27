using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexMystem.Wrapper.Enums;
using YandexMystem.Wrapper.Extensions;

namespace YandexMystem.Wrapper.Tools
{
    public static class MystemOptionsTool
    {
        public static string GetStringArgs(MystemExecuteOptions executeOptions, string appendValue = null)
        {
            var result = string.Empty;
            foreach (MystemExecuteOptions i in Enum.GetValues(typeof (MystemExecuteOptions)))
                if (executeOptions.HasFlag(i))
                    result += " " + GetOptionString(i);

            return result.TrimStart() + appendValue?.Preppend(" ");
        }

        private static string GetOptionString(MystemExecuteOptions executeOption)
        {
            switch (executeOption)
            {
                case MystemExecuteOptions.WordPerLineOutput:
                    return "-n";

                case MystemExecuteOptions.SaveInputFormat:
                    return "-c";

                case MystemExecuteOptions.OnlyDictionaryWords:
                    return "-w";

                case MystemExecuteOptions.OnlyLems:
                    return "-l";

                case MystemExecuteOptions.GetGramms:
                    return "-i";

                case MystemExecuteOptions.GroupGramms:
                    return "-g";

                case MystemExecuteOptions.MarkSentenceEnd:
                    return "-s";

                case MystemExecuteOptions.Encoding:
                    return "-e";

                case MystemExecuteOptions.AutoHomonym:
                    return "-d";

                case MystemExecuteOptions.LatGramms:
                    return "--eng-gr";

                case MystemExecuteOptions.FilterGramms:
                    return "--filter-gram";

                case MystemExecuteOptions.UseUserDictionary:
                    return "--fixlist";

                case MystemExecuteOptions.UseFormat:
                    return "--format";

                case MystemExecuteOptions.UnknowWordHypothesis:
                    return "--generate-all";

                case MystemExecuteOptions.ShowWeights:
                    return "--weight";
            }

            throw new ArgumentException("Not parsable option");
        }
    }
}
