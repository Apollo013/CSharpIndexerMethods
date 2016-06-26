using CSharpIndexerMethods.Models;
using CSharpIndexerMethods.Utilities;
using System;

namespace CSharpIndexerMethods.Examples
{
    public class NumericIndexerMethodExample
    {
        public static void Run()
        {
            // Demonstrates how to use indexer methods using an numeric index value. 
            // See Also: PersonCollection class under 'Models' folder. Here you will notice the 'this' keyword used to facilitate this functionality.

            PrintUtility.PrintTitle("NUMERIC VALUE INDEXER METHOD EXAMPLE");

            PersonCollection myPeople = new PersonCollection();
            // Add objects with indexer syntax.
            myPeople[0] = new Person("Homer", "Simpson", 40);
            myPeople[1] = new Person("Marge", "Simpson", 38);
            myPeople[2] = new Person("Lisa", "Simpson", 9);
            myPeople[3] = new Person("Bart", "Simpson", 7);
            myPeople[4] = new Person("Maggie", "Simpson", 2);

            // Now obtain and display each item using indexer.
            for (int i = 0; i < myPeople.Count; i++)
            {
                Console.WriteLine($"Person number: {i}");
                Console.WriteLine($"Name: {myPeople[i].FirstName} {myPeople[i].LastName}");
                Console.WriteLine($"Age: {myPeople[i].Age}");
                Console.WriteLine();
            }
        }

    }
}
