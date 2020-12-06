using EnglishVocabulary.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace EnglishVocabulary.Domain.Entity
{
    public class Question : BaseEntity
    {
        [XmlElement("Content")]
        public string Content { get; set; }
        [XmlElement("Answer")]
        public string Answer { get; set; }
        [XmlElement("Level")]
        public string Level { get; set; }
        [XmlIgnore]
        public string Choice { get; set; }
        [XmlElement("IsCorrectAnswer")]
        public bool IsCorrectAnswer { get; set; }
        [XmlIgnore]
        public bool IsDeleted { get; set; }

        public Question()
        {

        }
        public Question(int id, string content, string level, string answer)
        {
            this.Id = id;
            this.Content = content;
            this.Answer = answer;
            this.Level = level;
        }
    }
}
