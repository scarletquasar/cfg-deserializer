using System.Collections.Generic;
using System.Reflection;

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

        public static T Deserialize<T>(T parameter) {
            List<string> externalFields = new List<string>();
            //====
            return parameter;
        }
    }
}
