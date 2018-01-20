using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormsApp2
{
    public static class XmlSer

    {
        public static void Serialize(Object data, string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Game>));
            using (StreamWriter writer = new StreamWriter(filename))
            {
                serializer.Serialize(writer, data);
            }
        }

        public static Object Deserialize(string filename)
        {
            List<Game> gamesList = new List<Game>();

            if (!File.Exists(filename))
            {
                File.Create(filename).Close();
            }
            FileStream fs = File.OpenRead(filename);
            try
            {

                XmlSerializer serializer = new XmlSerializer(typeof(List<Game>));
                gamesList = (List<Game>)serializer.Deserialize(fs);
                fs.Close();
                return gamesList;
            }
            catch (Exception e)
            {
                if (fs != null)
                {
                    fs.Close();
                }
                return gamesList;
            }

        }
    }
}
