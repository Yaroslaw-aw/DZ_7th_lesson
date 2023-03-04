//Задача 50. Напишите программу, которая на вход принимает
//позиции элемента в двумерном массиве, и возвращает значение
//этого элемента или же указание, что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17->такого числа в массиве нет

namespace DZ_7th_lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] dz_array;
            
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            if (m > dz_array.GetLength(0) || n > dz_array.GetLength(1))
            {
                Console.WriteLine("Такого числа в массиве нет");
            }
            else
            {
                Console.WriteLine(dz_array[m-1, n-1]);
            }
        }
    }
}