using Homework4.DZZ4;
using System;
using System.Threading;

public class Program
{
    // Задание 1

    public static int GetSum(params int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }

    public static void GetProduct(ref int product, params int[] numbers)
    {
        product = 1;
        foreach (int number in numbers)
        {
            product *= number;
        }
    }

    public static void GetAverage(int[] numbers, out double average)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        average = (double)sum / numbers.Length;
    }

    // Задание 2

    public static void PrintDigit(int number)
    {
        string[] digits =
        {
            " ### \n#   #\n#   #\n#   #\n ### ",
            "  #  \n ##  \n  #  \n  #  \n ### ",
            " ### \n#   #\n   # \n  #  \n#####",
            " ### \n    #\n ### \n    #\n ### ",
            "#   #\n#   #\n#####\n    #\n    #",
            "#####\n#    \n#### \n    #\n#### ",
            " ### \n#    \n#### \n#   #\n ### ",
            "#####\n    #\n   # \n  #  \n  #  ",
            " ### \n#   #\n ### \n#   #\n ### ",
            " ### \n#   #\n ####\n    #\n ### "
        };

        Console.WriteLine(digits[number]);
    }
    public static void Main()
    {
        // Задание 1

        Random random = new Random();
        int[] numbers = new int[20];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 101);
        }
        Console.WriteLine("Массив:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
        Console.Write("Введите первое число: ");
        int firstNumber;
        while (!int.TryParse(Console.ReadLine(), out firstNumber))
        {
            Console.Write("Введите число: ");
        }
        Console.Write("Введите второе число: ");
        int secondNumber;
        while (!int.TryParse(Console.ReadLine(), out secondNumber))
        {
            Console.Write("Введите число: ");
        }
        int firstIndex = Array.IndexOf(numbers, firstNumber);
        int secondIndex = Array.IndexOf(numbers, secondNumber);
        if (firstIndex != -1 && secondIndex != -1)
        {
            int temp = numbers[firstIndex];
            numbers[firstIndex] = numbers[secondIndex];
            numbers[secondIndex] = temp;
        }

        Console.WriteLine("Новый массив:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Сумма: " + GetSum(numbers));
        int product = 0;
        GetProduct(ref product, numbers);
        Console.WriteLine("Произведение: " + product);
        double average;
        GetAverage(numbers, out average);
        Console.WriteLine("Среднее: " + average);

        // Задание 2

        Console.WriteLine();
        Console.WriteLine("Введите число от 0 до 9.");
        Console.WriteLine("Для выхода напишите exit или закрыть.");

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "exit" || input.ToLower() == "закрыть")
            {
                break;
            }
            int digit;
            if (!int.TryParse(input, out digit))
            {
                throw new Exception("Нужно ввести число.");
            }

            if (digit < 0 || digit > 9)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("Ошибка! Число должно быть от 0 до 9.");
                Thread.Sleep(3000);
                Console.ResetColor();
                Console.Clear();
                continue;
            }

        }
    }
}
class Programm
{
    static void Main()
    {
        Grandfather ded1 = new Grandfather
        {
            Name = "Иван",
            Phrases = new string[] { "Проститутки!" },
            Bruises = 0
        };

        Grandfather ded2 = new Grandfather
        {
            Name = "Петр",
            Phrases = new string[] { "Гады!", "Проститутки!" },
            Bruises = 0
        };

        Grandfather ded3 = new Grandfather
        {
            Name = "Сергей",
            Phrases = new string[] { "Гады!", "Дураки!", "Проститутки!" },
            Bruises = 0
        };

        Grandfather ded4 = new Grandfather
        {
            Name = "Алексей",
            Phrases = new string[] { "Гады!", "Дураки!", "Проститутки!", "Безобразие!" },
            Bruises = 0
        };

        Grandfather ded5 = new Grandfather
        {
            Name = "Николай",
            Phrases = new string[] { "Гады!", "Дураки!", "Проститутки!", "Безобразие!", "Вот молодежь!" },
            Bruises = 0
        };
        string[] badWords = { "Проститутки!", "Гады!" };
        Console.WriteLine(ded1.Name + ": " + (badWords));
        Console.WriteLine(ded2.Name + ": " + (badWords));
        Console.WriteLine(ded3.Name + ": " + (badWords));
        Console.WriteLine(ded4.Name + ": " + (badWords));
        Console.WriteLine(ded5.Name + ": " + (badWords));
    }
}
