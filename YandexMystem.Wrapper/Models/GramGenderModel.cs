using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexMystem.Wrapper.Models
{
    [Obsolete]
    /// <summary>
    /// Род
    /// </summary>
    public class GramGenderModel
    {
        /// <summary>
        /// Средний род
        /// </summary>
        public bool IsNeuter { get; set; } // сред ; n

        /// <summary>
        /// Мужской род
        /// </summary>
        public bool IsMale { get; set; } // муж ; m

        /// <summary>
        /// Женский род
        /// </summary>
        public bool IsFemale { get; set; } // жен ; f

        public GramGenderModel(string str)
        {
            foreach (var s in str.ToLower().Trim().Split(','))
            {
                switch (s)
                {
                    case "сред":
                    case "n":
                        IsNeuter = true;
                        return;

                    case "муж":
                    case "m":
                        IsMale = true;
                        return;

                    case "жен":
                    case "f":
                        IsFemale = true;
                        return;
                }
            }
        }

        public static implicit operator GramGenderModel(string str)
        {
            return new GramGenderModel(str);
        }
    }
}
