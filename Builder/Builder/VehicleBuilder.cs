namespace Builder
{
    public abstract class VehicleBuilder
    {
        protected Vehicle Vehicle;
        public virtual void CreateVehicle()
        {
            Vehicle = new Vehicle();
        }
        public abstract void InitializeVehicleAndName();
        public abstract void InitializeEngineAndCC();
        public abstract void InitializeBreakTypes();
        public abstract Vehicle GetVehicle();
    }
}
