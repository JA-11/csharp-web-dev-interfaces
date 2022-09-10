using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;

            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
            //  field.

            foreach (Flavor flavor in availableFlavors)  //iterating through availableFlavors name list BEFORE sorting
            {
                Console.WriteLine(flavor.Name);
            }

            FlavorComparer flavorComparer = new FlavorComparer();
            availableFlavors.Sort(flavorComparer);


        // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
        //  field.

            foreach(Cone cone in availableCones)  //iterating through availableCones cost list BEFORE sorting
            {
                Console.WriteLine($"{cone.Name}: ${cone.Cost}");
            }

            ConeComparer coneComparer = new ConeComparer();
            availableCones.Sort(coneComparer);


        // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.

            //print the sorted flavors:
            foreach(Flavor flavor in availableFlavors)  //iterating through availableFlavors name list AFTER sorting
            {
                Console.WriteLine(flavor.Name);
            }

            //print the sorted cones:
            foreach (Cone cone in availableCones)  //iterating through availableCones cost list AFTER sorting
            {
                Console.WriteLine($"{cone.Name}: ${cone.Cost}");
            }


        }
    }
}
