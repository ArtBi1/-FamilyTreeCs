﻿using HW08;

namespace HW08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string directory = "C:\\GitGeekBrains\\GBFamily\\HW08";
            string extension = ".txt";
            string text = "цена";

            Console.WriteLine($"Ищем файлы в директории: {directory}");
            Console.WriteLine($"С расширением: {extension}, содержащие текст: {text}");

            FindFileAndText.SearchFileAndText(directory, extension, text);
        }
    }
}
