using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskLibraryNumberFive;

namespace TaskTestNumberFive
{
    [TestClass]
    public class NumbersTest
    {
        [TestMethod]
        public void SumOfNumbersTest()
        {
            // исходные данные
            string number = "123";

            int expected = 6;//ожидаемая сумма цифр
            // полученные значения с помощью тестируемого метода:
            Numbers numbers = new Numbers();
            int actual = numbers.SumOfNumbers(number);
            // сравнение ожидаемого результата с полученным:
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SumOfNotNumbersTest()
        {
            bool catched = false;//исключение было поймано
            try
            {
                string number = "123f";
                Numbers numbers = new Numbers();
                numbers.SumOfNumbers(number);
            }
            catch (ArgumentException e)
            {
                catched = true;
            }
            Assert.IsTrue(catched, "не обработаны нецифровые символы");      
        }

        [TestMethod]
        public void SumOfNullNumbersTest()
        {
            string number = null;
            Numbers numbers = new Numbers();
            Assert.ThrowsException<ArgumentException>(() => numbers.SumOfNumbers(number),
                "не обработано null значение");
        }
        [TestMethod]
        public void SumOfEmptyNumbersTest()
        {
            string number = " ";
            Numbers numbers = new Numbers();
            Assert.ThrowsException<ArgumentException>(() => numbers.SumOfNumbers(number),
                "не обработано пустое значение");
        }

    }
}
