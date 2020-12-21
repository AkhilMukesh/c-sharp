using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Plymorphism- Method Overloading or compile time polymorphsim.
/// method hving same name but different parameters is knows as method overloading.
/// </summary>
namespace polymorphism
{
    class MethodOverloading
    {

        public void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void add(int a, float b)
        {
            Console.WriteLine(a + b);
        }

        static void Main()
        {
            MethodOverloading p = new MethodOverloading();
            p.add(2, 5f);
            p.add(2, 8);
        }

    }
}
