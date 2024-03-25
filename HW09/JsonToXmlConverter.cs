using System;
using System.IO;
using System.Text.Json;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        string jsonFilePath = "HW09json.json"; // Указываем директории
        string xmlFilePath = "HW09xml.xml";

        if (!File.Exists(jsonFilePath)) // Проверка существования этих файлов
        {
            Console.WriteLine($"Файл {jsonFilePath} не найден.");
            return;
        }

        string jsonString = File.ReadAllText(jsonFilePath);// Чтение json из файла

        string xmlString = ConvertJsonToXml(jsonString); // Конвертация джсон в хмл

        File.WriteAllText(xmlFilePath, xmlString); // Сохранение результата в файл хмл

        Console.WriteLine($"Результат успешно сохранен в файл {xmlFilePath}"); // Вывод сообщения о успешном завершении
    }

    static string ConvertJsonToXml(string jsonString) // Метод для конвертации джсон в хмл
    {
        using (JsonDocument document = JsonDocument.Parse(jsonString)) // Разборка json
        {
            XElement rootElement = new XElement("Root"); // корневой xml
            
            ConvertJsonToXml(document.RootElement, rootElement);// JSON -> XML с помощью рекурсивного метода
            
            return rootElement.ToString();// Возврат строкового
        }
    }

    static void ConvertJsonToXml(JsonElement jsonElement, XElement parentElement) //  JSON -> XML с помощью рекурсивного метода
    {
        switch (jsonElement.ValueKind)
        {
            case JsonValueKind.Object: // Обработка объектов json
                foreach (JsonProperty property in jsonElement.EnumerateObject())
                {
                    XElement element = new XElement(property.Name); // Элемент xml для каждого свойства
                    parentElement.Add(element); // Рекурсивый метод для обработки свойства
                    ConvertJsonToXml(property.Value, element);
                }
                break;

            case JsonValueKind.Array: // Обработка массивов джсон
                foreach (JsonElement arrayElement in jsonElement.EnumerateArray())
                {
                    XElement element = new XElement("Item"); // Создание элемена для каждого элемента массива
                    parentElement.Add(element);
                    ConvertJsonToXml(arrayElement, element); // Рекурсивный метод для обработки элемента массива
                }
                break;

            case JsonValueKind.String: // Обработка строковых значений
                parentElement.Value = jsonElement.GetString();
                break;

            case JsonValueKind.Number: // Обработка числовых значений
                parentElement.Value = jsonElement.GetRawText();
                break;

            case JsonValueKind.True: // Обработка логических значений (тру и фальш))
                parentElement.Value = "true";
                break;

            case JsonValueKind.False:
                parentElement.Value = "false";
                break;

            case JsonValueKind.Null: // Обработка пустых значений
                parentElement.Add(new XAttribute("IsNull", "true"));
                break;
        }
    }
}
