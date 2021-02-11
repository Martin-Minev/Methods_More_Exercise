using System;
using System.Text;

namespace Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string textData = Console.ReadLine();
            int intCount = 0;
            double doubleCount = 0.00;
            string stringCount = string.Empty;
            if (textData == "int")
            {
                intCount = int.Parse(Console.ReadLine());
                Console.WriteLine(intCount * 2);
            }
            else if (textData == "real")
            {
                doubleCount = double.Parse(Console.ReadLine());
                Console.WriteLine($"{(doubleCount * 1.5):F2}");
            }
            else if (textData == "string")
            {
                stringCount = Console.ReadLine();
                PrintString(stringCount);
            }
        }

        static void PrintString(string stringCount)
        {
            string result = "$" + stringCount + "$";
            Console.WriteLine(result);
        }
    }
}
