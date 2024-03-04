﻿
namespace HW03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] labirynth = new int[,] // Инициализирование самого лабиринта
            {
                {1, 1, 1, 1, 1, 1, 1 },
                {1, 0, 0, 2, 0, 0, 1 },
                {1, 0, 1, 1, 1, 0, 1 },
                {0, 0, 0, 0, 1, 0, 2 },
                {1, 1, 0, 2, 1, 1, 1 },
                {1, 1, 1, 1, 1, 1, 1 },
                {1, 1, 1, 1, 1, 1, 1 }
            };
            
            Console.WriteLine($"Количество выходов = {Labirinth.HasExit(1, 1, labirynth)}"); // Выводим колва выходов
        }
    }
}
