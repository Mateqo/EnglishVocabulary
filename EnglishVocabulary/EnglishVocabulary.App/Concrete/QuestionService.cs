using EnglishVocabulary.App.Abstract;
using EnglishVocabulary.Domain.Common;
using EnglishVocabulary.Domain.Entity;
using EnglishVocabulary.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnglishVocabulary.App.Concrete
{
    public class QuestionService : IQuestionService
    {
        public List<Question> Questions { get; set; }
        public QuestionService()
        {
            Questions = new List<Question>();
            Initialize();
        }

        public int AddNewQuestion(string content, string answer, string level)
        {
            int newId = Questions.Count() + 1;

            Question question = new Question(newId, content.ToLower(), level.ToLower(), answer.ToLower());

            Questions.Add(question);

            return newId;
        }

        public List<Question> ShowAllQuestions()
        {
            return Questions.Where(x => x.IsDeleted == false).ToList();
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
            return Questions.Where(x => x.Level == filtr && x.IsDeleted == false).ToList();
        }

        public Question ShowQuestionById(int id)
        {
            Question questionById = Questions.Find(x => x.Id == id);

            return questionById;
        }

        public bool DeleteQuestionById(int id)
        {
            var questionDeleted = Questions.Find(x => x.Id == id);
            if (questionDeleted != null)
            {
                questionDeleted.IsDeleted = true;
                return true;
            }
            else
                return false;
        }

        public int LoadQuestion(LoadQuestionVM loadQuestionVM)
        {
            Random rnd = new Random();
            var questionToDo = Questions.Where(x => x.IsDeleted == false && x.IsCorrectAnswer != true).ToList();
            var id = rnd.Next(questionToDo.Count);
            var randomQuestion = questionToDo[id];

            loadQuestionVM.Question.Text = "\"" + randomQuestion.Content + "\"";

            for (int i = 0; i < loadQuestionVM.Answers.Count(); i++)
            {
                loadQuestionVM.Answers[i].Text = "";
            }


            var idButton = rnd.Next(loadQuestionVM.Answers.Count);
            loadQuestionVM.Answers[idButton].Text = randomQuestion.Answer;


            var randomAnswers = Questions.Where(x => x.IsDeleted == false && x.Id != randomQuestion.Id).Select(x => x.Answer).ToList();

            var idRandomAnswers1 = rnd.Next(randomAnswers.Count);
            string badAnswer1 = randomAnswers[idRandomAnswers1];
            randomAnswers.RemoveAt(idRandomAnswers1);

            var idRandomAnswers2 = rnd.Next(randomAnswers.Count);
            string badAnswer2 = randomAnswers[idRandomAnswers2];
            randomAnswers.RemoveAt(idRandomAnswers2);

            var idRandomAnswers3 = rnd.Next(randomAnswers.Count);
            string badAnswer3 = randomAnswers[idRandomAnswers3];
            randomAnswers.RemoveAt(idRandomAnswers3);

            string[] badAnswers = { badAnswer1, badAnswer2, badAnswer3 };
            int idBadAnswer = 0;

            for (int i = 0; i < loadQuestionVM.Answers.Count(); i++)
            {
                if (loadQuestionVM.Answers[i].Text == "")
                {
                    loadQuestionVM.Answers[i].Text = badAnswers[idBadAnswer];
                    idBadAnswer++;
                }
            }

            return randomQuestion.Id;
        }

        public bool CheckAnswer(string answerButton, int id)
        {
            var actualQuestion = ShowQuestionById(id);
            actualQuestion.Choice = answerButton;

            if (answerButton == actualQuestion.Answer)
            {
                actualQuestion.IsCorrectAnswer = true;
                return true;
            }
            else
                actualQuestion.IsCorrectAnswer = false;

            return false;
        }

        public int UpdateProgress()
        {
            int listAllQuestions = Questions.Where(x => x.IsDeleted != true).Count();
            int listCorrectQuestions = Questions.Where(x => x.IsDeleted != true && x.IsCorrectAnswer == true).Count();

            int percentProgress = (listCorrectQuestions * 100) / listAllQuestions;

            return percentProgress;
        }

        public void RestartProgress()
        {
            Questions.Where(x => x.IsDeleted != true && x.IsCorrectAnswer == true).ToList().ForEach(x => x.IsCorrectAnswer = false);
        }

        public bool IsAnyQuestion()
        {
            int count = Questions.Where(x => x.IsDeleted != true && x.IsCorrectAnswer == false).Count();

            if (count > 0)
                return true;

            return false;
        }

        public bool IsEnoughToQuiz()
        {
            int count = Questions.Where(x => x.IsDeleted != true).Count();

            if (count > 3)
                return true;

            return false;
        }

        public void Initialize()
        {
            AddNewQuestion("samochód", "car", "easy");
            AddNewQuestion("dom", "house", "easy");
            AddNewQuestion("kwiat", "flower", "easy");
            AddNewQuestion("pies", "dog", "easy");
            AddNewQuestion("pokój", "room", "easy");
            AddNewQuestion("zapach", "smell", "easy");
            AddNewQuestion("dotyk", "touch", "easy");
            AddNewQuestion("wzrok", "eyesight", "easy");
            AddNewQuestion("trawnik", "lawn", "easy");
            AddNewQuestion("lodówka", "fridge", "easy");
            AddNewQuestion("przewodniczący klasy", "prefect", "medium");
            AddNewQuestion("nieobecność", "absence", "medium");
            AddNewQuestion("nadużywać", "abuse", "medium");
            AddNewQuestion("krzew", "bush", "medium");
            AddNewQuestion("zdolność", "capacity", "medium");
            AddNewQuestion("wózek", "cart", "medium");
            AddNewQuestion("przyłapać", "catch", "medium");
            AddNewQuestion("powodować", "cause", "medium");
            AddNewQuestion("pewność siebie", "confidence", "medium");
            AddNewQuestion("zamieszanie", "confusion", "medium");
            AddNewQuestion("nieuchwytny", "elusive", "hard");
            AddNewQuestion("śluza", "floodgate", "hard");
            AddNewQuestion("piesza wycieczka", "hike", "hard");
            AddNewQuestion("zrzeczenie się", "waiver", "hard");
            AddNewQuestion("wypowiedzenie", "termination", "hard");
            AddNewQuestion("spółka zależna", "subsidiary", "hard");
            AddNewQuestion("opłaty", "surcharges", "hard");
            AddNewQuestion("CV", "resume", "hard");
            AddNewQuestion("kapitał", "asset", "hard");
            AddNewQuestion("likwidacja spółki", "dissolution", "hard");
            AddNewQuestion("współpracownik", "associate", "hard");
            AddNewQuestion("uspokojony", "relieved", "hard");
            AddNewQuestion("tajniak", "sleuth", "hard");
        }
    }
}
