using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexMystem.Wrapper.Models
{
    [Obsolete]
    /// <summary>
    /// Падеж
    /// </summary>
    public class GramCaseModel
    {
        /// <summary>
        /// именительный
        /// </summary>
        public bool IsNominative { get; set; } // им ; nom

        /// <summary>
        /// родительный
        /// </summary>
        public bool IsGenitive { get; set; } // род ; gen

        /// <summary>
        /// дательный
        /// </summary>
        public bool IsDative { get; set; } // дат ; dat

        /// <summary>
        /// винительный
        /// </summary>
        public bool IsAccusative { get; set; } // вин ; acc

        /// <summary>
        /// творительный
        /// </summary>
        public bool IsInstrumental { get; set; } // твор ; ins

        /// <summary>
        /// предложный
        /// </summary>
        public bool IsPrepositional { get; set; } // пр ; abl

        /// <summary>
        /// партитив (второй родительный)
        /// </summary>
        public bool IsPartitive { get; set; } // парт ; part

        /// <summary>
        /// местный (второй предложный)
        /// </summary>
        public bool IsLocal { get; set; } // местн ; loc

        /// <summary>
        /// звательный
        /// </summary>
        public bool IsVocative { get; set; } // зват ; voc

        public GramCaseModel(string str)
        {
            foreach (var s in str.ToLower().Trim().Split(','))
            {
                switch (s)
                {
                    case "им":
                    case "nom":
                        IsNominative = true;
                        return;

                    case "род":
                    case "gen":
                        IsGenitive = true;
                        return;

                    case "дат":
                    case "dat":
                        IsDative = true;
                        return;

                    case "вин":
                    case "acc":
                        IsAccusative = true;
                        return;

                    case "твор":
                    case "ins":
                        IsInstrumental = true;
                        return;

                    case "пр":
                    case "abl":
                        IsPrepositional = true;
                        return;

                    case "парт":
                    case "part":
                        IsPartitive = true;
                        return;

                    case "местн":
                    case "loc":
                        IsLocal = true;
                        return;

                    case "зват":
                    case "voc":
                        IsVocative = true;
                        return;
                }
            }
        }

        public static implicit operator GramCaseModel(string str)
        {
            return new GramCaseModel(str);
        }
    }
}
