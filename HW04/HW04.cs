using System;


namespace Homework04
{
    internal class HW
    {
        public static void FindSum(int[] arr, int target) // Метод для поиска трех чисел в массиве
        {
            for (int i = 0; i < arr.Length; i++) // Перебор всех комбинаций трёх чисел
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    for (int k = j + 1; k < arr.Length; k++)
                    {


                        if (arr[i] + arr[j] + arr[k] == target) // Если сумма трех чисел равна целевому числу, выводим на экран
                        {
                            Console.WriteLine();
                            Console.WriteLine($"{arr[i]}+{arr[j]}+{arr[k]}={target}");
                        }
                    }
                }
            }
        }

    }
   
 }