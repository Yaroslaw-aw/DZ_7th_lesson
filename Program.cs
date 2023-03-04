//Задача 47. Задайте двумерный массив размером m×n,
//заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

namespace DZ_7th_lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = new Random().Next(2, 5);
            int n = new Random().Next(2, 5);


            double[,] dz_array = FillArray(m, n);

            

            double[,] FillArray(int m, int n)
            {
                double[,] _array = new double[m, n];

                for (int i = 0; i < _array.GetLength(0); i++)
                {
                    for (int j = 0;  j < _array.GetLength(1); j++)
                    {
                        _array[i, j] = new Random().NextDouble()*20-10;
                        Console.Write($"{Math.Round(_array[i, j], 2)} ");
                    }
                    Console.WriteLine();
                }
                return _array;
            }
        }
    }
}