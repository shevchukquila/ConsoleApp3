using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    /// <summary>
    /// hello
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>();//Созданик пустой коллекции
            ints.Add(1);
            ints.Add(10);
            ints.Add(20);
            ints.Add(17);
            ints.Add(10);
            foreach (int i in ints)
            {
                Console.Write($"{i}\t");
            }
            //Добавление целых значений в коллекцию
            Console.WriteLine();
            ints.Insert(0, 500);
            foreach (int i in ints)
            {
                Console.Write($"{i}\t");
            }
            //Вставка элемента по указанному индексу
            Console.WriteLine();
            ints.AddRange(new[] { -5, 0, 14, 8 });
            foreach (int i in ints)
            {
                Console.Write($"{i}\t");
            }
            //Добавление в список одномерного массива
            Console.WriteLine();
            int size = ints.Count;
            Console.WriteLine($"{size}");
            //Определение колличества элементов
            Console.WriteLine();
            Console.WriteLine($"Индекс элемента 17={ints.IndexOf(17)}");
            //Определние индекс с значением 17
            ints.Remove(10);
            foreach (int i in ints)
            {
                Console.Write($"{i}\t");
            }
            //
            Console.WriteLine();
            ints.RemoveAt(2);
            foreach (int i in ints)
            {
                Console.Write($"{i}\t");
            }
            Console.ReadKey();
        }
    }
}