using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLibraryNumberFive
{
    public class Numbers
    {
        public int SumOfNumbers(string number)
        {
            if (string.IsNullOrWhiteSpace(number)) throw new System.ArgumentException("Строка не должна быть пустой");

            int sum = 0;
            foreach (char digit in number)
            {
                if (!char.IsDigit(digit)) throw new System.ArgumentException("Строка не содержит цифр");
                sum += digit - '0'; // Преобразование символа в цифру
            }

            return sum;
        }
    }
}
