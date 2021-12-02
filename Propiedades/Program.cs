using System;

namespace Propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Sale mySale = new Sale(100, DateTime.Now);
//            mySale.Total = -8452;
            Console.WriteLine(mySale.GetData());
        }
    }

    class Sale
    {
        private int total;
        private DateTime date;

        public int Total
        {
            get
            {
                return total;
            }
            set
            {
                if (value < 0)
                    value = 0;
                total = value;
            }
        }

        public string Date
        {
            get
            {
                return date.ToLongDateString();
            }
        }

        public Sale(int _total, DateTime _date)
        {
            this.total = _total;
            this.date = _date;
        }

        public string GetData()
        {
            return total + " " + date.ToLongDateString();
        }
    }
}
