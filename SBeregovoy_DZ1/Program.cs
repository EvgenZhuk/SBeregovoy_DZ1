using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBeregovoy_DZ1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              
            // Найти минимальный элемент массива Task1
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };

            int MinElement = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < a[0])
                MinElement = a[i];
            }
            Console.WriteLine(MinElement.ToString());                
            Console.ReadLine();

            


            /// Посчитать сумму элементов массива Task3
            int[] a = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            int Summa = 0;
            for (int i = 0; i < a.Length; i++)
            {                
                Summa += a[i];
            }
            Console.WriteLine(Summa.ToString());
            Console.ReadLine();

            

            // Заполнить массив по возрастанию от 1 до 100 Task4
            int[] array = new int[100];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i+1;
                Console.WriteLine(array[i].ToString());
            }            
            Console.ReadLine();

            


            
             

            // Проверить, что в массиве нет одинаковых чисел Task6

            int[] array = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6, 12 };
            bool flag = false;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] == array[j]) flag = true; 
                    else flag = false;
                }
            }
            if (flag == true)  
                Console.WriteLine("Имеются одинаковые числа"); 
            else Console.WriteLine("Нет одинаковых чисел");
            Console.ReadLine();

            


            // Переставить элементы массива в обратном порядке используя вспомогательный массив Task7

            int[] array = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            int[] array_2 = new int[array.Length];
            int j = 0;

            for (int i = array.Length-1; i >= 0; i--)
            {
                array_2[j] = array[i];                
                Console.WriteLine(array_2[j].ToString());
                j++;
            }
            Console.ReadLine();

            */


            // Переставить элементы массива в обратном порядке НЕ используя вспомогательный массив Task8

            int[] array = new int[] { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            string str = "";

            for (int i = array.Length - 1; i >= 0; i--)
            {
                str += array[i].ToString() + ", "; // НЕДОПИСАНО
            }
            Console.WriteLine(str);
            Console.ReadLine();

            /*


            // Подсчитать сумму чисел в двухмерном массиве Task9

            int[,] array = new int[,] { { 11, 22, 31 }, { 4, 53, 6 }, { 7, 81, 90 } };
            int SUM = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                SUM = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    SUM += array[i, j];
                }
                Console.WriteLine(SUM);
            }
            Console.ReadLine();

            


            // Заполнить двумерный массив 10 на 10 случайными числами от 1 до 9 и вывести на экран консоли Task10

            int[,] array = new int [10,10];
            Random rnd = new Random();
            string STR = "";

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(1,10);
                }                
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                STR = "";
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    STR += array[i, j].ToString()+"  ";                    
                }
                Console.WriteLine(STR);
            }
            Console.ReadLine();
                        


            // Двумерный массив скопировать в одномерный Task11

            int[,] array = new int[,] { { 11, 22, 31 }, { 4, 53, 6 }, { 7, 81, 90 } };
            int[] array_2 = new int[array.Length];
            int a = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array_2[a] = array[i, j];
                    a++;
                }
            }

            foreach (int q in array_2)
            {
                Console.Write($"{q}+\t");
            }
            Console.ReadLine();

            


            // Заполнить двумерный массив 10 на 10 случайными числами от 1 до 99 и определить количество четных чисел в массиве Task12

            int[,] array = new int[10, 10];
            Random rnd = new Random();
            int KOL = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(1, 99);
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                string STR = "";
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    STR += array[i, j].ToString() + "  ";
                }
                Console.WriteLine(STR);
            }
            Console.WriteLine();
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int ostatok = array[i, j] % 2;
                    if (ostatok == 0)
                    {
                        Console.Write(array[i, j].ToString() + "  ");
                        KOL++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();   
            Console.WriteLine(KOL);
            Console.ReadLine();
            */
        }
    }
}
