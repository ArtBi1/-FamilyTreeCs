using System;

namespace HW07
{
    // Реализация атрибута для помечания свойств, не подлежащих сохранению.
    [AttributeUsage(AttributeTargets.Property)] // Применение только к свойствам
    public class DontSaveAttribute : Attribute // объявление DontSaveAttribute производного от Attribute
    {
        // Пустой конструктор класса DontSaveAttribute
        public DontSaveAttribute() { }
    }
}
