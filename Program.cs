using System;

namespace Задание_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<<<Сумма матриц>>>");
            Console.WriteLine("Введите количество строк в матрицах:");

            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество строк в матрицах:");

            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите максимальное значение числа в матрицах:");

            int n = int.Parse(Console.ReadLine());

            int[,] matrix1 = new int[y, x];
            int[,] matrix2 = new int[y, x];
            int[,] matrixSum = new int[y, x];

            Random rnd = new Random();
            
            Console.WriteLine();
            Console.WriteLine("Матрица №1:");
            Console.WriteLine();


            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    matrix1[i, j] = rnd.Next(n);                                 //Заполнение матрицы
                    Console.Write($"{matrix1[i, j],4} ");                       //Вывод каждого элемента матрицы
                }
                Console.WriteLine();
            }

            Console.ReadKey(true);

            Console.WriteLine();
            Console.WriteLine("Матрица №2:");
            Console.WriteLine();

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    matrix2[i, j] = rnd.Next(n);                                 //Заполнение матрицы
                    Console.Write($"{matrix2[i, j],4} ");                       //Вывод каждого элемента матрицы
                }
                Console.WriteLine();
            }

            Console.ReadKey(true);

            Console.WriteLine();
            Console.WriteLine("Сумма матриц:");
            Console.WriteLine();

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    matrixSum[i, j] = matrix1[i,j]+matrix2[i,j];                  //Заполнение матрицы суммами элементов двух матриц
                    Console.Write($"{matrixSum[i, j],4} ");                       //Вывод каждого элемента матрицы
                }
                Console.WriteLine();
            }

            Console.ReadKey(true);
        }
    }
}
