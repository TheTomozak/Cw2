using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Cw2
{
    [Serializable]
    public class Uczelnia
    {
        [XmlElement("CreatedAt")]
        [JsonPropertyName("CreatedAt")]
        public string CreatedAt { get; set; }

        [XmlElement("Author")]
        [JsonPropertyName("Author")]
        public string Author { get; set; }

        [XmlElement("StudentsList")]
        [JsonPropertyName("StudentsList")]
        public List<Student> StudentsList { get; set; }

    }
}
