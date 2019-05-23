using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LABA_11
{
    class Collections
    {
        public static SortedList animals = new SortedList();

        static int animalNumber = 1;
        static int mammalNumber = 1;
        static int artyodactylNumber = 1;
        static int birdNumber = 1;

        public static void AddToList(string name, int weight)
        {
            animals.Add($"Животное {animalNumber}", new KingdomAnimal
                (weight, name));
            animalNumber++;
        }
        public static void AddToList(string name, int weight, int incubationPeriod, int lifeExpectancy)
        {
            animals.Add($"Млекопитающее {mammalNumber}", new ClassMammals
                (incubationPeriod, lifeExpectancy, weight, name));
            mammalNumber++;
        }
        public static void AddToList(string name, int weight, int incubationPeriod, int lifeExpectancy, bool hasHorns, string habitat)
        {
            animals.Add($"Парнокопытное {artyodactylNumber}", new OrderArtiodactyl
                (hasHorns, habitat, incubationPeriod, lifeExpectancy, weight, name));
            artyodactylNumber++;
        }
        public static void AddToList(string name, int weight, bool flying, bool domestic)
        {
            animals.Add($"Птица {birdNumber}", new ClassBirds
                (flying, domestic, weight, name));
            birdNumber++;
            
        }
        public static void DeleteByKey(string key)
        {
            if (animals.ContainsKey(key))
            {
                animals.Remove(key);
            }
            else
            {
                SupportingMethods.ShowMistake(content:"Элемента с таким ключом нет");
            }
        }
        public static object FindByKey(string key)
        {
            if (animals.ContainsKey(key))
            {
                return animals[key];
            }
            else
            {
                SupportingMethods.ShowMistake(content: "Элемента с таким ключом нет");
                return null;
            }
        }
        public static int GetAnimalNumber()
        {
            return animalNumber;
        }
        public static int GetBirdNumber()
        {
            return birdNumber;
        }
        public static int GetMammalNumber()
        {
            return mammalNumber;
        }
        public static int GetArtiodactylNumber()
        {
            return artyodactylNumber;
        }
        public static void PrintThisType(string type)
        {
            PrintThisType print = new PrintThisType();
            foreach (object animal in animals)
            {
                switch (type)
                {
                    case "Животное":
                        if (animal is KingdomAnimal)
                        {
                            print.Output(animal as KingdomAnimal);
                        }
                        break;
                    case "Млекопитающее":
                        if (animal is ClassMammals) 
                        {
                            print.Output(animal as ClassMammals);
                        }
                        break;
                    case "Птица":
                        if (animal is ClassBirds)
                        {
                            print.Output(animal as ClassBirds);
                        }
                        break;
                    case "Парнокопытное":
                        if (animal is OrderArtiodactyl)
                        {
                            print.Output(animal as OrderArtiodactyl);
                        }
                        break;
                }
            }
            
        }
    }
}
