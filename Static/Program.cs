using System;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People()
            {
                Name = "Vicente",
                Age = 22
            };

            People people1 = new People()
            {
                Name = "Michelle",
                Age = 23
            };

            Console.WriteLine(People.GetCount());
        }

        public class People
        {
            public static int Count = 0;
            public string Name { get; set; }
            public int Age { get; set; }

            public People()
            {
                Count++;
            }

            public static string GetCount()
            {
                return $"Esta clase se ha utilizado {Count} veces";
            }
        }
    }
}
