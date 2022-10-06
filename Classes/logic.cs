using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public static class Logic
    {

        enum Category
        {
            A = 100,
            B = 80,
            C = 60,
            D = 40,
            E = 20
        }
        
        private static void DisplayInfo()
        {
            var prevEnumVal = -1; 
            foreach (Category thisEnum in Enum.GetValues(typeof(Category)))
            {
                Console.WriteLine($"Category: {thisEnum} has the range of {(int)prevEnumVal+1} - {(int)thisEnum}");
                prevEnumVal = (int)thisEnum;
            }
        }

        private static void CheckNumber(int x)
        {


            var prevEnumVal = -1;
            foreach (Category thisEnum in Enum.GetValues(typeof(Category)))
            {

                if (x<(int)thisEnum && x>(int)prevEnumVal)
                {
                    Console.WriteLine(thisEnum);
                }
                prevEnumVal = (int)thisEnum+1;
            }

        }

        public static void Launcher()
        {
            int exitCode = -1;
            int userInput = 0;
            while(userInput!=exitCode)
            {
                DisplayInfo();
                userInput = Convert.ToInt32(Console.ReadLine());
                CheckNumber(userInput);
            }




        }


       
    }
}
