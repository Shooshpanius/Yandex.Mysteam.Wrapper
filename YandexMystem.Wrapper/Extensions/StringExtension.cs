using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexMystem.Wrapper.Extensions
{
    public static class StringExtension
    {
        public static string Preppend(this string str, object add, params object[] args)
        {
            return string.Format(add.ToString(), args) + str;
        }

        public static string Append(this string str, object add, params object[] args)
        {
            return str + string.Format(add.ToString(), args);
        }
    }
}
