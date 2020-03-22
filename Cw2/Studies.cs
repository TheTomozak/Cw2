using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Cw2
{

    [Serializable]
    class Studies
    {

        [XmlElement("UniversityName")]
        [JsonPropertyName("UniversityName")]
        public string UniversityName { get; set; }

        [XmlElement("UniversityMode")]
        [JsonPropertyName("UniversityMode")]
        public string UniversityMode { get; set; }
    }
}
