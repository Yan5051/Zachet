using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    public class Program
    {
        public static bool EmptyFile(string path) //метод проверки на пустоту файла, также служит и в написании тестов
        {
            if (File.Exists(path))
            {
                StreamReader sr = File.OpenText(path);
                string[] file = sr.ReadToEnd().Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                sr.Close();

                if (file.Length == 0)
                {
                    return false;
                }
                else { return true; }
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {

            //Задание 1
            //if (EmptyFile("file1.txt"))
            //{
            //    StreamReader sr = File.OpenText("file1.txt");
            //    Stack<string> lines = new Stack<string>();
            //    while (!sr.EndOfStream)
            //    {
            //        lines.Push(sr.ReadLine());
            //    }

            //    for (int i = 0; i < lines.Count; i++)
            //    {
            //        string temp = lines.ElementAt(i);
            //        for (int j = 0; j < temp.Length; j++)
            //        {
            //            if (temp.Substring(j, 1).Equals("#"))
            //            {
            //                temp = temp.Remove(j - 1, 2);
            //                j = j - 2;
            //            }
            //        }
            //        Console.WriteLine(temp);
            //    }
            //    sr.Close();
            //}
            //else
            //{
            //    Console.WriteLine("Файл пуст! Или его не существует");
            //}

            //Задание 2
            Queue<int> pos = new Queue<int>(); //Коллекция очередь, для положительных и отрицательных чисел
            Queue<int>neg = new Queue<int>();

            if (EmptyFile("file2.txt"))
            {
                StreamReader sr = File.OpenText("file2.txt");
                string[] numbers = sr.ReadToEnd().Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries); //Читаем файл 1 раз и добавляем в массив все элементы из файла
                sr.Close();
                Console.WriteLine(string.Join(" ", numbers)); //Метод join служит чтобы напечатать все элементы массива без циклов
                try //Обработка исключения, если в файле есть буква
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        int number = Convert.ToInt32(numbers[i]);
                        if (number > 0)
                        {
                            pos.Enqueue(number); // добавление элемента в очередь
                        }
                        if (number < 0)
                        {
                            neg.Enqueue(number);
                        }
                    }
                    Console.WriteLine("Все положительные: " + string.Join(" ", pos));
                    Console.WriteLine("Все отрицательные: " + string.Join(" ", neg));
                }
                catch
                {
                    Console.WriteLine("Неверный ввод!");
                }
            }
            else
            {
                Console.WriteLine("Файл пуст или его не существует!");
            }
        }
    }
}
