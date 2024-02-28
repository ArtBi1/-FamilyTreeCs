﻿using Seminar.Model;
using Seminar.Service;
using System;

namespace Seminar
{
    internal class Program
    {
        private static FamilyMember familyMember;

        static void Main(string[] args)
        {
            // Создание членов семьи
            FamilyMember fm7 = new FamilyMember()
            { Name = "Олег", Surname = "Петров", Birthday = new DateTime(1900, 10, 12), Gender = Gender.Male };
            FamilyMember fm8 = new FamilyMember()
            { Name = "Кристина", Surname = "Петрова", Birthday = new DateTime(1900, 10, 12), Gender = Gender.Female };
            fm7.Spouse = fm8;
            fm8.Spouse = fm7;

            FamilyMember fm5 = new FamilyMember()
            { Name = "Александр", Surname = "Иванов", Birthday = new DateTime(1955, 08, 09), Gender = Gender.Male };
            FamilyMember fm6 = new FamilyMember()
            { Name = "Юлия", Surname = "Иванов", Birthday = new DateTime(1955, 08, 09), Gender = Gender.Female };
            fm5.Spouse = fm6;
            fm6.Spouse = fm5;

            FamilyMember fm1 = new FamilyMember()
            { Name = "Иван", Surname = "Иванов", Birthday = new DateTime(1990, 01, 15), Gender = Gender.Male, Mother = fm6, Father = fm5 };
            FamilyMember fm2 = new FamilyMember()
            { Name = "Мария", Surname = "Иванова", Birthday = new DateTime(1990, 01, 15), Gender = Gender.Female, Mother = fm8, Father = fm7 };
            fm2.Spouse = fm1;

            FamilyMember fm3 = new FamilyMember()
            { Name = "Ольга", Surname = "Иванова", Birthday = new DateTime(2020, 04, 12), Gender = Gender.Female, Mother = fm2, Father = fm1 };
            FamilyMember fm4 = new FamilyMember()
            { Name = "Сергей", Surname = "Иванов", Birthday = new DateTime(2020, 04, 12), Gender = Gender.Male, Mother = fm2, Father = fm1 };

            // Создание сервиса и добавление членов семьи
            var service = new FamilyMemberService();
            service.AddMember(fm1, fm2, fm3, fm4, fm5, fm6, fm7, fm8);

            // Вывод информации о дедушках и бабушках
            Console.WriteLine("Дедушки:");
            foreach (var member in service.GetGrandFathers(fm3))
            {
                Console.WriteLine($"- {member.Name} {member.Surname}");
            }

            Console.WriteLine("\nБабушки:");
            foreach (var member in service.GetGrandMothers(fm4))
            {
                Console.WriteLine($"- {member.Name} {member.Surname}");
            }

            // Вывод информации о самом старшем члене семьи
            var oldestMember = service.FindOldestMember();
            Console.WriteLine($"\nСамый старший член семьи: {oldestMember.Name} {oldestMember.Surname}");

            // Вывод информации о супруге для заданного члена семьи
            var chosenMember = fm8;
            var couple = service.FindCouple(chosenMember);
            if (couple != null)
            {
                Console.WriteLine($"\nСупруг для {chosenMember.Name} {chosenMember.Surname}: {couple.Name} {couple.Surname}");
            }
            else
            {
                Console.WriteLine($"\n{chosenMember.Name} {chosenMember.Surname} не имеет супруга(и)");
            }
        }
    }
}
