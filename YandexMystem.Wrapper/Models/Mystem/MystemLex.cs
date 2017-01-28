using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace YandexMystem.Wrapper.Models.Mystem
{
    public class MystemLex
    {
        [JsonProperty("lex")]
        public string Lex { get; set; }

        [JsonProperty("wt")]
        public double Wt { get; set; }

        [JsonProperty("gr")]
        public string Gr { get; set; }
    }
}
