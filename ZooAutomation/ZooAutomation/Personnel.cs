using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAutomation
{
    public abstract class Personnel
    {
        private int ID;
        private string position;
        private string name;
        private string surname;
        private int age;
        private int salary;
        protected int personnelNo;

        public abstract void Work();

        public abstract void GiveReport();

        public void addPersonnel(int id, string position, string name, string surname, int age, int salary, int PersonnelNo)
        {
            this.ID = id;
            this.position = position;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.salary = salary;
            this.personnelNo = PersonnelNo;
        }

        public string GetPosition()
        {
            return position;
        }

        public string GetName()
        {
            return name;
        }

        public string GetSurname()
        {
            return surname;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int newAge)
        {
            age = newAge;
        }

        public int GetSalary()
        {
            return salary;
        }

        public void SetSalary(int newSalary)
        {
            salary = newSalary;
        }
        public int GetPersonnelNo()
        {
            return personnelNo;
        }

    }
}
