using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAutomation
{
    public abstract class Animal
    {
        private int ID;
        private string category;
        private string species;
        private string name;
        private int age;
        private string color;
        private string healthStatus;

        public abstract void Nutrition();

        public abstract void Movement();

        public void addAnimal(int id, string category, string species, string name, int age, string color, string healthStatus)
        {
            this.ID = id;
            this.category = category;
            this.species = species;
            this.name = name;
            this.age = age;
            this.color = color;
            this.healthStatus = healthStatus;
 
        }

        public string GetCategory()
        {
            return category;
        }

        public string GetSpecies()
        {
            return species;
        }

        public string GetName()
        {
            return name;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetNewAge(int newAge)
        {
            age = newAge;
        }
        public string GetColor()
        {
            return color;
        }

        public string GetHealthStatus()
        {
            return healthStatus;
        }

        public void SetHealthStatus(string newHealthStatus)
        {
            healthStatus = newHealthStatus;
        }


        //public string SetName(string newName)
        //{
        //    if (!string.IsNullOrEmpty(newName))
        //    {
        //        this.name = newName;
        //        return "Name set successfully";
        //    }
        //    else
        //    {
        //        Console.WriteLine("You must specify a valid name.");
        //        return "Invalid name specified";
        //    }
        //}


    }
}
