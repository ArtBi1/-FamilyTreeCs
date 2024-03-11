using System.Text;

namespace HW05
{
    internal class Logger
    {

        private Stack<(int, string)> log = new Stack<(int, string)>(); // Стек хранения логов(число, операция)

        public void AddLog(int number, string operation) // Метод для добавления лога в стек
        {
            log.Push(new(number, operation));
        }

        public string GetLog() // Метод для получения лога в виде строки
        {
            StringBuilder sb = new StringBuilder(); // StringBuilder для построения строки
            sb.Append(" StackTrace: "); // Добавляем начало строки с информацией о стеке
            foreach (var logEntry in log) // Проходим по всем записям в стеке и добавляем их в строку
            {
                sb.Append(logEntry.ToString());
            }
            return sb.ToString(); // Возвращаем готовую строку
        }
    }
}
