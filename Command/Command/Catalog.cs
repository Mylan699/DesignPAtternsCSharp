namespace VehicleDiscountSystem {
    using System;
    using System.Collections.Generic;

    public class Catalog {
        private List<Vehicle> vehicleStock = new List<Vehicle>();
        private List<DiscountCommand> commands = new List<DiscountCommand>();

        public void AddVehicle(Vehicle vehicle) {
            vehicleStock.Add(vehicle);
        }

        public void LaunchDiscountCommand(DiscountCommand command) {
            command.Apply(vehicleStock);
            commands.Add(command);
            Console.WriteLine($"Commande de remise appliquée : {command}");
        }

        public void CancelDiscountCommand(int index) {
            if (index >= 0 && index < commands.Count) {
                commands[index].Cancel();
                Console.WriteLine($"Commande de remise annulée : {commands[index]}");
                commands.RemoveAt(index);
            } else {
                Console.WriteLine("Index invalide pour l'annulation de la commande.");
            }
        }

        public void ShowVehicles() {
            Console.WriteLine("Liste des véhicules dans le stock :");
            foreach (var vehicle in vehicleStock) {
                Console.WriteLine(vehicle);
            }
        }
    }
}