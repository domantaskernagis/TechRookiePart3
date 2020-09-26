using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace domantas.kernagis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<egg> eggs = new List<egg>() { new egg(false), new egg(false) }; //adding eggs to list
            building build = new building(50); //creating building class
            int percentageToNotBreak = 70;
            int highestFloor = findHighestFloor(eggs, build, percentageToNotBreak);
            Console.WriteLine("The highest floor an egg can survive -- {0}", highestFloor);
        }

        /// <summary>
        /// finds the highest floor an egg can surive
        /// </summary>
        /// <param name="eggs">all of the eggs</param>
        /// <param name="building">building class that has the buildings floor count</param>
        /// <param name="percentageToNotBreak">percentage to not break</param>
        /// <returns></returns>
        public static int findHighestFloor(List<egg> eggs, building building, int percentageToNotBreak)
        {
            Random random = new Random();
            int eggNumber = 1;
            int currentFloor = 1;
            int highestFloor = 0;
            while(currentFloor <= building.FloorNumber)
            {
                foreach (var egg in eggs)
                {
                    if (!egg.IsBroken)
                    {
                        Console.WriteLine(String.Format("egg number - {0} was droped from floor - {1}", eggNumber, currentFloor));
                        if (random.Next(100) < percentageToNotBreak)
                            Console.WriteLine(String.Format("egg number - {0} stayed intact", eggNumber));
                        else
                        {
                            Console.WriteLine(String.Format("egg number - {0} broke\n", eggNumber));
                            if (highestFloor < currentFloor - 1)
                                highestFloor = currentFloor - 1;
                            return highestFloor;
                        }
                    }
                    eggNumber++;
                    currentFloor++;
                }
                eggNumber = 1;
            }
            return building.FloorNumber;
        }
    }
}
