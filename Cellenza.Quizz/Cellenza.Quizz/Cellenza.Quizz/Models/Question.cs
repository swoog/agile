using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Cellenza.Quizz.Models
{
    public class Question
    {
        [XmlAttribute]
        public string Text { get; set; }

        [XmlArrayItem("Reponse", typeof(Reponse))]
        public Reponse[] Answers { get; set; }
    }
}
