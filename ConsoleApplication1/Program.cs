using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(TestMethod));
        }
        public static void TestMethod()
        {
            Console.WriteLine("不带参数的线程函数");
        }

        public static void TestMethod(object data)
        {
            string datastr = data as string;
            Console.WriteLine("带参数的线程函数，参数为：{0}", datastr);
        }
    }
}
