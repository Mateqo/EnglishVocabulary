using EnglishVocabulary.App.Abstract;
using EnglishVocabulary.Domain.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace EnglishVocabulary.App.Concrete
{
    public class DataService : IDataService
    {
        public QuestionService _questionService;

        public DataService(QuestionService questionService)
        {
            _questionService = questionService;
        }

        public bool SaveData(string path)
        {
            try
            {
                string fullPath = Path.Combine(@"\",path, "EnglishVocabularySave.xml");
                var list = _questionService.ShowAllQuestions();

                XmlRootAttribute root = new XmlRootAttribute();
                root.ElementName = "Questions";
                root.IsNullable = true;
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>), root);

                using StreamWriter sw = new StreamWriter(fullPath);
                xmlSerializer.Serialize(sw, list);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public bool LoadData(string path)
        {
            try
            {
                XmlRootAttribute root = new XmlRootAttribute();
                root.ElementName = "Questions";
                root.IsNullable = true;
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Question>), root);

                string xml = File.ReadAllText(path);
                StringReader stringReader = new StringReader(xml);
                var xmlItems = (List<Question>)xmlSerializer.Deserialize(stringReader);
               
                xmlItems.Where(x => x.IsCorrectAnswer==true).ToList().ForEach(x=>x.Choice=x.Answer);

                _questionService.Questions.Clear();
                _questionService.Questions = xmlItems;
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
