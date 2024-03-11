﻿using System;

namespace Homework04
{
    internal class Program
    {
        static void Main(string[] args) // вход
        {
            int[] array = { 2, 4, 5, 6, 7, 8, 9, 10, 12, 15, 17 }; // массив
            int target = 25; // задание целевого числа

            HW.FindSum(array, target); // вызов метода FindSum из класса HW для поиска  3 чисел равным target



        }
    }
}