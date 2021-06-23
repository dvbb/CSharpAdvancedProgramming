using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MyConfig
{
    public static class GetValue
    {
        public static string GetValueDvbb()
        {

            string filepath = System.Reflection.Assembly.GetExecutingAssembly().CodeBase.Replace(@"file:///", string.Empty) + ".config";
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(filepath);
            string data = xDoc.SelectSingleNode(@"/configuration/appSettings/add[@key='dvbb']").Attributes["value"].Value;

            return data;
        }
    }
}
