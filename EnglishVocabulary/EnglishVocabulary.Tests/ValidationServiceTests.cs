using EnglishVocabulary.App.Concrete;
using EnglishVocabulary.Domain.ViewModel;
using FluentAssertions;
using System;
using System.Windows.Forms;
using Xunit;

namespace EnglishVocabulary.Tests
{
    public class ValidationServiceTests
    {
        [Fact]
        public void CheckPolishWordWithProperWord()
        {
            //Arrange
            string word = "鄴單";

            ValidationService validationService = new ValidationService();

            //Act
            bool properWord = validationService.CheckPolishWord(word);

            //Assert
            properWord.Should().BeTrue();
        }

        [Fact]
        public void CheckPolishWordWithWrongWord()
        {
            //Arrange
            string word = "鄴單45";
            string word2 = "45鄴單";
            string word3 = "鄴45單";
            string word4= "45";
            string word5= "";
            string word6= "test%";

            ValidationService validationService = new ValidationService();

            //Act
            bool numbersAtTheEnd = validationService.CheckPolishWord(word);
            bool numbersAtTheBeginning = validationService.CheckPolishWord(word2);
            bool numbersInside = validationService.CheckPolishWord(word3);
            bool onlyNumbers = validationService.CheckPolishWord(word4);
            bool nothing = validationService.CheckPolishWord(word5);
            bool specialSigns = validationService.CheckPolishWord(word6);

            //Assert
            numbersAtTheEnd.Should().BeFalse();
            numbersAtTheBeginning.Should().BeFalse();
            numbersInside.Should().BeFalse();
            onlyNumbers.Should().BeFalse();
            nothing.Should().BeFalse();
            specialSigns.Should().BeFalse();
        }

        [Fact]
        public void CheckEnglishWordWithProperWord()
        {
            //Arrange
            string word = "car";

            ValidationService validationService = new ValidationService();

            //Act
            bool properWord = validationService.CheckEnglishWord(word);

            //Assert
            properWord.Should().BeTrue();
        }

        [Fact]
        public void CheckEnglishWordWithWrongWord()
        {
            //Arrange
            string word = "鄴單";
            string word2 = "car45";
            string word3 = "45car";
            string word4 = "c45ar";
            string word5 = "45";
            string word6 = "";
            string word7 = "car%";

            ValidationService validationService = new ValidationService();

            //Act
            bool polishWord = validationService.CheckEnglishWord(word);
            bool numbersAtTheEnd = validationService.CheckEnglishWord(word2);
            bool numbersAtTheBeginning = validationService.CheckEnglishWord(word3);
            bool numbersInside = validationService.CheckEnglishWord(word4);
            bool onlyNumbers = validationService.CheckEnglishWord(word5);
            bool nothing = validationService.CheckEnglishWord(word6);
            bool specialSigns = validationService.CheckEnglishWord(word7);

            //Assert
            polishWord.Should().BeFalse();
            numbersAtTheEnd.Should().BeFalse();
            numbersAtTheBeginning.Should().BeFalse();
            numbersInside.Should().BeFalse();
            onlyNumbers.Should().BeFalse();
            nothing.Should().BeFalse();
            specialSigns.Should().BeFalse();
        }
    }
}
