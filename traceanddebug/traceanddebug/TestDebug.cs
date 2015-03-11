using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace traceanddebug
{
    class TestDebug
    {
        public static void TestDebugMethod() 
        {
           /*Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
            //将Debug类输出定向到控制台输出
            * */
            Debug.Listeners.Add(new TextWriterTraceListener("c://testdebug2.log"));
          
            Debug.AutoFlush = true;

            //设置Debug为自动输出，即每次写入后都调用Listeners上调用Flush

            Debug.Indent();

            //设置缩进

            Debug.WriteLine("Debug WriteLine()");

            //用Debug输出"Debug WriteLine()"

            Console.WriteLine("Console.WriteLine()");

            //用Console输出"Console.WriteLine()"

            Debug.WriteLine("Debug WriteLine2()");

            //用Debug输出"Debug WriteLine2()"

            Debug.Unindent();

            //取消缩进

            Console.Read();


        }
    }
}
