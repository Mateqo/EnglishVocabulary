using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnglishVocabulary.Domain.ViewModel
{
    public class LoadQuestionVM
    {
        public Label Question { get; set; }
        public List<Button> Answers { get; set; }

        public LoadQuestionVM(Label question,List<Button> answerButtons)
        {
            Answers = new List<Button>();
            Question = question;

            foreach (var button in answerButtons)
            {
                Answers.Add(button);              
            }

        }
    }
}
