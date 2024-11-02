namespace Rides
{
    using Control;

    abstract public class Ride : Support
    {
        public string Name { get; set; }

        public Ride()
        {
            Name = FakeName(true);
        }
    }
}
