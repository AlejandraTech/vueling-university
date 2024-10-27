using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamiliaConsole.Class
{
    internal class Father : Grandfather
    {
        public string FirstName { get; set; }
        protected string Hobby { get; set; }
        private int Age { get; set; }

        public Father(string firstName, string lastName, string job, string hobby, int grandfatherAge, int age)
            : base(lastName, job, grandfatherAge)
        {
            FirstName = firstName;
            Hobby = hobby;
            Age = age;
        }

        public int GetFatherAge()
        {
            return Age;
        }

        public void SetFatherAge(int age, int grandfatherAge)
        {
            Age = age;
        }
    }
}
