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
        public void CheckPolishWorld()
        {
            //Arrange
            string world = "鄴單";
            string world2 = "鄴單45";
            string world3 = "45鄴單";
            string world4 = "鄴45單";
            string world5 = "45";
            string world6 = "";
            string world7 = "test%";

            ValidationService validationService = new ValidationService();

            //Act
            bool properWorld = validationService.CheckPolishWorld(world);
            bool numbersAtTheEnd = validationService.CheckPolishWorld(world2);
            bool numbersAtTheBeginning = validationService.CheckPolishWorld(world3);
            bool numbersInside = validationService.CheckPolishWorld(world4);
            bool onlyNumbers = validationService.CheckPolishWorld(world5);
            bool nothing = validationService.CheckPolishWorld(world6);
            bool specialSigns = validationService.CheckPolishWorld(world7);

            //Assert
            properWorld.Should().BeTrue();
            numbersAtTheEnd.Should().BeFalse();
            numbersAtTheBeginning.Should().BeFalse();
            numbersInside.Should().BeFalse();
            onlyNumbers.Should().BeFalse();
            nothing.Should().BeFalse();
            specialSigns.Should().BeFalse();
        }

        [Fact]
        public void CheckEnglishWorldWithProperWorld()
        {
            //Arrange
            string world = "car";
            string world2 = "鄴單";
            string world3 = "car45";
            string world4 = "45car";
            string world5 = "c45ar";
            string world6 = "45";
            string world7 = "";
            string world8 = "car%";

            ValidationService validationService = new ValidationService();

            //Act
            bool properWorld = validationService.CheckEnglishWorld(world);
            bool polishWorld = validationService.CheckEnglishWorld(world2);
            bool numbersAtTheEnd = validationService.CheckEnglishWorld(world3);
            bool numbersAtTheBeginning = validationService.CheckEnglishWorld(world4);
            bool numbersInside = validationService.CheckEnglishWorld(world5);
            bool onlyNumbers = validationService.CheckEnglishWorld(world6);
            bool nothing = validationService.CheckEnglishWorld(world7);
            bool specialSigns = validationService.CheckEnglishWorld(world8);

            //Assert
            properWorld.Should().BeTrue();
            polishWorld.Should().BeFalse();
            numbersAtTheEnd.Should().BeFalse();
            numbersAtTheBeginning.Should().BeFalse();
            numbersInside.Should().BeFalse();
            onlyNumbers.Should().BeFalse();
            nothing.Should().BeFalse();
            specialSigns.Should().BeFalse();
        }

    }
}
