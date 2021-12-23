using System;

namespace _6._2_15в
{
    class Program
    {
        static void Main(string[] args)
        {
            //6.2 базовый уровень 15v

            int[,] mas = new int[7, 7];
            Random rand = new Random();
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = rand.Next(123);
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine();


            }

            int mainMax = ClassLibrary1.Class1.MaxElementMain(mas);
            int secMax;
            ClassLibrary1.Class1.MaxElementSecondary(mas, out secMax);
            Console.WriteLine("Максимальный элемент главной диагонали = {0}", mainMax);
            Console.WriteLine("Максимальный элемент побочной диагонали = {0}", secMax);
            int p = mainMax * secMax;
            Console.WriteLine("Произведение максимального элемента главной и побочной диагонали = {0}", p);
        }
    }
}
