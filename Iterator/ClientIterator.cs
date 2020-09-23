using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public static class ClientIterator
    {
        public static void ExecuteScript()
        {
            Console.WriteLine(new string('_', 100));
            Console.WriteLine("ITERATOR\n\n");

            IEnumerable<string> collection = new List<string>() { "Vasya", "Petya", "Sasha", "Vanya", "Inokentiy", "Pavel" };

            var skipPList = new SkipPList(collection);
            var skipVList = new SkipVList(collection);

            Console.WriteLine("Ignore P:");
            foreach(var item in skipPList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n");

            Console.WriteLine("Ignore V:");
            foreach (var item in skipVList)
            {
                Console.WriteLine(item);
            }

            ///////////////////////////////////////////
            Console.WriteLine("\nIgnore P via own realization while cycle:");
            IEnumerator enumerator = skipPList.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Write(enumerator.Current + " ");
            }

            Console.WriteLine("\n\nIgnore P via own realization for cycle:");
            enumerator = skipVList.GetEnumerator();
            for (int i = 0; enumerator.MoveNext(); i++)
            {
                Console.Write(enumerator.Current + " ");
            }

            Console.WriteLine("\n");

            /////////////////////////////////////////
            Console.WriteLine("Interrupt current enumeration and continue it again. Running two enumeration at the same time");
            IEnumerator firstEnumerator = collection.GetEnumerator();
            IEnumerator secondEnumerator = collection.GetEnumerator();

            int j;
            for(j = 0; j < 3; j++)
            {
                firstEnumerator.MoveNext();
                Console.WriteLine(firstEnumerator.Current);
            }

            while (secondEnumerator.MoveNext())
            {
                Console.Write(secondEnumerator.Current + " ");
            }
            Console.WriteLine();

            for(; firstEnumerator.MoveNext();)
                Console.WriteLine(firstEnumerator.Current);
        }
    }
}
