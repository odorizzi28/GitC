using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nameList = new string[2] { "Valor 1", "Valor2" };
            foreach (var item in nameList)
                Console.WriteLine(item);
            string[] dataList = new string[10000];
            DateTime firistime = DateTime.Now;

            for (int i = 0; i < dataList.Length; i++)
            {
                dataList[i] = DateTime.Now.ToString("yyyyMMddhhmmssfff");
               // Console.WriteLine(dataList[i]);
            }

                Console.WriteLine((DateTime.Now - firistime).ToString());
           
            Console.ReadLine();
        }

    }
}
