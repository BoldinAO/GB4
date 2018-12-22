//Болдин
/*
4. *а) Реализовать класс для работы с двумерным массивом. Реализовать конструктор, заполняющий массив случайными числами.
Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство,
возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, метод, возвращающий номер максимального
элемента массива (через параметры, используя модификатор ref или out)
*б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
Дополнительные задачи
в) Обработать возможные исключительные ситуации при работе с файлами.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxI = 0, maxJ = 0;
            test t = new test();
            //Console.WriteLine("Сумма чисел = {0}", t.Max());
            t.MaxIndex(ref maxI, ref maxJ);
            Console.WriteLine("Максимальный индекс = {0}.{1}",maxI, maxJ);
            Console.ReadKey();
        }
    }

    class test
    {
        static int[,] f = new int[2,2];
        static Random random = new Random();

        int summ { get; set; }
        int min { get; set; }
        int max { get; set; }

        public test()
        {
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                {
                    f[i, j] = random.Next(0, 100);
                    Console.Write(f[i, j] + "\t");
                }
        }

        public int Summ()
        {
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(f[i, j]);
                    summ += f[i, j];
                }
            return summ;
        }

        public int Min()
        {
            min = f[0, 0];
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                {
                    min = min != 0 ? (min > f[i, j] ? f[i, j] : min) : min;
                }
            return min;
        }

        public int Max()
        {
            max = f[0, 0];
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(f[i, j]);
                    max = max != 0 ? (max < f[i, j] ? f[i, j] : max) : max;
                }
            return max;
        }

        public void MaxIndex(ref int maxI, ref int maxJ)
        {
            max = f[0, 0];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if(max < f[i, j])
                    {
                        max = f[i, j];
                        maxI = i;
                        maxJ = j;
                    }
                }
            }
        }
    }
}
