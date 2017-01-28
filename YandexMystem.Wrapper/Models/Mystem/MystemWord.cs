using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace YandexMystem.Wrapper.Models.Mystem
{
    public class MystemWord
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("analysis")]
        public MystemLex[] Analysis { get; set; }
    }
}
