using System;
using VehicleDiscountSystem;

namespace VehicleDiscountSystem {
    class Program {
        static void Main(string[] args) {
             Catalog catalog = new Catalog();

            catalog.AddVehicle(new Vehicle(DateTime.Now.AddDays(-50), 20000)); 
            catalog.AddVehicle(new Vehicle(DateTime.Now.AddDays(-20), 15000)); 
            catalog.AddVehicle(new Vehicle(DateTime.Now.AddDays(-80), 30000)); 

            catalog.ShowVehicles();

            User user = new User();

            Console.WriteLine("\nApplication d'une remise de 10% pour les véhicules en stock depuis 30 jours ou plus...");
            user.CreateDiscountCommand(catalog, 30, 0.10m);
            catalog.ShowVehicles();

            Console.WriteLine("\nApplication d'une remise de 20% pour les véhicules en stock depuis 60 jours ou plus...");
            user.CreateDiscountCommand(catalog, 60, 0.20m);
            catalog.ShowVehicles();

            Console.WriteLine("\nAnnulation de la dernière commande de remise...");
            catalog.CancelDiscountCommand(1);
            catalog.ShowVehicles();

            Console.WriteLine("\nOpérations terminées.");
        }
    }
}