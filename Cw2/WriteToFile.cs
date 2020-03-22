using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Cw2
{

    [Serializable]
    public class WriteToFile
    {
        public static void writeToXML(List<Student> studentsList, string file)
        {
            FileStream writer = new FileStream(file, FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(Uczelnia));
            Uczelnia uczelnia = new Uczelnia
            {
                StudentsList = studentsList,
                Author = "Tomasz Palczewski",
                CreatedAt = DateTime.Now.ToString()
            };
            serializer.Serialize(writer, uczelnia);
        }

    }
}
