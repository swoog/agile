using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Cellenza.Quizz.Models
{
    public class Reponse
    {
        [XmlAttribute]
        public int Points { get; set; }
        
        [XmlAttribute]
        public string Value { get; set; }
    }
}
