﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW05
{
    internal interface ICalculator
    {
        void Sum(double x); // Метод сложения
        void Subtract(double x); // Метод вычитания
        void Divide(double x); // Метод деления
        void Multiply(double x); // Умножение
        void CancelLast(); // Отмена действия
        public event EventHandler<OperandChangedEventArgs> GetResult; // Получение результата операции
    }
}