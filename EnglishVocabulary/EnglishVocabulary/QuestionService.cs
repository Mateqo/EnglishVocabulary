using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishVocabulary
{
    public class QuestionService
    {
        public List<Question> Questions { get; set; }
        public QuestionService()
        {
            Questions = new List<Question>();
        }

        public void AddNewQuestion(string content, string answer,string level)
        {
            int newId = Questions.Count() + 1;

            Question question = new Question(newId,content.ToLower(),level.ToLower(), answer.ToLower());

            Questions.Add(question);
        }

        public List<Question> ShowAllQuestions()
        {
            return Questions;     
        }

        public void ShowAllLevels(ComboBox levelsComboBox)
        {
            string[] levels = Questions.Select(x => x.Level).ToArray();
            levels = levels.Distinct().ToArray();


            foreach (var type in levels)
            {
                levelsComboBox.Items.Add(type);
            }

        }

        public List<Question> ShowQuestionsByLevel(string filtr)
        {
            return Questions.Where(x => x.Level == filtr).ToList();
        }

    }
}
