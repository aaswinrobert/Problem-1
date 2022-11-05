using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TestClass obj = new TestClass();
                obj.Display();
                obj.Print();
                obj.ExtMethod();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:"+ex.ToString());
            }
            finally
            {
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
