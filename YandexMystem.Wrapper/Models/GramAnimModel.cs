using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexMystem.Wrapper.Models
{
    [Obsolete]
    /// <summary>
    /// Одушевленность
    /// </summary>
    public class GramAnimModel
    {
        /// <summary>
        /// одушевленное
        /// </summary>
        public bool IsAnimated { get; set; } // од ; anim

        /// <summary>
        /// неодушевленное
        /// </summary>
        public bool IsInanimated { get; set; } // неод ; inan

        public GramAnimModel(string str)
        {
            foreach (var s in str.ToLower().Trim().Split(','))
            {
                switch (s)
                {
                    case "од":
                    case "anim":
                        IsAnimated = true;
                        return;

                    case "неод":
                    case "inan":
                        IsInanimated = true;
                        return;
                }
            }
        }

        public static implicit operator GramAnimModel(string str)
        {
            return new GramAnimModel(str);
        }
    }
}
