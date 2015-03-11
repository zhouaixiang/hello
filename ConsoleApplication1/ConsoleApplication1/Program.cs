using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = {"1","3","5","7","9","10","11"};
            for (int i = 0; i < strs.Length / 2; i++)
            {
                string temp = "";
                temp = strs[i];
                strs[i] = strs[strs.Length - 1-i];
                strs[strs.Length - 1 - i] = temp;
            }
            Console.WriteLine("输出反序的字符串数组");
            for(int i = 0; i < strs.Length ; i++)
            {
                Console.WriteLine("{0}",strs[i]);
           
            }
         

         


          
            Console.ReadKey();
        }
    }
}
