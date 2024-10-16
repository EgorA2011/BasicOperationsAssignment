using System;

class ReplaceSymbols
{
    static void Main()
    {
        Console.Write("Введите текст: ");
        string input = Console.ReadLine();
        char[] result = input.ToCharArray();

        for (int i = 2; i < result.Length; i += 3)
        {
            result[i] = 'X';
        }
        for (int i = 4; i < result.Length; i += 5)
        {
            result[i] = '9';
        }
        for (int i = 14; i < result.Length; i += 15)
        {
            result[i] = '?';
        }

        Console.WriteLine("Результат: " + new string(result));
    }
}
