namespace Builder
{
    public class Bike : VehicleBuilder
    {
        public override Vehicle GetVehicle()
        {
            return Vehicle;
        }

        public override void InitializeBreakTypes()
        {
            Vehicle.BreakTypes = "Front ABS Back ABS";
        }

        public override void InitializeEngineAndCC()
        {
            Vehicle.Engine = "Turbo Engine";
            Vehicle.CC = 398.2M;
        }

        public override void InitializeVehicleAndName()
        {
            Vehicle.VehicleType = "Two Wheeler";
            Vehicle.VehicleName = "Royal Enfield Himalayan";
        }
    }
}
