using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {  
            //new code
            for( int count = 0; count < 3; count++)
            {
                Console.WriteLine("the value of count is now" + count + ".");
                Console.ReadKey();
                if (count == 2)
                {
                    return;
                }
            }
            Console.WriteLine("the loop is finished");
            Console.ReadKey();
            
                
            
        }
    }
}
