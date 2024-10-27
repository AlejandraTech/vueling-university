using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamiliaConsole.Class
{
    internal class Grandfather
    {
        public string LastName { get; set; }
        protected string Job { get; set; }
        private int Age { get; set; }

        public Grandfather(string lastName, string job, int age)
        {
            LastName = lastName;
            Job = job;
            Age = age;
        }

        public int GetGrandfatherAge()
        {
            return Age;
        }

        public void SetGrandfatherAge(int age)
        {
            Age = age;
        }
    }
}

