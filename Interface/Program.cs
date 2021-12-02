using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Shark[] sharks = new Shark[]
            {
                new Shark("Tiburonsin",56),
                new Shark("Jaws", 65)
            };

            ShowFish(sharks);
        }

        public static void ShowFish(IFish[] fish)
        {
            Console.WriteLine("- Mostramos los peces --");
            int i = 0;
            while (i < fish.Length)
            {
                Console.WriteLine(fish[i].Swim());
                i++;
            }
        }
    }

    public class Shark : IAnimal, IFish
    {
        public string Nombre { get; set; }
        public int Speed { get; set; }

        public Shark(string Name, int Speed)
        {
            this.Nombre = Name;
            this.Speed = Speed;
        }
        public string Swim()
        {
            return $"{Nombre} Nada {Speed}";
        }
    }

    public interface IAnimal
    {
        public string Nombre { get; set; }
    }

    public interface IFish
    {
        public int Speed { get; set; }
        public string Swim();
    }
}
