using System;

namespace Sobreescritura
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            Console.WriteLine(b.Hi());
        }
    }

    public class A
    {
        public virtual string Hi()
        {
            return "Hello, i'm A";
        }
    }

    public class B : A
    {
        public override string Hi()
        {
            return base.Hi() + " " + "Hello I'm B";
        }
    }
}
