//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее
//арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

namespace DZ_7th_lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = new Random().Next(3,5);
            int n = new Random().Next(3, 5);

            int[,] dz_array = Fill_Array(m, n);

            Average_of_columns(dz_array);


            void Average_of_columns(int[,] _array)
            {
                double average = 0;
                double sum = 0;

                for (int i = 0; i < _array.GetLength(1); i++)
                {
                    sum = 0;

                    for (int j = 0; j < _array.GetLength(0); j++)
                    {
                        sum += _array[j, i];                        
                    }
                    average = sum / _array.GetLength(0);
                    Console.Write(Math.Round(average, 2) + " ");
                }
            }

            int[,] Fill_Array(int m, int n)
            {
                int[,] _array = new int[m, n];

                for (int i = 0; i < _array.GetLength(0); i++)
                {
                    for (int j = 0; j < _array.GetLength(1); j++)
                    {
                        _array[i, j] = new Random().Next(10);
                        Console.Write($"{_array[i, j]} ");
                    }
                    Console.WriteLine();
                }
                return _array;
            }
        }
    }
}