using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    class Car
    {
        public string CarName { get; set; }
        public string Model { get; set; }
        public DateTime CreateDate { get; set; }
        public string Color { get; set; }

    }

    class Client
    {
        public string Name { get; set; }
        public string CarModel { get; set; }
        public string PhoneNumber { get; set; }
    }

    class Program
    {


        static void Main(string[] args)
        {
            var cars = new List<Car>  {
            new Car {CarName = "Dacia", Model = "Logan", CreateDate = DateTime.Parse("01/01/2008"), Color = "Grey"},
            new Car {CarName = "Renault", Model = "Laguna", CreateDate = DateTime.Parse("01/01/2010"), Color = "Blue"},
            new Car {CarName = "Ferrary", Model = "F1", CreateDate = DateTime.Parse("01/01/2015"), Color = "Red"},
            new Car {CarName = "Tesla", Model = "ModelS", CreateDate = DateTime.Parse("01/01/2020"), Color = "black"},
            new Car {CarName = "Opel", Model = "Insignia", CreateDate = DateTime.Parse("01/01/2011"), Color = "Silver"}
        };

            var clients = new List<Client>
            {
                new Client {Name = "Alex", CarModel = "Logan", PhoneNumber = "123"},
                new Client {Name = "Frenk", CarModel = "Laguna", PhoneNumber = "456"},
                new Client {Name = "Oleg", CarModel = "Laguna", PhoneNumber = "789"},
                new Client {Name = "Ivan", CarModel = "F1", PhoneNumber = "1012"},
                new Client {Name = "Serg", CarModel = "ModelS", PhoneNumber = "1112"},
                new Client {Name = "David", CarModel = "Insignia", PhoneNumber = "1113"},
            };

            var query = from car in cars
                        join client in clients
                        on car.Model equals client.CarModel
                        where client.Name == "Alex"
                        select new
                        {
                            ClientName = client.Name,
                            ClientPhone = client.PhoneNumber,
                            CarName = car.CarName,
                            CarModel = car.Model,
                            CarDate = car.CreateDate,
                            CarColor = car.Color,
                        };
            var query2 = cars.Join(clients,
                           car => car.Model,
                           client => client.CarModel,
                           (car, cli) => new {
                               ClientName = cli.Name,
                               ClientPhone = cli.PhoneNumber,
                               CarName = car.CarName,
                               CarModel = car.Model,
                               CarDate = car.CreateDate,
                               CarColor = car.Color,
                           }).Where(cli => cli.ClientName == "Alex") ;

            foreach (var client in query)
            {
                Console.WriteLine($"{client.ClientName} {client.ClientPhone}, {client.CarName} {client.CarModel} {client.CarDate} {client.CarColor}");
            }

            foreach (var client in query2)
            {
                Console.WriteLine($"{client.ClientName} {client.ClientPhone}, {client.CarName} {client.CarModel} {client.CarDate} {client.CarColor}");
            }


        }
    }
}
