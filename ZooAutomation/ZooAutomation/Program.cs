using System;
using System.Xml.Linq;

namespace ZooAutomation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Welcome TVA ZOO!");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
            //string category, string species, string name, int age, string color, string healthStatus
            Zoo.addNewAnimal("Mamallian", "Monkey", "Coco",  4, "Brown", "Healthy");
            Zoo.addNewAnimal("Reptilian", "Snake", "Tssss", 2, "Green", "Healthy");
            Zoo.addNewAnimal("Bird", "Eagle", "GakGak", 1,  "Dark", "Sick");

            foreach(var animal in Zoo.Animals)
            {
                Console.WriteLine($"In TVA ZOO, we have {animal.GetCategory()} animal named {animal.GetName()}.");
                Console.WriteLine($"It is a {animal.GetSpecies()} with age {animal.GetAge()}, color {animal.GetColor()}, and health status {animal.GetHealthStatus()}.");
                Console.WriteLine($"Do you want to update the health status or age of {animal.GetName()} ? (yes/no)");
                string updateAnswer = Console.ReadLine().ToLower();

                if (updateAnswer == "yes")
                {
                    Console.WriteLine("Enter the current health status:");
                    string newHealthStatus = Console.ReadLine();
                    animal.SetHealthStatus(newHealthStatus);
                    Console.Write("Enter the current age: ");
                    int newAge = int.Parse(Console.ReadLine());
                    animal.SetNewAge(newAge);
                    Console.WriteLine("Informations updated successfully!");
                    Console.WriteLine($"Updated Information: In TVA ZOO, we have {animal.GetCategory()} animal named {animal.GetName()}.");
                    Console.WriteLine($"It is a {animal.GetSpecies()} with age {animal.GetAge()}, color {animal.GetColor()}, and health status {animal.GetHealthStatus()}.");

                }

                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
            
        }

            Console.WriteLine("----------------------------------------NUTRITION OF ANIMAL----------------------------------------------------");
            
            foreach(var animal in Zoo.Animals)
            {
                animal.Nutrition();
            }

            Console.WriteLine("----------------------------------------MOVEMENT OF ANIMAL-----------------------------------------------------");

            foreach (var animal in Zoo.Animals)
            {
                animal.Movement();
            }

            Console.WriteLine("----------------------------------------PERSONNELS INFORMATIONS------------------------------------------------");

            //position, name, surname, age, salary, PersonnelNo
            Zoo.addNewPersonnel("Manager", "Joe", "Kurzawski", 47, 3000, 8780);
            Zoo.addNewPersonnel("Veterinarian", "Michael", "Dabdowa", 32, 2000, 8783);
            Zoo.addNewPersonnel("Zookeeper", "Hans", "Garryow", 27, 1400 , 8796);

            foreach(var personnel in Zoo.Personnels)
            {
                Console.WriteLine("Welcome to TVA ZOO! Information of personnels: ");
                Console.WriteLine($"Position: {personnel.GetPosition()}");
                Console.WriteLine($"Name: {personnel.GetName()}");
                Console.WriteLine($"Surname: {personnel.GetSurname()}");
                Console.WriteLine($"Age: {personnel.GetAge()}");
                Console.WriteLine($"Salary: {personnel.GetSalary()}");

                string personnelNo = personnel.GetPersonnelNo().ToString();
                string maskedPersonnelNo = new string('*', personnelNo.Length - 2) + personnelNo.Substring(personnelNo.Length - 2);

                Console.WriteLine($"Personnel No: {maskedPersonnelNo}");

                Console.WriteLine($"Do you want to update the salary or age of {personnel.GetName()} {personnel.GetSurname()}? (yes/no)");
                string updateAnswer = Console.ReadLine().ToLower();

                if (updateAnswer == "yes")
                {
                    Console.WriteLine("Enter the updated salary:");
                    int newSalary = int.Parse(Console.ReadLine());
                    personnel.SetSalary(newSalary);
                    Console.WriteLine("Enter the current age:");
                    int newAge = int.Parse(Console.ReadLine());
                    personnel.SetAge(newAge);
                    personnel.SetAge(newAge);
                    Console.WriteLine("Informations updated successfully!");
                    Console.WriteLine($"Updated Information: ");


                }
                Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
            }

            Console.WriteLine("----------------------------------------WORK OF PERSONNELS----------------------------------------------------");

            foreach (var personnel in Zoo.Personnels)
            {
                personnel.Work();
            }

            Console.WriteLine("----------------------------------------REPORTS OF PERSONNELS--------------------------------------------------");

            foreach (var personnel in Zoo.Personnels)
            {
                personnel.GiveReport();
            }

            while (true)
            {
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Do you want to add an animal? (yes/no)");
                string answer = Console.ReadLine().ToLower();

                if (answer == "no")
                    break;

                Console.WriteLine("Enter animal details:");
                Console.Write("Category: ");
                string category = Console.ReadLine();
                Console.Write("Species: ");
                string species = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Color: ");
                string color = Console.ReadLine();
                Console.Write("Health Status: ");
                string healthStatus = Console.ReadLine();

                Zoo.addNewAnimal(category, species, name, age, color, healthStatus);

                Console.WriteLine("Do you want to see the details of all animals, including the newly added ones? (yes/no)");
                string detailsAnswer = Console.ReadLine().ToLower();
                if (detailsAnswer == "yes")
                {
                    Console.WriteLine("----------------------------------------ANIMAL INFORMATIONS------------------------------------------------");

                    foreach (var animal in Zoo.Animals)
                    {
                        Console.WriteLine($"Animal Information: In TVA ZOO, we have {animal.GetCategory()} animal named {animal.GetName()}.");
                        Console.WriteLine($"It is a {animal.GetSpecies()} with age {animal.GetAge()}, color {animal.GetColor()}, and health status {animal.GetHealthStatus()}.");
                        Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                    }
                }
            }
            
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------");

            while (true)
            {
                Console.WriteLine("Do you want to add an personnel? (yes/no)");
                string answer = Console.ReadLine().ToLower();

                if (answer == "no")
                    break;

                Console.WriteLine("Enter personnel details:");
                Console.Write("Position: ");
                string position = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Surname: ");
                string surname = Console.ReadLine();
                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Salary(Euro): ");
                int salary = int.Parse(Console.ReadLine());
                Console.Write("Personnel No: ");
                int PersonnelNo = int.Parse(Console.ReadLine());

                Zoo.addNewPersonnel(position, name, surname, age, salary, PersonnelNo);

                Console.WriteLine("Do you want to see the details of all personnel, including the newly added ones? (yes/no)");
                string detailsAnswer = Console.ReadLine().ToLower();
                if (detailsAnswer == "yes")
                {
                    Console.WriteLine("----------------------------------------PERSONNEL INFORMATIONS------------------------------------------------");

                    foreach (var personnel in Zoo.Personnels)
                    {
                        Console.WriteLine("Welcome to TVA ZOO! Information of personnels: ");
                        Console.WriteLine($"Position: {personnel.GetPosition()}");
                        Console.WriteLine($"Name: {personnel.GetName()}");
                        Console.WriteLine($"Surname: {personnel.GetSurname()}");
                        Console.WriteLine($"Age: {personnel.GetAge()}");
                        Console.WriteLine($"Salary(Euro): {personnel.GetSalary()}");

                        string personnelNo = personnel.GetPersonnelNo().ToString();
                        string maskedPersonnelNo = new string('*', personnelNo.Length - 2) + personnelNo.Substring(personnelNo.Length - 2);

                        Console.WriteLine($"Masked Personnel No: {maskedPersonnelNo}");
                        Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                    }
                }
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"Current Animal Number: {Zoo.AnimalID}");
            Console.WriteLine($"Current Personnel Number: {Zoo.PersonnelID}");
        }
    }
}
