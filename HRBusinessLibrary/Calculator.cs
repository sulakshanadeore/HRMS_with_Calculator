using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRBusinessLibrary
{
    public class Calculator
    {
        //Add/Subtract/Divide/Multiply/Power/Cube etc
        public  static int Add(int x, int y)
        {
            return x + y;
        
        }

        public static  int Subtract(int x, int y) 
        {
        return x - y;   
        }
        public static  int Multiply(int x, int y) 
        {
            return (x * y);
        }

        public static  int Divide(int x, int y) 
        {
            int divans = 0;
        if (y!=0)
            {
                divans = x / y;

            }
        return divans;
        }
    }
}
