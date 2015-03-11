using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace conInfo
{
    class Program
    {

        static void Main(string[] args)
        {

            string sProdName = "Widget";
            int iUnitQty = 100;
            double dUnitCost = 1.03;

            TextWriterTraceListener myWriter = new TextWriterTraceListener(System.Console.Out);
            Debug.Listeners.Add(myWriter);

            //将类生成的消息指定为 WriteLine 方法的第一个输入参数。按 CTRL+ALT+O 组合键以确保“输出”窗口可见。
            Debug.WriteLine("Debug Information-Product Starting ");

            //为了清晰易读，请使用 Indent 方法在“输出”窗口中缩进后面的消息：
            Debug.Indent();

            //要显示所选变量的内容，请使用 WriteLine 方法，如下所示：

            Debug.WriteLine("The product name is " + sProdName);

            Debug.WriteLine("The available units on hand are" + iUnitQty.ToString());

            Debug.WriteLine("The per unit cost is " + dUnitCost.ToString());

            ////您还可以使用 WriteLine 方法显示现有对象的名称空间和类名称。例如，下面的代码在“输出”窗口中显示 System.Xml.XmlDocument 命名空间：

            //System.Xml.XmlDocument oxml = new System.Xml.XmlDocument();

            //Debug.WriteLine(oxml);


            ////要整理输出，可以包括一个类别作为 WriteLine 方法的第二个可选的输入参数。如果您指定一个类别，则“输出”窗口消息的格式为“类别:消息”。例如，以下代码的第一行在“输出”窗口中显示“Field:The product name is Widget”：

            Debug.WriteLine("The product name is " + sProdName, "Field");

            Debug.WriteLine("The units on hand are" + iUnitQty, "Field");

            Debug.WriteLine("The per unit cost is" + dUnitCost.ToString(), "Field");

            Debug.WriteLine("Total Cost is " + (iUnitQty * dUnitCost), "Calc");

            ////要整理输出，可以包括一个类别作为 WriteLine 方法的第二个可选的输入参数。如果您指定一个类别，则“输出”窗口消息的格式为“类别:消息”。例如，以下代码的第一行在“输出”窗口中显示“Field:The product name is Widget”：

            //Debug.WriteLine("The product name is " + sProdName, "Field");

            //Debug.WriteLine("The units on hand are" + iUnitQty, "Field");

            //Debug.WriteLine("The per unit cost is" + dUnitCost.ToString(), "Field");

            //Debug.WriteLine("Total Cost is " + (iUnitQty * dUnitCost), "Calc");

            ////使用 Debug 类的 Assert 方法，使“输出”窗口仅在指定条件计算为 false 时才显示消息：

            //Debug.Assert(dUnitCost > 1, "Message will NOT appear");

            //Debug.Assert(dUnitCost < 1, "Message will appear since dUnitcost < 1 is false");

            ////为“控制台”窗口 (tr1) 和名为 Output.txt (tr2) 的文本文件创建 TextWriterTraceListener 对象，然后将每个对象添加到 Debug Listeners 集合中：

            //TextWriterTraceListener tr1 = new TextWriterTraceListener(System.Console.Out);

            //Debug.Listeners.Add(tr1);



            //TextWriterTraceListener tr2 = new TextWriterTraceListener(System.IO.File.CreateText("Output.txt"));

            //Debug.Listeners.Add(tr2);


            //// 为了清晰易读，请使用 Unindent 方法去除 Debug 类为后续消息生成的缩进。当您将 Indent 和 Unindent 两种方法一起使用时，读取器可以将输出分成组。

            //Debug.Unindent();

            //Debug.WriteLine("Debug Information-Product Ending");

 

            //为了确保每个 Listener 对象收到它的所有输出，请为 Debug 类缓冲区调用 Flush 方法：
            

            Debug.Flush();
            Console.ReadKey();






        }
    }
}
