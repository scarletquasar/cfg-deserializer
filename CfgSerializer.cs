using System.Collections.Generic;
using System;

namespace CfgManagement
{
    public class CfgSerializer
    {
        public static string Serialize(Dictionary<string,string> target) {
            string result = string.Empty;
            foreach(var key in target.Keys) {
                result += key + "=" + target[key];
            }
            return result;
        }
    }
}
