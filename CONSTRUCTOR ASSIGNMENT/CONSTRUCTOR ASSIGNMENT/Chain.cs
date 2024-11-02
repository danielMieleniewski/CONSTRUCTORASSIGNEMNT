using System;

namespace CONSTRUCTOR_ASSIGNMENT
{
    public class Chain
    {
        public Chain(float num1) : this(num1, "Bob")
        {
        }

        public Chain(string name1) : this(42, name1)
        {
            Console.WriteLine(name1 + " and our favorite number is " + Num);
        }

        public Chain(float num, string name)
        {
            Name = name;
            Num = num; // Fixed assignment here
        }

        public string Name { get; set; } // Made public for external access
        public float Num { get; set; }   // Made public for external access
    }
}
