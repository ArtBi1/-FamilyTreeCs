using System;

namespace HW07
{
    [AttributeUsage(AttributeTargets.Property)] // Указание - атрибут может применяться только к свойствам
    public class CustomNameAttribute : Attribute
    {
        public string Prop; // строка для хранения альтернативного имени

        public CustomNameAttribute(string name) => Prop = name; // Конструктор, принимает строку name и устанавливает свойство Prop

    }
}
