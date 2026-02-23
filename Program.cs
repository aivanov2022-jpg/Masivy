using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        
        List<string> array = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            string[] cmdParts = command.Split(' ');

           
            if (cmdParts[0] == "Reverse")
            {
                array.Reverse();
            }
            
            else if (cmdParts[0] == "Distinct")
            {
                array = array.Distinct().ToList();
            }
           
            else if (cmdParts[0] == "Replace")
            {
                
               

                int index;
                bool isNumber = int.TryParse(cmdParts[1], out index);

                
                if (!isNumber || index < 0 || index >= array.Count)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                string newValue = cmdParts[2];
                array[index] = newValue;
            }
            
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }

        
        Console.WriteLine(string.Join(", ", array));
    }
}