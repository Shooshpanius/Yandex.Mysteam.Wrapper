using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexMystem.Wrapper.Models
{
    [Obsolete]
    /// <summary>
    /// Время (глаголов)
    /// </summary>
    public class GramVerbTenseModel
    {
        /// <summary>
        /// настоящее
        /// </summary>
        public bool IsPresent { get; set; } // наст ; praes

        /// <summary>
        /// непрошедшее
        /// </summary>
        public bool IsPermeate { get; set; } // непрош ; inpraes

        /// <summary>
        /// прошедшее
        /// </summary>
        public bool IsPast { get; set; } // прош ; praet

        public GramVerbTenseModel(string str)
        {
            foreach (var s in str.ToLower().Trim().Split(','))
            {
                switch (s)
                {
                    case "наст":
                    case "praes":
                        IsPresent = true;
                        return;

                    case "непрош":
                    case "inpraes":
                        IsPermeate = true;
                        return;

                    case "прош":
                    case "praet":
                        IsPast = true;
                        return;
                }
            }
        }

        public static implicit operator GramVerbTenseModel(string str)
        {
            return new GramVerbTenseModel(str);
        }
    }
}
