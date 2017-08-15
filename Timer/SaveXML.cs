using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace SBTMLite
{
    class SaveXML
    {
        public static void SaveData(object obj, string filename)
        {


            StreamWriter writer = null;
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(obj.GetType());
                writer = new StreamWriter(filename);
                xmlSerializer.Serialize(writer, obj);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
                writer = null;
            }
        }
    }

    public class XmlLoad<T>
    {
        public static Type type;

        public XmlLoad()
        {
            type = typeof(T);
        }

        public T LoadData(string filename)
        {
            T result;
            XmlSerializer xmlserializer = new XmlSerializer(type);
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
            result = (T)xmlserializer.Deserialize(fs);
            fs.Close();
            return result;
        }


    }
  }

