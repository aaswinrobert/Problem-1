using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    public class myOutOfRangeException : Exception
    {
        public override string Message
        {
            get
            {
                return "Amlan, Index should beless than array size";
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = { 5, 4, 7, 8, 6 };
                Console.WriteLine("Please enter the index value: ");
                int indx = Convert.ToInt32(Console.ReadLine());
                if(indx > arr.Length-1)
                {
                    throw new myOutOfRangeException();
                }
                Console.WriteLine("The value of index six is:{0}",arr[indx]);
            }
            catch(myOutOfRangeException ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
            Console.ReadKey();
        }
    }
}
