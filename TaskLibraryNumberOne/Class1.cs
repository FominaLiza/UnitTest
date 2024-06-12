using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLibraryNumberOne
{
    public class TaskOne
    {
        
        public string LettersArea(int n)
        {
            if (n < 1 || n > 26) throw new System.ArgumentException("N должно входить в интервал от 1 до 26");

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                // Получаем ASCII-код для i-й буквы алфавита
                int asciiCode = Convert.ToInt32(char.ToUpper(Convert.ToChar(65 + i)));
                // Добавляем символ к результату
                result.Append(char.ToUpper(Convert.ToChar(65 + i)));
            }

            return result.ToString();
        }

    }
}
