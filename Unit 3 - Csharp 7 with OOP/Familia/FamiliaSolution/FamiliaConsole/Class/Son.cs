using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamiliaConsole.Class
{
    internal class Son : Father
    {
        public string Nickname { get; set; }
        protected string FavoriteSport { get; set; }
        private int Age { get; set; }

        public Son(string firstName, string lastName, string job, string hobby, string nickname, string favoriteSport, int grandfatherAge, int fatherAge, int age)
            : base(firstName, lastName, job, hobby, grandfatherAge, fatherAge)
        {
            Nickname = nickname;
            FavoriteSport = favoriteSport;
            Age = age;
        }

        public new int GetAge()
        {
            return Age;
        }

        public void SetSonAge(int age, int fatherAge)
        {
            Age = age;
        }

        public void DisplayValues()
        {
            Console.WriteLine($"Grandfather's Last Name: {LastName}, Job: {Job}, Age: {GetGrandfatherAge()}");
            Console.WriteLine($"Father's First Name: {FirstName}, Hobby: {Hobby}, Age: {GetFatherAge()}");
            Console.WriteLine($"Son's Nickname: {Nickname}, Favorite Sport: {FavoriteSport}, Age: {GetAge()}");
        }

        public void ModifyValues(string newLastName, string newJob, string newFirstName, string newHobby, string newNickname, string newFavoriteSport, int newGrandfatherAge, int newFatherAge, int newSonAge)
        {
            LastName = newLastName;
            Job = newJob;
            FirstName = newFirstName;
            Hobby = newHobby;
            Nickname = newNickname;
            FavoriteSport = newFavoriteSport;

            SetGrandfatherAge(newGrandfatherAge);
            SetFatherAge(newFatherAge, newGrandfatherAge);
            SetSonAge(newSonAge, newFatherAge);

            DisplayValues();
        }
    }
}
