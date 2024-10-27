using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTrabajadoresConsole.Class
{
    internal class Worker
    {
        private static int idCounter = 1;

        public int Id { get; private set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime LeavingDate { get; set; }

        public Worker()
        {
            Id = idCounter++;
        }

        public int GetAge()
        {
            int age = DateTime.Now.Year - BirthDate.Year;
            if (DateTime.Now < BirthDate.AddYears(age)) age--;
            return age;
        }
    }
}
