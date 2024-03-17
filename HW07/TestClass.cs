using System;

namespace HW07
{
    internal class TestClass
    {
        [DontSave] // Указ не должно сохраняться
        public int I { get; set; } // инт

        public char[]? C { get; set; } // массив символов

        public string? S { get; set; } // строка

        public decimal D { get; set; } // десятичная

        public TestClass(int i) // Приём одного аргумента i и устанавливает свойство I
        {
            I = i;
        }

        public TestClass() // Пустой
        {
        }

        // Конструктор класса TestClass, принимающий четыре аргумента и инициализирующий свойства I, C, S, D
        public TestClass(int i, char[]? c, string? s, decimal d) : this(i)
        {
            C = c;
            S = s;
            D = d;
        }
    }
}
