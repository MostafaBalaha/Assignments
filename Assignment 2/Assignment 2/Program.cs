using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int decimalHex = 0; double total=0;
            Console.WriteLine("Enter hexdecimel number");
            string hex = Console.ReadLine().ToUpper();
            char[] hexChars = new char[hex.Length];
            for(int i =0; i< hex.Length; i++)
            {   
                hexChars[i] = hex[i];
            }
            for (int i = 0; i < hexChars.Length; i++)
            {
                if(hexChars[i] == 'A')
                {
                    decimalHex = 10;

                }
                else if (hexChars[i] == 'B')
                {
                    decimalHex = 11;

                }
                else if (hexChars[i] == 'C')
                {
                    decimalHex = 12;

                }
                else if (hexChars[i] == 'D')
                { 
                    decimalHex =13;

                }
                else if (hexChars[i] == 'E')
                {
                    decimalHex = 14;

                }
                else if (hexChars[i] == 'F')
                {
                    decimalHex = 15;

                }
                else
                {
                    decimalHex =  hexChars[i];

                }
                total +=decimalHex * ( Math.Pow(16, (hexChars.Length - 1) - i));
            }
            Console.WriteLine(total);
            Console.ReadKey();
        }
    }
}
