using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAutomation
{
    public static class Zoo
    {
        public static int AnimalID = 0;
        public static int PersonnelID = 0;
        public static string name; 
        public static List<Animal> Animals = new List<Animal>();
        public static List<Personnel> Personnels = new List<Personnel>();

        public static void addNewAnimal(string category, string species, string name, int age, string color, string healthStatus)
        {
            Zoo.AnimalID++;
            if (category == "Mamallian")
            {
                Mamallian animal = new Mamallian();
                animal.addAnimal(Zoo.AnimalID, category, species, name, age, color, healthStatus);
                Animals.Add(animal);
            }
            else if (category == "Reptilian")
            {
                Reptilian animal = new Reptilian();
                animal.addAnimal(Zoo.AnimalID, category, species, name, age, color, healthStatus);
                Animals.Add(animal);
            }
            else
            {
                Bird animal = new Bird();
                animal.addAnimal(Zoo.AnimalID, category, species, name, age, color, healthStatus);
                Animals.Add(animal);
            }

        }

        public static void addNewPersonnel(string position, string name, string surname, int age, int salary, int PersonnelNo)
        {
            Zoo.PersonnelID++;
            if(position == "Manager")
            {
                Manager personnel = new Manager();    
                personnel.addPersonnel(Zoo.PersonnelID, position, name, surname, age, salary, PersonnelNo);
                Personnels.Add(personnel);
            }
            else if(position == "Veterinarian")
            {
                Veterinarian personnel = new Veterinarian();
                personnel.addPersonnel(Zoo.PersonnelID, position, name, surname, age, salary, PersonnelNo);
                Personnels.Add(personnel);
            }
            else
            {
                Zookeeper personnel = new Zookeeper();
                personnel.addPersonnel(Zoo.PersonnelID, position, name, surname, age, salary, PersonnelNo);
                Personnels.Add(personnel);
            }
        }



    }
}