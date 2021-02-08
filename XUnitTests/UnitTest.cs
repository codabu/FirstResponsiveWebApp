using System;
using Xunit;
using FirstResponsiveWebAppBurton.Models;

namespace XUnitTests
{
    public class UnitTest
    {
        [Fact]
        public void TestForNoBirthdayYetThisYear()
        {

            //Arrange
            string name = "Corry Burton";

            int day = 10;
            int month = 3;
            int year = 1995;

            string expected = "Corry Burton is 25 years old.";
            string actual;

            //act
            AgeCalculatorModel corry = new AgeCalculatorModel
            {
                Name = name,
                Day = day,
                Month = month,
                Year = year
            };
            actual = corry.AgeThisYear();

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestForBirthDayAlreadyThisYear()
        {
            //Arrange
            string name = "Corry Burton";

            int day = 10;
            int month = 1;
            int year = 1995;

            string expected = "Corry Burton is 26 years old.";
            string actual;

            //act
            AgeCalculatorModel corry = new AgeCalculatorModel
            {
                Name = name,
                Day = day,
                Month = month,
                Year = year
            };
            actual = corry.AgeThisYear();

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestForBirthdayIsToday()
        {
            //Note this test will only work correctly in the year of 2021
            //Arrange
            string name = "Corry Burton";

            int day = int.Parse(DateTime.Now.ToString("dd"));
            int month = int.Parse(DateTime.Now.ToString("MM"));
            int year = 1995;

            string expected = "Corry Burton is 26 years old.";
            string actual;

            //act
            AgeCalculatorModel corry = new AgeCalculatorModel
            {
                Name = name,
                Day = day,
                Month = month,
                Year = year
            };
            actual = corry.AgeThisYear();

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestForNoBirthdayYetThisYear2()
        {

            //Arrange
            string name = "Jon Smith";

            int day = 10;
            int month = 3;
            int year = 1950;

            string expected = "Jon Smith is 70 years old.";
            string actual;

            //act
            AgeCalculatorModel jon = new AgeCalculatorModel
            {
                Name = name,
                Day = day,
                Month = month,
                Year = year
            };
            actual = jon.AgeThisYear();

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestForBirthDayAlreadyThisYear2()
        {
            //Arrange
            string name = "Jon Smith";

            int day = 10;
            int month = 1;
            int year = 1950;

            string expected = "Jon Smith is 71 years old.";
            string actual;

            //act
            AgeCalculatorModel jon = new AgeCalculatorModel
            {
                Name = name,
                Day = day,
                Month = month,
                Year = year
            };
            actual = jon.AgeThisYear();

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestForBirthdayIsToday2()
        {
            //Note this test will only work correctly in the year of 2021
            //Arrange
            string name = "Jon Smith";

            int day = int.Parse(DateTime.Now.ToString("dd"));
            int month = int.Parse(DateTime.Now.ToString("MM"));
            int year = 1950;

            string expected = "Jon Smith is 71 years old.";
            string actual;

            //act
            AgeCalculatorModel jon = new AgeCalculatorModel
            {
                Name = name,
                Day = day,
                Month = month,
                Year = year
            };
            actual = jon.AgeThisYear();

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
