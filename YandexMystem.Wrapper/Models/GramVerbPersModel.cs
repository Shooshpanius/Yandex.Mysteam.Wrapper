using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexMystem.Wrapper.Models
{
    [Obsolete]
    /// <summary>
    /// Лицо глагола
    /// </summary>
    public class GramVerbPersModel
    {
        /// <summary>
        /// 1-ое лицо
        /// </summary>
        public bool IsFirst { get; set; } // 1-л ; 1p

        /// <summary>
        /// 2-ое лицо
        /// </summary>
        public bool IsSecond { get; set; } // 2-л ; 2p

        /// <summary>
        /// 3-ое лицо
        /// </summary>
        public bool IsThird { get; set; } // 3-л ; 3p

        public GramVerbPersModel(string str)
        {
            foreach (var s in str.ToLower().Trim().Split(','))
            {
                switch (s)
                {
                    case "1-л ":
                    case "1p":
                        IsFirst = true;
                        return;

                    case "2-л ":
                    case "2p":
                        IsSecond = true;
                        return;

                    case "3-л":
                    case "3p":
                        IsThird = true;
                        return;
                }
            }
        }

        public static implicit operator GramVerbPersModel(string str)
        {
            return new GramVerbPersModel(str);
        }
    }
}
