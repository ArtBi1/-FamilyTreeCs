﻿using Seminar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar.Service
{
    internal class FamilyMemberService
    {
        private List<FamilyMember> Family {  get; set; }

        public FamilyMemberService()
        { 
            Family = new List<FamilyMember>();
        }

        public void AddMember(params FamilyMember[] member)
        {
            if (member != null && member.Length>0)
            {
                Family.AddRange(member);
            }

        }

        public List<FamilyMember>GetGrandFathers(FamilyMember member) // метод поиска дедушек
        {
            List<FamilyMember> grandFathers = new List<FamilyMember>();
            grandFathers.Add(member.Father.Father);
            grandFathers.Add(member.Mother.Father);
            return grandFathers;
        }
        public List<FamilyMember> GetGrandMothers(FamilyMember member)// метод поиска бабушек
        {
            List<FamilyMember> grandMothers = new List<FamilyMember>();
            grandMothers.Add(member.Father.Mother);
            grandMothers.Add(member.Mother.Mother);
            return grandMothers;
        }
        public FamilyMember FindOldestMember()
        {
            var data = Family.Min((x)=>x.Birthday);
            return Family.FirstOrDefault((x) => x.Birthday==data);
        }

        public FamilyMember FindCouple(FamilyMember member)=>member.Spouse; // поиск и вывод жены или мужа


    }
}