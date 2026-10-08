using System;
class Programmm
{
    // Упражнение 5.1
    static int Max(int firstNumber, int secondNumber)
    {
        if (firstNumber > secondNumber)
            return firstNumber;
        return secondNumber;
    }
    // Упражнение 5.2
    static void Swap(ref int firstNumber, ref int secondNumber)
    {
        int temporaryNumber = firstNumber;
        firstNumber = secondNumber;
        secondNumber = temporaryNumber;
    }
    // Упражнение 5.3
    static bool Factorial(int number, out int result)
    {
        result = 1;
        try
        {
            checked
            {
                for (int i = 1; i <= number; i++)
                    result *= i;
            }

            return true;
        }
        catch (OverflowException)
        {
            result = 0;
            return false;
        }
    }
    // Упражнение 5.4
    static int RecursiveFactorial(int number)
    {
        if (number == 0 || number == 1)
            return 1;
        return number * RecursiveFactorial(number - 1);
    }
    // Домашнее задание 5.1
    static int Nod(int firstNumber, int secondNumber)
    {
        while (secondNumber != 0)
        {
            int remainder = firstNumber % secondNumber;
            firstNumber = secondNumber;
            secondNumber = remainder;
        }
        return firstNumber;
    }
    static int Nod(int firstNumber, int secondNumber, int thirdNumber)
    {
        return Nod(Nod(firstNumber, secondNumber), thirdNumber);
    }

    // Домашнее задание 5.2
    static int Fibonacci(int number)
    {
        if (number == 1 || number == 2)
            return 1;

        return Fibonacci(number - 1) + Fibonacci(number - 2);
    }
    static int ReadNumber()
    {
        int number;
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Введите целое число:");
        }
        return number;
    }
    static void Main()
    {
        // Упражнение 5.1
        Console.WriteLine("Упражнение 5.1");
        Console.WriteLine("Введите первое число:");
        int firstNumber = ReadNumber();
        Console.WriteLine("Введите второе число:");
        int secondNumber = ReadNumber();
        Console.WriteLine("Максимальное число: " + Max(firstNumber, secondNumber));

        // Упражнение 5.2
        Console.WriteLine("\nУпражнение 5.2");
        Console.WriteLine("До обмена: " + firstNumber + " " + secondNumber);
        Swap(ref firstNumber, ref secondNumber);
        Console.WriteLine("После обмена: " + firstNumber + " " + secondNumber);

        // Упражнение 5.3
        Console.WriteLine("\nУпражнение 5.3");
        Console.WriteLine("Введите число:");
        int factorialNumber = ReadNumber();
        int factorialResult;
        if (Factorial(factorialNumber, out factorialResult))
            Console.WriteLine("Факториал: " + factorialResult);
        else
            Console.WriteLine("Произошло переполнение");

        // Упражнение 5.4
        Console.WriteLine("\nУпражнение 5.4");
        Console.WriteLine("Введите число:");
        int recursiveNumber = ReadNumber();
        Console.WriteLine("Факториал: " + RecursiveFactorial(recursiveNumber));

        // Домашнее задание 5.1
        Console.WriteLine("\nДомашнее задание 5.1");
        Console.WriteLine("Введите первое число:");
        int firstNodNumber = ReadNumber();
        Console.WriteLine("Введите второе число:");
        int secondNodNumber = ReadNumber();
        Console.WriteLine("НОД двух чисел: " + Nod(firstNodNumber, secondNodNumber));
        Console.WriteLine("Введите третье число:");
        int thirdNodNumber = ReadNumber();
        Console.WriteLine("НОД трех чисел: " + Nod(firstNodNumber, secondNodNumber, thirdNodNumber));

        // Домашнее задание 5.2
        Console.WriteLine("\nДомашнее задание 5.2");
        Console.WriteLine("Введите номер числа Фибоначчи:");
        int fibonacciNumber = ReadNumber();
        Console.WriteLine("Число Фибоначчи: " + Fibonacci(fibonacciNumber));
    }
}