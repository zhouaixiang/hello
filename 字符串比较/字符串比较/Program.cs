using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 字符串比较
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p["老大"] = "张三";
            p["老二"] = "李四";
            Console.WriteLine("老大的名字：{0}；老二的名字：{1}",p["老大"],p["老二"]);
            Console.ReadKey();
        }
    }
    
    class Person
    {

        //索引器；

        private string name1;
        private string name2;

        public string this[string s] 
        {
            set
            {
                if (s == "老大")
                {
                    name1 = value;
                }
                else if(s=="老二")
                {
                    name2 = value;
                }
                else 
                {
                    throw new Exception("error");

                }
             
            }
            get 
            {
                if (s == "老大")
                {
                    return name1;
                }
                else if (s == "老二")
                {
                    return name2;
                }
                else 
                {
                    throw new Exception("error");
                }
                
            }

        }



    
    }
}
