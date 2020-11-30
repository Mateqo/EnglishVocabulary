using EnglishVocabulary.App.Abstract;
using EnglishVocabulary.App.Concrete;
using EnglishVocabulary.Domain.Entity;
using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace EnglishVocabulary.Tests
{
    public class QuestionServiceTests
    {
        [Fact]
        public void CanAddNewQuestion()
        {
            //Arrange
            Question question = new Question(1,"samochód","car","easy");
            var questionService = new QuestionService();
            var nextId = questionService.Questions.Count()+1;

            //Act
            var returnedQuestionId = questionService.AddNewQuestion(question.Content,question.Answer,question.Level);

            //Assert
            returnedQuestionId.Should().NotBe(0);
            returnedQuestionId.Should().Be(nextId);
        }

        [Fact]
        public void CanShowAllQuestions()
        {
            //Arrange
            var questionService = new QuestionService();
            questionService.AddNewQuestion("samochód", "car", "easy");

            //Act
            var returnedListOfQuestions = questionService.ShowAllQuestions();

            //Assert
            returnedListOfQuestions.Should().NotBeNullOrEmpty();
            returnedListOfQuestions.Should().BeOfType(typeof(List<Question>));              
        }

        [Fact]
        public void CanShowQuestionByLevel()
        {
           //Arrange
            var questionService = new QuestionService();
            var filtr = "new";
            questionService.AddNewQuestion("samochód", "car", filtr);

            //Act
            var returnedListOfQuestionsByLevel = questionService.ShowQuestionsByLevel(filtr);
            var returnedListOfQuestionsEasy = questionService.ShowQuestionsByLevel("easy");

            //Assert
            returnedListOfQuestionsByLevel.Should().NotBeNullOrEmpty();
            returnedListOfQuestionsByLevel.Should().HaveCount(1);
            returnedListOfQuestionsEasy.Should().HaveCountGreaterThan(5); // default: 10 easy questions
            returnedListOfQuestionsByLevel.Should().BeOfType(typeof(List<Question>));
            returnedListOfQuestionsEasy.Should().BeOfType(typeof(List<Question>));
        }

        [Fact]
        public void CanShowQuestionById()
        {
            //Arrange
            var questionService = new QuestionService();
            questionService.AddNewQuestion("samochód", "car", "test");
            var Id = questionService.Questions.Count();

            //Act
            var returnedQuestion = questionService.ShowQuestionById(Id);

            //Assert
            returnedQuestion.Should().NotBeNull();
            returnedQuestion.Content.Should().Be("samochód");
            returnedQuestion.Answer.Should().Be("car");
            returnedQuestion.Level.Should().Be("test");
            returnedQuestion.Id.Should().Be(Id);
            returnedQuestion.Should().BeOfType(typeof(Question));
        }

        [Fact]
        public void CanDeleteQuestionById()
        {
            //Arrange
            var questionService = new QuestionService();
            questionService.AddNewQuestion("samochód", "car", "test");
            var Id = questionService.Questions.Count();
            var wrongId=100;

            //Act
            var isDeletedProperId = questionService.DeleteQuestionById(Id);
            var isDeletedWrongId = questionService.DeleteQuestionById(wrongId);
            var returnedQuestion = questionService.ShowQuestionById(Id);

            //Assert
            isDeletedProperId.Should().BeTrue();
            isDeletedWrongId.Should().BeFalse();
            returnedQuestion.IsDeleted.Should().BeTrue();
        }

        [Fact]
        public void CheckAnswer()
        {
            //Arrange
            var questionService = new QuestionService();
            questionService.AddNewQuestion("samochód", "car", "easy");
            var Id = questionService.Questions.Count();
            var properAnswer = "car";
            var wrongAnswer = "snake";

            //Act
            var isCorrect = questionService.CheckAnswer(properAnswer, Id);
            var isWrong = questionService.CheckAnswer(wrongAnswer, Id);

            //Assert
            isCorrect.Should().BeTrue();
            isWrong.Should().BeFalse();
        }

        [Fact]
        public void CheckProgressCompletedQuestions()
        {
            //Arrange
            var questionService = new QuestionService();
            questionService.AddNewQuestion("samochód", "car", "easy");
            questionService.AddNewQuestion("pies", "dog", "easy");

            //Act
            foreach (var question in questionService.Questions)
            {
                question.IsCorrectAnswer = true;
            }

            var percentProgress = questionService.UpdateProgress();

            //Assert
            percentProgress.Should().Be(100);
        }

        [Fact]
        public void CanRestartProgress()
        {
            //Arrange
            var questionService = new QuestionService();
            questionService.AddNewQuestion("samochód", "car", "easy");
            questionService.AddNewQuestion("pies", "dog", "easy");

            //Act
            foreach (var question in questionService.Questions)
            {
                question.IsCorrectAnswer = true;
            }

            var percentProgress = questionService.UpdateProgress();
            questionService.RestartProgress();
            percentProgress = questionService.UpdateProgress();

            //Assert
            percentProgress.Should().Be(0);
        }

        [Fact]
        public void CheckIsAnyQuestion()
        {
            //Arrange
            var questionService = new QuestionService();
            questionService.AddNewQuestion("samochód", "car", "easy");
            questionService.AddNewQuestion("pies", "dog", "easy");

            //Act
            foreach (var question in questionService.Questions)
            {
                question.IsDeleted = true;
            }

            var isAnyQuestion = questionService.IsAnyQuestion();

            //Assert
            isAnyQuestion.Should().BeFalse();
        }

        [Fact]
        public void CheckIsEnoughQuestion()
        {
            //Arrange
            var questionService = new QuestionService();

            //Act
            var isEnoughQuestion = questionService.IsAnyQuestion(); // True if Question.Count > 3 (deafult: 33 questions)

            //Assert
            isEnoughQuestion.Should().BeTrue();
        }
    }
}
