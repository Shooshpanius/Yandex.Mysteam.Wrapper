using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexMystem.Wrapper.Models.Mystem
{
    public class MystemResult
    {
        public string Request { get; set; }

        public string Response { get; set; }

        public MystemWord[] Results { get; set; }
    }
}
