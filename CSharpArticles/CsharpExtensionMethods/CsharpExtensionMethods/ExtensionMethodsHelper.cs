using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExtensionMethods
{
    /// <summary>
    /// Static class providing extension methods
    /// </summary>
    public static class ExtensionMethodsHelper
    {
        public static string Suffix(this string parameter, string suffixstr)
        {
            return parameter + suffixstr;
        }

        public static string Prefix(this string parameter, string prefixstr)
        {
            return prefixstr + parameter;
        }
    }
}
