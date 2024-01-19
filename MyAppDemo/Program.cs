using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRBusinessLibrary;
namespace HRConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UI
            Console.WriteLine("Menu");
            Console.WriteLine("*****");
            Console.WriteLine("1.Add \n2.Subtract \n3.Multiply \n4.Divide \n5.Exit");
            Console.WriteLine("What do u want to do? select one of the above.....");
            int userchoice=Convert.ToInt32(Console.ReadLine());
            int fno=0, sno=0,ans=0;
            if (userchoice != 5)
            {

                Console.WriteLine("Enter your first number");
                fno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number");
                sno = Convert.ToInt32(Console.ReadLine());
            }
            if (userchoice == 1) 
            {
            
                 ans=Calculator.Add(fno, sno);
                Console.WriteLine($"The addition of {fno} and {sno}={ans}");
            }
            else if(userchoice == 2)
            {

                ans=Calculator.Subtract(fno, sno);
                Console.WriteLine($"The subtraction of {fno} and {sno}={ans}");
            }
            else if(userchoice == 3) {
                ans = Calculator.Multiply(fno, sno);
                Console.WriteLine($"The multiplication of {fno} and {sno}={ans}");

            }
            else if (userchoice==4)
            {
                ans = Calculator.Multiply(fno, sno);
                Console.WriteLine($"The multiplication of {fno} and {sno}={ans}");

            }
            else
            {
                Environment.Exit(1);
            }
            Console.ReadLine();


        }
    }
}
