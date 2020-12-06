using EnglishVocabulary.Domain.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace EnglishVocabulary.App.Concrete
{
    public class DataService
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
    }
}
