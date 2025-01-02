namespace VehicleDiscountSystem {
    public class User {
        public void CreateDiscountCommand(Catalog catalog, int stockDuration, decimal discountRate) {
            var command = new DiscountCommand(stockDuration, discountRate);
            catalog.LaunchDiscountCommand(command);
        }
    }
}