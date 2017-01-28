using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace YandexMystem.Wrapper.Models
{
    [Obsolete]
    /// <summary>
    /// Число
    /// </summary>
    public class GrammCountModel
    {
        /// <summary>
        /// единственное число
        /// </summary>
        public bool IsSingle { get; set; } // ед ; sg

        /// <summary>
        /// множественное число
        /// </summary>
        public bool IsPlural { get; set; } // мн ; pl

        public GrammCountModel(string str)
        {
            foreach (var s in str.ToLower().Trim().Split(','))
            {
                switch (s)
                {
                    case "ед":
                    case "sg":
                        IsSingle = true;
                        return;

                    case "мн":
                    case "pl":
                        IsPlural = true;
                        return;
                }
            }
        }

        public static implicit operator GrammCountModel(string str)
        {
            return new GrammCountModel(str);
        }
    }
}
