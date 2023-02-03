using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Stringdesu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region #1 Удалить из строки символ с заданным номером. //String Builder
            //StringBuilder sb = new StringBuilder("Hello, world!");
            //Console.WriteLine("Initial string: " + sb.ToString());
            //Console.WriteLine("Enter number of symbol to delete: ");
            //int number_to_delete = Convert.ToInt32(Console.ReadLine());
            //sb.Remove(number_to_delete-1, 1);
            //Console.WriteLine("Result: " + sb.ToString());
            #endregion
            #region #2 Реализовать удаление из строки все вхождение в нее заданного символа. //String Builder
            //StringBuilder sb = new StringBuilder("Hello, cruel but beautiful world!");
            //Console.WriteLine("Initial string: " + sb.ToString());
            //Console.WriteLine("Enter symbol to delete: ");
            //char char_to_delete = Convert.ToChar(Console.Read());
            //String _to_delete = char_to_delete.ToString();
            //sb = sb.Replace(_to_delete, "");
            //Console.WriteLine("Result: " + sb.ToString());
            #endregion
            #region #3 Вставить в указанную позицию строки символ. //String Builder
            //StringBuilder sb = new StringBuilder("Hello, world!");
            //Console.WriteLine("Initial string: " + sb.ToString());
            //Console.WriteLine("Enter number of symbol to insert: ");
            //int number_to_insert = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter char to insert: ");
            //char char_to_insert = Convert.ToChar(Console.Read());
            //sb.Insert(number_to_insert-1,char_to_insert);
            //Console.WriteLine("Result: " + sb.ToString());
            #endregion
            #region #4 Проверить является ли строка палиндромом.
            //Console.WriteLine("Enter your string:");
            //String str = Console.ReadLine();
            //str = str.ToLower();
            //bool isPalindrom = true;
            //for (int i = 0; i < str.Length/2; i++)
            //{
            //    if (str[i] != str[str.Length - 1 - i])
            //    {
            //        isPalindrom = false;
            //        break;
            //    }
            //}
            //if (isPalindrom)
            //    Console.WriteLine("Palindrom");
            //else
            //    Console.WriteLine("Not a palindrom");
            #endregion
            #region #5 Подсчитать кол-во слов в предложении.
            //Console.WriteLine("Enter your string:");
            //String str = Console.ReadLine();
            //char[] arr = str.ToCharArray();
            //int words = 1;
            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    if (arr[i] == ' ' && arr[i + 1] != ' ')
            //    {
            //        words++;
            //    }
            //}
            //Console.WriteLine("There are " + words + " words!");
            #endregion
            #region #6 Пользователь вводит текст, строку для поиска и строку для замены. Реализовать поиск в тексте заданной строки и замены ее на заданную подстроку
            //Console.WriteLine("Enter your string:");
            //StringBuilder sb = new StringBuilder(Console.ReadLine());
            //String sb_string = sb.ToString();
            //Console.WriteLine("Enter sub-string to search:");
            //String substring_to_search = Console.ReadLine();
            //Console.WriteLine("Enter string to replace:");
            //String substring_to_replace = Console.ReadLine();

            //int index = sb_string.IndexOf(substring_to_search);

            //sb.Remove(index, substring_to_search.Length);
            //sb.Insert(index, substring_to_replace);

            //Console.WriteLine(sb);
            #endregion
            #region #7 Поменять места соседние слова в строке.
            //Console.WriteLine("Enter your string:");
            //String sb = Console.ReadLine();
            //Console.WriteLine("Initial string:\n" + sb);
            //Console.WriteLine();
            //String result = Regex.Replace(sb, @"(\w+)(\W+)(\w+)", "$3$2$1");
            //Console.WriteLine("Result string:");
            //Console.WriteLine(result);
            //Console.WriteLine();
            #endregion
            #region #8 Пользователь вводит русский текст. Подсчитать кол-во слов, которые заканчиваются на гласную букву. //Кодировка русская не работает =(, сделал на английском.
            //char[] wovels_array = { 'A', 'a', 'E', 'e', 'I', 'i', 'O', 'o', 'Y', 'y', 'U','u','\0'};
            //Console.WriteLine("Enter your string:");
            //String str = Console.ReadLine();
            //String[] words_array = str.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //int count = 0;
            //for (int i = 0; i < words_array.Length; i++)
            //{
            //    for (int j = 0; j < wovels_array.Length; j++)
            //    {
            //        if (words_array[i][words_array[i].Length-1] == wovels_array[j])
            //        {
                        
            //            count++;
            //        }
            //    }
            //}
            //Console.WriteLine("The are " + count + " words in string '" + str + "' that ends on a wovel letter.");
            #endregion

        }
    }
}
