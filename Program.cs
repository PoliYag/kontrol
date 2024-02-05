using System;

namespace ShortStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод начального массива с клавиатуры
            Console.WriteLine("Введите элементы массива через запятую:");
            string input = Console.ReadLine();
            string[] array = input.Split(',');

            // Формирование нового массива
            string[] result = CreateShortStringArray(array);

            // Вывод результата
            Console.WriteLine("Новый массив из строк, длина которых меньше, либо равна 3 символам:");
            foreach (string str in result)
            {
                Console.Write(str + " ");
            }
        }

        static string[] CreateShortStringArray(string[] inputArray)
        {
            // Подсчет количества строк, удовлетворяющих условию
            int count = 0;
            foreach (string str in inputArray)
            {
                if (str.Length <= 3)
                {
                    count++;
                }
            }

            // Создание нового массива
            string[] result = new string[count];
            int index = 0;
            foreach (string str in inputArray)
            {
                if (str.Length <= 3)
                {
                    result[index] = str;
                    index++;
                }
            }

            return result;
        }
    }
}