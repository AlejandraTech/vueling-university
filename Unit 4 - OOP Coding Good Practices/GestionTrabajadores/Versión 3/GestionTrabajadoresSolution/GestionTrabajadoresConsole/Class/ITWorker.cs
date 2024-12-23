using GestionTrabajadoresConsole.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GestionTrabajadoresConsole.Class
{
    internal class ITWorker : Worker
    {
        public int YearsOfExperience { get; set; }
        public List<string> TechKnowledges { get; set; }
        private EnumLevelITWorker Level { get; set; }

        public ITWorker(string name, string surname, DateTime birthDate, DateTime leavingDate, int yearsOfExperience, List<string> techKnowledges, EnumLevelITWorker level)
        {
            if (GetAge() < 18)
            {
                throw new Exception("The minimum age to work is 18 years old.");
            }

            Name = name;
            Surname = surname;
            BirthDate = birthDate;
            YearsOfExperience = yearsOfExperience;
            TechKnowledges = techKnowledges;
            Level = yearsOfExperience >= 5 ? EnumLevelITWorker.Senior : (yearsOfExperience >= 2 ? EnumLevelITWorker.Medium : EnumLevelITWorker.Junior);
        }

        public bool CanBeManager()
        {
            return Level == EnumLevelITWorker.Senior;
        }
    }
}
