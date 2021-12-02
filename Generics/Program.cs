using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> numbers = new MyList<int>(10);
            numbers.Add(10);
            numbers.Add(6);

            MyList<string> stringUwU = new MyList<string>(10);
            stringUwU.Add("Vicente");

            MyList<People> people = new MyList<People>(5);
            people.Add(new People() { Name = "Vicente", Country = "México" });
            people.Add(new People() { Name = "Mariana", Country = "México" });

            Console.WriteLine(numbers.GetStrings());
            Console.WriteLine(stringUwU.GetStrings());
            Console.WriteLine(people.GetStrings());

            Console.WriteLine(numbers.GetElement(11));
            Console.WriteLine(stringUwU.GetElement(0));
        }
    }

    public class People
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"Nombre: {Name}, País: {Country}";
        }
    }

    public class MyList<T>
    {
        private T[] _elements;
        private int _index = 0;

        public MyList(int n)
        {
            this._elements = new T[n];
        }

        public void Add(T e)
        {
            if (this._index < _elements.Length)
            {
                _elements[_index] = e;
                _index++;
            }
        }

        public T GetElement(int i)
        {
            if (i <= _index && i >= 0)
            {
                return _elements[i];
            }

            return default(T);
        }

        public string GetStrings()
        {
            int i = 0;
            string result = "";

            while (i < _index)
            {
                result += _elements[i].ToString() + "|";
                i++;
            }

            return result;
        }
    }
}
