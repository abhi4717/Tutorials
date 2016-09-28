using System;
using ProfessionalTutorial.Chapter_3_Inheritance;

namespace ProfessionalTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            MyBaseClass baseCls = new MyDerivedClass();
            Console.WriteLine(baseCls.Name);
            
        }
    }
}
