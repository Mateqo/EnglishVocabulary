using EnglishVocabulary.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace EnglishVocabulary.App.Abstract
{
    public interface IQuestionService
    {
        List<Question> Questions { get; set; }

        void AddNewQuestion(string content, string answer, string level);
        List<Question> ShowAllQuestions();
        void ShowAllLevels(ComboBox levelsComboBox);
        List<Question> ShowQuestionsByLevel(string filtr);
        Question ShowQuestionById(int id);
        bool DeleteQuestionById(int id);
        int LoadQuestion(Label labelQuestion, Button answerButton1, Button answerButton2, Button answerButton3, Button answerButton4);
        bool CheckAnswer(Button answerButton, int id);     
        void RestartProgress();
        bool IsAnyQuestion();
        bool IsEnoughToQuiz();

    }
}
