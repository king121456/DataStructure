using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStru
{
    //c#数据结构
    class Program
    {
        static void Main(string[] args)
        {
            //LinkList x = new LinkList();
            //x.value = "xxx";
            LinkList list = new LinkList();
            list.Add(1);
            list.Add(2);
            list.Add("fffff");
            //var类型推断
            foreach (var x in list)
            {
                Console.Write(x);
            }
            
            Console.ReadKey();
        }
    }
}
