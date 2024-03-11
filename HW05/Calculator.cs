﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HW05
{
    internal class Calculator : ICalculator
    {
        public event EventHandler<OperandChangedEventArgs> GetResult; // Делегат для события изменения операнда

        private Stack<double> stack = new Stack<double>(); // стек для хранения значеий

        private double Result // Для доступа к последнему значению в стеке
        { 
            get 
            {
                return stack.Count() == 0 ? 0 : stack.Peek(); // Возвращаем верхний элемент стека или 0, если стек пуст
            } 
            set 
            { 
                stack.Push(value); // Добавляем новое значение в стек и вызов изменения
                RaiseEvent(); 
            } 
        }

        public void RaiseEvent() // Генерация изменения
        {
            GetResult?.Invoke(this, new OperandChangedEventArgs(Result));
        }

        public void CancelLast() // Отмена последнего значения
        {
            if (stack.Count > 0)
            {
                stack.Pop();
                RaiseEvent();
            }
        }

        public void Divide(double number) // Деление текущего результата на переданное число
        {
            Result /= number;
        }

        public void Multiply(double number) // Умножение текущего результата на переданное число
        {
            Result *= number;
        }

        public void Subtract(double number) // Вычитание переданного числа из текущего результата
        {
            Result -= number;
        }

        public void Sum(double number) // Сложение переданного числа с текущим результатом
        {
            Result += number;
        }
    }
}