using System;

class RemoveWords
{
    static void Main()
    {
        Console.Write("Введите текст: ");
        string input = Console.ReadLine();
        Console.Write("Введите количество слов для удаления: ");
        int x = int.Parse(Console.ReadLine());

        string[] words = input.Split(' ');

        if (x >= words.Length)
        {
            Console.WriteLine("Результат: ");
        }
        else
        {
            // Удаление первых X слов без использования LINQ
            string result = "";
            for (int i = x; i < words.Length; i++)
            {
                result += words[i] + " ";
            }
            result = result.Trim();
            Console.WriteLine("Результат: " + result);
        }
    }
}
