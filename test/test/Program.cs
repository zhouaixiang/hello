using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

        

            while(true)
            {
                Console.WriteLine("请输入一个数字");
                string s = Console.ReadLine();
                int num = 0;
                if (s != "q")
                {
                    num = Convert.ToInt32(s);

                    Console.WriteLine("{0}", num * 2);
                }
                else
                {
                    return;
                }
                Console.ReadKey();  
            }
   
        }
    }
}
