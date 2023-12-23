// Задача 1: Задайте значения M и N. Напишите 
// программу, которая выведет все натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не 
// использовать циклы.

// Console.WriteLine("Введите первое число");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int N = Convert.ToInt32(Console.ReadLine());
// int firstElement = M;
// int lastElement = N;

// if(M > N)
// {
//     firstElement = N;
//     lastElement = M;
// }

// PrintNumbers(firstElement, lastElement);
// void PrintNumbers(int startEl, int endEl)
// {
//     Console.Write(startEl +" ");
//     if(startEl == endEl)
//     {
//         return;
//     }
//     PrintNumbers(startEl+1, endEl);
// }

// Задача 2: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два 
// неотрицательных числа m и n. 

// int m = 3;
// int n = 8;

// int Ackermann(int m, int n)
//     {
//         if (m == 0)
//             return n + 1;
//         else if (n == 0)
//             return Ackermann(m - 1, 1);
//         else
//             return Ackermann(m - 1, Ackermann(m, n - 1));
//     }

// int result = Ackermann(m, n);
// Console.WriteLine($"Ackermann({m}, {n}) = {result}");

// Задача 3: Задайте произвольный массив. Выведете 
// его элементы, начиная с конца. Использовать 
// рекурсию, не использовать циклы.

internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Элементы массива в прямом порядке: ");
        PrintArray(array, 0);

        void PrintArray(int[] array, int i)
        {
            if (i == array.Length)
            {
                return;
            }
            Console.Write(array[i] + " ");
            PrintArray(array, i + 1);
        }
        Console.WriteLine();

        Console.WriteLine("Элементы массива в обратном порядке: ");
        PrintArrayReverse(array, array.Length - 1);

        void PrintArrayReverse(int[] array, int i)
        {
            if (i < 0)
            {
                return;
            }
            Console.Write(array[i] + " ");
            PrintArrayReverse(array, i - 1);
        }
    }
}