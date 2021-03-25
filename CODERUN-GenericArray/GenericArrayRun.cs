using System;
using Conductus.CODERUN.Framework;
using GENERICARRAY;

namespace Conductus.CODERUN.GENERICARRAY
{
    public class GenericArrayCodeRun : ICodeRunModule
    {
        public string Title
        {
            get { return "Generic Array"; }
        }
        public void Run()
        {
            //declaring an int array
            var intArray = new GenericArray<int>(5);

            //setting values
            for (int c = 0; c < 5; c++)
            {
                intArray.setItem(c, c * 5);
            }

            //retrieving the values
            for (int c = 0; c < 5; c++)
            {
                Console.Write(intArray.getItem(c) + " ");
            }

            Console.WriteLine();

            //declaring a character array
            GenericArray<char> charArray = new GenericArray<char>(5);

            //setting values
            for (int c = 0; c < 5; c++)
            {
                charArray.setItem(c, (char)(c + 97));
            }

            //retrieving the values
            for (int c = 0; c < 5; c++)
            {
                Console.Write(charArray.getItem(c) + " ");
            }
        }
    }
}
