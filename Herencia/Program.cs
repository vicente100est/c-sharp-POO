using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor doc = new Doctor("Christian", 40, "Cardiologo");
            Dev dev = new Dev("Vicente", 22, "C#");
            Console.WriteLine(doc.GetData2());
            Console.WriteLine(dev.GetData3());
        }

        class People
        {
            private string _name;
            private int _age;
            public People(string name, int age)
            {
                this._name = name;
                this._age = age;
            }

            public string GetInfo()
            {
                return _name + " " + _age;
            }
        }

        class Doctor : People
        {
            private string _speciality;
            public Doctor(string name, int age, string speciality) : base(name, age)
            {
                this._speciality = speciality;
            }

            public string GetData2()
            {
                return GetInfo() + " " + _speciality;
            }
        }

        class Dev : People
        {
            private string _lebguage;

            public Dev(string name, int age, string lenguage) : base(name, age)
            {
                this._lebguage = lenguage;
            }

            public string GetData3()
            {
                return GetInfo() + " " + _lebguage;
            }
        }
    }
}
