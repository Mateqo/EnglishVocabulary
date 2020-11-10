using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EnglishVocabulary
{
    class Question
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Answer { get; set; }
        public string Choice { get; set; }
        public bool IsCorrectAnswer { get; set; }

    }

}
