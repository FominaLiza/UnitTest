using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TaskLibraryNumberFour
{
    public class RegexEmail
    {
        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) throw new ArgumentException("Email не должен быть пустым");

            // Регулярное выражение для проверки электронной почты
            string pattern = @"([a-zA-Z_]+@[a-zA-Z_]+\.[a-zA-Z]{2,3})";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }

    }
}
