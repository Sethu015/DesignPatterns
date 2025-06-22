namespace Builder
{
    public class VehicleDirector
    {
        public Vehicle BuildVehicle(VehicleBuilder builder)
        {
            builder.CreateVehicle();
            builder.InitializeVehicleAndName();
            builder.InitializeEngineAndCC();
            builder.InitializeBreakTypes();
            return builder.GetVehicle();
        }
    }
}
