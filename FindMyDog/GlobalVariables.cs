using System;
using System.Collections.Generic;
using System.Text;

namespace FindMyDog
{
    public static class GlobalVariables
    {
        public static IList<Dog> Dogs { get; set; }
        public static Dictionary<string, (string, string, string, string, string, string)> dict = new Dictionary<string, (string, string, string, string, string, string)>();
    }
}
