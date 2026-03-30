using System;
using ClassLibraryLab2; 

class Program
{
    static void Main()
    {
        StringAndArrayTools tools = new StringAndArrayTools();

        string sentence = "Пiдгорний Олександр Сергiйович";
        char letter = 'а';
        int count = tools.CountCharOccurrences(sentence, letter);
        Console.WriteLine($"Символ '{letter}' зустрiчається {count} разiв.");

        int[] numbers = { 5, 2, 8, 1, 9 };
        tools.SortArrayAscending(numbers);
        Console.WriteLine("Вiдсортований масив: " + string.Join(", ", numbers));
    }
}
