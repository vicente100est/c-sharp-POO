using System;
using System.Text.Json;

namespace Json
{
    class Program
    {
        static void Main(string[] args)
        {
            Beer myBeer = new Beer()
            {
                Name = "Pikantus",
                Brand = "Erdiger"
            };

            //string json = "{\"Name\": \"Pikantus\", \"Brand\": \"Erdiger\"}";

            string json = JsonSerializer.Serialize(myBeer);

            Beer beer = JsonSerializer.Deserialize<Beer>(json);

            Beer[] beers = new Beer[]
            {
                new Beer()
                {
                    Name = "Pikantus",
                    Brand = "Erdiger"
                },
                new Beer()
                {
                    Name = "Corona",
                    Brand = "Modelo"
                }
            };

            string json2 = "[" +
                "{\"Name\": \"Pikantus\", \"Brand\": \"Erdiger\"}," +
                "{\"Name\": \"Corona\", \"Brand\": \"Modelo\"}" +
                "]";
        }

        public class Beer
        {
            public string Name { get; set; }
            public string Brand { get; set; }
        }
    }
}
