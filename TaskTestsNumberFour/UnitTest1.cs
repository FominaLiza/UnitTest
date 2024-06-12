using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskLibraryNumberFour;

namespace TaskTestsNumberFour
{
    [TestClass]
    public class RegexTest
    {
        [TestMethod]
        public void ValidEmailTest()
        {
            // исходные данные для правильного Email
            string email = "test@test.test";
            
            bool expected = true;//ожидаемое значение
            // полученные значения с помощью тестируемого метода:
            RegexEmail r = new RegexEmail();
            bool actual = r.IsValidEmail(email);
            // сравнение ожидаемого результата с полученным:
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NotValidEmailTest()
        {
            // исходные данные для неправильного Email
            string email = "test@.com";

            bool expected = false;//ожидаемое значение
            // полученные значения с помощью тестируемого метода:
            RegexEmail r = new RegexEmail();
            bool actual = r.IsValidEmail(email);
            // сравнение ожидаемого результата с полученным:
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void EmptyEmailTest()
        {
            string email = " ";
            RegexEmail r = new RegexEmail();
            Assert.ThrowsException<ArgumentException>(() => r.IsValidEmail(email),
                "не обработано пустое значение Email");
        }
        [TestMethod]
        public void NullEmailTest()
        {
            string email = null;
            RegexEmail r = new RegexEmail();
            Assert.ThrowsException<ArgumentException>(() => r.IsValidEmail(email),
                "не обработано null значение Email");
        }
    }
}
