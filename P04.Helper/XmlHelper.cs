using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace P04.Helper
{
    public class XmlHelper
    {
        //file Deserialize to object
        public static T FileToObject<T>(string path) where T : new()
        {
            path = path ?? AppDomain.CurrentDomain.BaseDirectory;
            string xml = File.ReadAllText(path, Encoding.UTF8);
            return XmlDeserialize<T>(xml, Encoding.UTF8);
        }

        public static T XmlDeserialize<T>(string xmlStr, Encoding encoding)
        {
            if (string.IsNullOrEmpty(xmlStr))
                throw new ArgumentException("xmlStr");
            
            if(encoding == null)
                throw  new ArgumentException();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using (MemoryStream ms = new MemoryStream(encoding.GetBytes(xmlStr)))
            {
                using (StreamReader sr = new StreamReader(ms, encoding))
                {
                    var result = xmlSerializer.Deserialize(sr);
                    return (T) result;
                }
            }

        }





    }
}
