using EnglishVocabulary.Domain.Entity;
using EnglishVocabulary.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace EnglishVocabulary.App.Abstract
{
    public interface IQuestionService
    {
        List<Question> Questions { get; set; }

        int AddNewQuestion(string content, string answer, string level);
        List<Question> ShowAllQuestions();
        void ShowAllLevels(ComboBox levelsComboBox);
        List<Question> ShowQuestionsByLevel(string filtr);
        Question ShowQuestionById(int id);
        bool DeleteQuestionById(int id);
        int LoadQuestion(LoadQuestionVM loadQuestionVM);
        bool CheckAnswer(string answerButton, int id);     
        void RestartProgress();
        bool IsAnyQuestion();
        bool IsEnoughToQuiz();

    }
}
