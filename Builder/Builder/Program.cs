using Builder;

Bike bike = new Bike();
VehicleDirector vehicleDirector = new VehicleDirector();
Vehicle vehicle = vehicleDirector.BuildVehicle(bike);
Console.WriteLine($"Vehicle Type {vehicle.VehicleType}");
Console.WriteLine($"Vehicle Name {vehicle.VehicleName}");