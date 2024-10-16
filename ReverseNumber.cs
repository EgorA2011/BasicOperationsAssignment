using System;

class ReverseNumber
{
    static void Main()
    {
        Console.Write("Введите число (не меньше 5 цифр): ");
        string input = Console.ReadLine();
        bool isNegative = input.StartsWith("-");

        // Убираем знак и нули в начале для корректного обращения
        string processedInput = input.TrimStart('-').TrimStart('0');

        // Перестановка цифр вручную
        char[] charArray = processedInput.ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new string(charArray);
        
        int reversedNumber = int.Parse(reversedString);

        // Если число было отрицательным, добавляем знак
        if (isNegative)
        {
            reversedNumber *= -1;
        }
        
        Console.WriteLine("Результат: " + reversedNumber);
    }
}
