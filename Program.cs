using System;
using System.Collections.Generic;


namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World from Jacob!");

            Dictionary<String, int> family = new Dictionary<string, int>();

            family.Add("jacob", 25);
            family.Add("raelynn", 2);
            family.Add("ayawna", 28);
            family.Add("samantha", 44);
            family.Add("stephen", 44);
            family.Add("loyle", 18);
            family.Add("emma", 21);
            family.Add("grace", 19);

            // only pull samanthas value
            // System.Console.WriteLine(family["samantha"]);

            Console.WriteLine("This is my family:");
            
            //iterate throughj each person in family
            foreach (var person in family)
            {   
                System.Console.WriteLine(person);

                // only pull values
                // System.Console.WriteLine(person.Value);
            }


        }
    }
}
