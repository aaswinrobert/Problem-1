using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    public class TestClass
    {
        public void Display()
        {
            Console.WriteLine("I'm in Display");
        }
        public void Print()
        {
            Console.WriteLine("I'm in Print");
        }
    }
    public static class ExtClass
    {
        public static void ExtMethod(this TestClass ob)
        {
            Console.WriteLine("Hello I'm extended method");
        }
    }
}
