using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolkit.Net.Extensions
{
    public static class JsonExtensions
    {
        public static string ToJson<T>(this T obj, bool useDictionary = false)
        {
            return Json.Serialize<T>(obj, useDictionary);
        }
    }
}