using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Нужно определить сколько всего выходов имеется в лабиринте:
// int[,] labirynth1 = new int[,]
// {
// {1, 1, 1, 1, 1, 1, 1 },
// {1, 0, 0, 0, 0, 0, 1 },
// {1, 0, 1, 1, 1, 0, 1 },
// {0, 0, 0, 0, 1, 0, 0 },
// {1, 1, 0, 0, 1, 1, 1 },
// {1, 1, 1, 0, 1, 1, 1 },
// {1, 1, 1, 0, 1, 1, 1 }
// };

// Сигнатура метода:

// static int HasExit(int startI, int startJ, int[,] l)


namespace HW03
{
    internal class Labirinth
    {
        public static int HasExit(int startI, int startJ, int[,] labyrinth) // Метод определения количества выходов из лабиринта
        {
            Queue<(int, int)> coords = new (); // Очередь для хранения координат
            int count = 0; // Переменная для хранения количества выходов
            if (labyrinth[startI, startJ] != 1) // Начальная позиция не стена? Тогда в очередь её
            {
                coords.Enqueue((startI, startJ));
            }
            while (coords.Count > 0) // Пока очередь есть
            {
                

                (int i, int j) = coords.Dequeue(); // Извлечение координаты
                if (labyrinth[i, j] == 2) // Если позиция сейчас - выход, то увеличиваем счетчик
                    count++;
                    

                labyrinth[i, j] = 1; // Пометка позиции как уже посещенной
                // Проверка соседней клетки на доступность и добавление их в очередь, если они - не стена.
                if (i - 1 >= 0 && labyrinth[i - 1, j] != 1) coords.Enqueue((i - 1, j));
                if (i + 1 < labyrinth.GetLength(0) && labyrinth[i + 1, j] != 1) coords.Enqueue((i + 1, j));
                if (j - 1 >= 0 && labyrinth[i, j - 1] != 1) coords.Enqueue((i, j - 1));
                if (j + 1 < labyrinth.GetLength(1) && labyrinth[i, j + 1] != 1) coords.Enqueue((i, j + 1));
            }
            return count; // Возврат  колвавыходов из лабиринта
        }
    }
}