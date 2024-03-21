using System;
using System.IO;
using System.Linq;

namespace HW08
{
    public class FindFileAndText
    {
        public static void SearchFileAndText(string directory, string extension, string text)
        {
            // Проверка на null для всех параметров
            if (directory == null || extension == null || text == null)
            {
                throw new ArgumentNullException("Все параметры должны быть не null.");
            }

            try
            {
                // Поиск файлов с указанным расширением в указанной директории и её поддиректориях
                string[] files = Directory.GetFiles(directory, "*" + extension, SearchOption.AllDirectories);

                foreach (string file in files)
                {
                    // Чтение файла построчно StreamReader
                    using (StreamReader reader = new StreamReader(file))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            // Проверка, содержится ли указанный текст в текущей строке файла
                            if (line.Contains(text))
                            {
                                // Вывод пути к файлу с содержащимся текстом
                                Console.WriteLine(file);
                                break; // Выход из цикла чтения файла, если текст найден
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Вывод сообщения об ошибке при возникновении исключения
                Console.WriteLine($"Ошибка при поиске файлов: {ex.Message}");
            }
        }
    }
}
