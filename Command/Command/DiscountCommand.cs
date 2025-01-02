namespace VehicleDiscountSystem {
    using System.Collections.Generic;

    public class DiscountCommand {
        private int stockDuration;
        private decimal discountRate;
        private List<Vehicle> affectedVehicles = new List<Vehicle>();

        public DiscountCommand(int stockDuration, decimal discountRate) {
            this.stockDuration = stockDuration;
            this.discountRate = discountRate;
        }

        public void Apply(List<Vehicle> vehicles) {
            foreach (var vehicle in vehicles) {
                if (vehicle.GetStockDuration() >= stockDuration) {
                    vehicle.ApplyDiscount(discountRate);
                    affectedVehicles.Add(vehicle);
                }
            }
        }

        public void Cancel() {
            foreach (var vehicle in affectedVehicles) {
                vehicle.RestoreOriginalPrice();
            }
            affectedVehicles.Clear();
        }

        // Correctement implémentée
        public override string ToString() {
            return $"Durée stock minimale: {stockDuration} jours, Taux de remise: {discountRate * 100}%";
        }
    }
}