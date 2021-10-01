using System.Collections.Generic;
using System;

namespace CfgManagement
{
    public class CfgDeserializer
    {
        public static Dictionary<string,string> Deserialize(string[] lines) {
            Dictionary<string,string> result = new Dictionary<string,string>();
            foreach(string l in lines) {
                var obj = l.Split('=');
                result.Add(obj[0], obj[1]);
            }
            return result;
        }
    }
}
