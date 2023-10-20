using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Complete_Master
{
    public class MethodsConditionalsFinalproject
    {
        //Void Methods 
        public  void PrintGreetings(string greetText)
        {
            Console.WriteLine("hello " + greetText);
        }


        //non void methods
        public int AddSum( int a , int b)
        {
            return a + b;
        }



        public bool IsLong(string text)
        {
            if (text.Length > 10)
            {
                return true;
            }
            return false;
        }

        //Exercise AbsoluteOfSum

        public static int AbsoluteOfSum(int a , int b)
        {
            var result = a + b;
            if (result < 0)
            {
                return -1 * result;
            }
            return result;
        }


        //types of parameters and staticalyy typed language 
        //int t = "jsoepd";


        //parsing a string to int 

        public int ParsingString()
        {
            Console.WriteLine("Please enter number:");
            var input = Console.ReadLine();

            int parsedString = int.Parse(input);

            return parsedString;
        }


    }
}
