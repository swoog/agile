using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cellenza.Quizz.QuestionRead
{
    using System.Linq.Expressions;
    using System.Xml;
    using System.Xml.Serialization;

    public class Question
    {
        public IList<Question> ReadXmlFile()
        {
            //var serializer = new XmlSerializer();
            //serializer.Deserialize()
            return null;
        } 

        public List<Reponse> Reponses { get; set; }
    }

    public class Reponse
    {
    }
}
