using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexMystem.Wrapper.Models
{
    [Obsolete]
    /// <summary>
    /// Вид
    /// </summary>
    public class GramVerbSpeciesModel
    {
        /// <summary>
        /// несовершенный
        /// </summary>
        public bool IsImperfect { get; set; } // несов ; ipf

        /// <summary>
        /// совершенный
        /// </summary>
        public bool IsPerfect { get; set; } // сов ; pf

        public GramVerbSpeciesModel(string str)
        {
            foreach (var s in str.ToLower().Trim().Split(','))
            {
                switch (s)
                {
                    case "несов":
                    case "ipf":
                        IsImperfect = true;
                        return;

                    case "сов":
                    case "pf":
                        IsPerfect = true;
                        return;
                }
            }
        }

        public static implicit operator GramVerbSpeciesModel(string str)
        {
            return new GramVerbSpeciesModel(str);
        }
    }
}
