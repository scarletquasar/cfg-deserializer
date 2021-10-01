using System.Collections.Generic;
using System.Reflection;
using System.Linq;

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
        public static string Deserialize<T>(string parameter) {
            List<string> externalFields = new List<string>();
            var fields = typeof(T).GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            foreach(var i in fields) {
                externalFields.Add(i.Name);
            }
            return string.Join("", externalFields);
        }
    }   
}
