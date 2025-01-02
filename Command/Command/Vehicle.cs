namespace VehicleDiscountSystem {
    public class Vehicle {
        private DateTime stockEntryDate;
        private decimal salePrice;
        private decimal originalPrice;

        public Vehicle(DateTime stockEntryDate, decimal salePrice) {
            this.stockEntryDate = stockEntryDate;
            this.salePrice = salePrice;
            this.originalPrice = salePrice; 
        }

        public int GetStockDuration() {
            return (DateTime.Now - stockEntryDate).Days;
        }

        public void ApplyDiscount(decimal discountRate) {
            originalPrice = salePrice; 
            salePrice *= (1 - discountRate);
        }

        public void RestoreOriginalPrice() {
            salePrice = originalPrice; 
        }

        public decimal GetPrice() {
            return salePrice;
        }

        public override string ToString() {
            return $"Prix: {salePrice}€, Durée en stock: {GetStockDuration()} jours";
        }
    }
}