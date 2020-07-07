
using System;

namespace HW_8_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog lab = new Dog("Murph", "Pizza");
            Horse horse = new Horse("Roach", true);
            Poodle poodle = new Poodle("Snowball", "Clams", "Five");
            Wolf wolf = new Wolf("Akela", "Raw meat", "Rama");
            PetWolf pup = new PetWolf("Maugli", "Tigers", "Rama");

            Animal[] choir = new Animal[5] { lab, horse, poodle, wolf,pup };
            AnimalSing(choir);

            Horse horse1 = new Horse("Limpy", true);
            Horse horse2 = new Horse("Rosie", false);
            Horse horse3 = new Horse("Thunder", true);
            Horse horse4 = new Horse("Lightning", false);

            Horse[] stable = new Horse[5] { horse, horse1, horse2, horse3, horse4 };

            foreach (Horse h in GetRacingHorses(stable))
            {
                Console.WriteLine(h);
            }
            
        }

        public static void AnimalSing(Animal[] arr)
        {
            foreach (Animal a in arr)
            {
                a.MakeSound();
            }
        }

        public static Horse[] GetRacingHorses(Horse[] arr)
        {
            int counter = 0;
            Horse[] newArr;

            //get ammount of racing horses to initialize newArr
            foreach (Horse h in arr)
            {
                if (h._racingHorse)
                {
                    counter++;
                }
            }

            newArr = new Horse[counter];
            counter = 0;

            //get racing horses to the newArr
            foreach (Horse h in arr)
            {
                if (h._racingHorse)
                {
                    newArr[counter] = h;
                    counter++;
                }
            }

            return newArr;
        }
    }
}
