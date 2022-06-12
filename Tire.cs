using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Tire
    {
        public int Age { get; set; }
        public double Preassure { get; set; }


        public Tire(double preassure, int age)
        {
            
            Preassure = preassure;
            Age = age;


        }
    }
}
