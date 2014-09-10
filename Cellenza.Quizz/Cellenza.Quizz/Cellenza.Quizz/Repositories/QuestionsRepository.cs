using Cellenza.Quizz.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Cellenza.Quizz.Repositories
{
    public class QuestionsRepository
    {
        public IList<Question> GetAll()
        {
            Questions questions = null;
            var assembly = typeof(QuestionsRepository).GetTypeInfo().Assembly;
            var stream = assembly.GetManifestResourceStream("Cellenza.Quizz.Questions.xml");

            using (var reader = new System.IO.StreamReader(stream))
            {
                var serializer = new XmlSerializer(typeof(Questions));
                questions = (Questions)serializer.Deserialize(reader);
            }

            return questions.Items.Select(q => NewQuestion(q)).ToList();
        }

        Question NewQuestion(QuestionsQuestion q)
        {
            return new Question
            {
                Text = q.Text,
                Answers = q.Reponse.Select(r => new Reponse 
                { 
                    Points = int.Parse(r.Points),
                    Value = r.Value
                }).ToArray()
            };
        }
    }
}
