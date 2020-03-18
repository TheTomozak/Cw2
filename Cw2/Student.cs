using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Text.Json.Serialization;



namespace Cw2
{
    class Student
    {
        // An Attribute is something that is self-contained, i.e., a color, an ID, a name.
        // An Element is something that does or could have attributes of its own or contain other elements.

        [XmlElement("FirsName")]
        [JsonPropertyName("FirsName")]
        public string FirsName { get; set; }

        [XmlElement("LastName")]
        [JsonPropertyName("LastName")]
        public string LastName { get; set; }

        [XmlElement("UniversityName")]
        [JsonPropertyName("UniversityName")]
        public string UniversityName { get; set; }

        [XmlElement("UniversityMode")]
        [JsonPropertyName("UniversityMode")]
        public string UniversityMode { get; set; }

        [XmlAttribute("index")]
        [JsonPropertyName("index")]
        public string Index { get; set; }

        [XmlElement("BirthDate")]
        [JsonPropertyName("BirthDate")]
        public string BirthDate { get; set; }

        [XmlAttribute("Email")]
        [JsonPropertyName("Email")]
        public string Email { get; set; }

        [XmlElement("NameMother")]
        [JsonPropertyName("NameMother")]
        public string NameMother { get; set; }

        [XmlElement("NameFather")]
        [JsonPropertyName("NameFather")]
        public string NameFather { get; set; }



    }
}
