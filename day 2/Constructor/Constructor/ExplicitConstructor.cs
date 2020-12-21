using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//if you create instance number of times that many times the constructor will be called.
namespace Constructor
{
    class ExplicitConstructor
    {
        public ExplicitConstructor()
        {
            Console.WriteLine("constructor is called");
        }

        static void Main()
        {
            ExplicitConstructor ec = new ExplicitConstructor();


        }
    }
}
