using System.IO;
using System.Runtime.Serialization.Json;
using CharacterBase.Entities;
using Newtonsoft.Json;

namespace Libraries
{
    public static class PhoneLibrary
    {
        private static ClassList _classList=null;

        public static ClassList GetClasses() => _classList;

        public static void Init(Stream classes)
        {
            using (StreamReader sr = new StreamReader(classes))
            {
                string tmp = sr.ReadToEnd();
                _classList = JsonConvert.DeserializeObject<ClassList>(tmp);
            }    
        }
    }
}
