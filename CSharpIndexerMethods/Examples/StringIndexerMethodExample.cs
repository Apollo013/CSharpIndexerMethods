using CSharpIndexerMethods.Models;
using CSharpIndexerMethods.Utilities;
using System;

namespace CSharpIndexerMethods.Examples
{
    public class StringIndexerMethodExample
    {
        public static void Run()
        {
            PrintUtility.PrintTitle("STRING VALUE INDEXER METHOD EXAMPLE");

            PersonDictionaryCollection People = new PersonDictionaryCollection();

            People["Homer"] = new Person("Homer", "Simpson", 40);
            People["Marge"] = new Person("Marge", "Simpson", 38);

            // Get "Homer" and print data.
            Person homer = People["Homer"];

            Console.WriteLine(homer.ToString());
        }
    }
}
