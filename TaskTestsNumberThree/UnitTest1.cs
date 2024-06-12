using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskLibraryNumberThree;

namespace TaskTestsNumberThree
{
    [TestClass]
    public class YearsTest
    {
        [TestMethod]
        public void CalculateDaysInNormalYearTest()
        {
            // исходные данные для невисокосного года
            int year = 2021;

            int expected = 365;//ожидаемое количество дней в году
            // полученные значения с помощью тестируемого метода:
            Years y = new Years();
            int actual = y.CalculateDaysInYearArea(year);
            // сравнение ожидаемого результата с полученным:
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateDaysInLeapYearTest()
        {
            // исходные данные для високосного года
            int year = 2024;

            int expected = 366;//ожидаемое количество дней в году
            // полученные значения с помощью тестируемого метода:
            Years y = new Years();
            int actual = y.CalculateDaysInYearArea(year);
            // сравнение ожидаемого результата с полученным:
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalculateZeroYearTest()
        {
            int year = 0;

            Years y = new Years();
            Assert.ThrowsException<ArgumentException>(() => y.CalculateDaysInYearArea(year),
                "не обработано нулевое значение года");
        }
        [TestMethod]
        public void CalculateNegativeYearTest()
        {
            bool catched = false;//исключение было поймано
            try
            {
                int year = -300;

                Years y = new Years();
                y.CalculateDaysInYearArea(year);
            }
            catch (ArgumentException e)
            {
                catched = true;
            }
            Assert.IsTrue(catched, "не обработано отрицательное значение года");
            
        }
    }
}
