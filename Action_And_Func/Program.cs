using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_And_Func
{
    class Program
    {
        /*Action is a delegate (pointer) to a method, that takes zero, one or more input parameters, but does not return anything.

          Func is a delegate (pointer) to a method, that takes zero, one or more input parameters, and returns a value (or reference).*/
        static void Main(string[] args)
        {
            Action<int> myAction = new Action<int>(DoSomething);
            myAction(123);           // Prints out "123"
                                     // can be also called as myAction.Invoke(123);

            Func<int, double> myFunc = new Func<int, double>(CalculateSomething);
            Console.WriteLine(myFunc(5));   // Prints out "2.5"
        }

        static void DoSomething(int i)
        {
            Console.WriteLine(i);
        }

        static double CalculateSomething(int i)
        {
            return (double)i / 2;
        }
    }
}
