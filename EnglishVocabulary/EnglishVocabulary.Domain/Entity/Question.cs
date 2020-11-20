using EnglishVocabulary.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishVocabulary.Domain.Entity
{
    public class Question : BaseEntity
    {
        public string Content { get; set; }
        public string Answer { get; set; }
        public string Level { get; set; }
        public string Choice { get; set; }
        public bool IsCorrectAnswer { get; set; }
        public bool IsDeleted { get; set; }

        public Question(int id, string content, string level, string answer)
        {
            this.Id = id;
            this.Content = content;
            this.Answer = answer;
            this.Level = level;
        }
    }
}
