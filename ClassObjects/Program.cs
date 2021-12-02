using System;

namespace ClassObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Sale sale1 = new Sale(100, DateTime.Now);

            Console.WriteLine(sale1.GetInfo());
        }
    }

    class Sale
    {
        int total;
        DateTime date;

        public Sale(int total, DateTime date)
        {
            this.total = total;
            this.date = date;
        }

        public string GetInfo()
        {
            return total + " " + date.ToLongDateString();
        }

        public void Show()
        {
            Console.WriteLine("Hola soy una venta");
        }
    }
}
