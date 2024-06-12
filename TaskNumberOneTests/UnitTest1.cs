using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskLibraryNumberOne;

namespace TaskNumberOneTests
{
    [TestClass]
    public class TaskOneTest
    {
        [TestMethod]
        public void LettersAreaTest()
        {
            // исходные данные
            int n = 5;
            string expected = "ABCDE";//ожидаемое значение
            //полученные значения с помощью тестируемого метода:
            TaskOne t = new TaskOne();
            string actual = t.LettersArea(n);
            // сравнение ожидаемого результата с полученным:
            Assert.AreEqual(expected, actual);
            
        }
        
        [TestMethod]
        public void LettersAreaInvalidDataTest1()
        {
            bool catched = false;//исключение было поймано
            try
            {
                int n = 27;
                TaskOne t = new TaskOne();
                t.LettersArea(n);
            }
            catch (ArgumentException e)
            {
                catched = true;
            }
            Assert.IsTrue(catched, "не обработаны допустимые данные");
        }
        
        [TestMethod]
        public void LettersAreaInvalidDataTest2()
        {
            int n = 27;
            TaskOne t = new TaskOne();
            Assert.ThrowsException<ArgumentException>(() => t.LettersArea(n),
                "не обработаны другие символы");
        }
    }
}
