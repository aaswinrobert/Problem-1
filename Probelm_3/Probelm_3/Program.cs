using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probelm_3
{
    public interface ITest1
    {
        void disp();
    }
    public interface ITest2
    {
        void disp();
    }
    public class TestClass : ITest1, ITest2
    {
        void ITest1.disp()
        {
            Console.WriteLine("I'm ITest1 method");
        }
        void ITest2.disp()
        {
            Console.WriteLine("I'm ITest2 method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TestClass tc = new TestClass();
                ITest1 it1 = tc;
                ITest2 it2 = tc;

                it1.disp();
                it2.disp();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.ToString());
            }
            Console.ReadKey();
        }
    }
}
