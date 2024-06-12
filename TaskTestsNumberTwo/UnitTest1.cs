using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaskLibraryNumberTwo;

namespace TaskTestsNumberTwo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculatePositiveDiscriminantTest()
        {
            // исходные данные для положительного дискриминанта
            double a = 2;
            double b = 5;
            double c = 3;

            int expected = 2;//ожидаемое количество корней
            // полученные значения с помощью тестируемого метода:
            Equation equation = new Equation();
            double[] root = equation.CalculateEquationArea(a, b, c);
            // сравнение ожидаемого результата с полученным:
            Assert.AreEqual(expected, root.Length);

        }
        [TestMethod]
        public void CalculateZeroDiscriminantTest()
        {
            // исходные данные для нулевого дискриминанта
            double a = 1;
            double b = 4;
            double c = 4;

            int expected = 1;//ожидаемое количество корней
            // полученные значения с помощью тестируемого метода:
            Equation equation = new Equation();
            double[] root = equation.CalculateEquationArea(a, b, c);

            Assert.AreEqual(expected, root.Length);
            
        }
        [TestMethod]
        public void CalculateZeroATest()
        {  
            double a = 0;
            double b = 4;
            double c = 4;

            Equation equation = new Equation();
            Assert.ThrowsException<ArgumentException>(() => equation.CalculateEquationArea(a, b, c),
                "не обработано нулевое значение коэффициента А");
        }

    }
}
