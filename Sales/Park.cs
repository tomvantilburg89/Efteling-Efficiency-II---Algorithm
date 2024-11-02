namespace Park
{
    using Rides;
    using System;
    using Visitors;
    using Control;
    public class Park : Support
    {
        public Park()
        {
            this.GenerateRides().GenerateSales();
            ListHelper.Shuffle(Rides);
        }

        private Visitor? JohnDoe;

        private Train? train;
        private ThrillRide? thrillRide;
        private RollerCoaster? rollerCoaster;

        public List<Visitor> Visitors = [];

        public List<Ride> Rides = [];

        public Park GenerateRides()
        {
            int amountRides = 30;

            //for (int rides = 0;  rides < amountRides; int++)
            //{
            //    if (rides % 3 == 0) Rides.Add(new RollerCoaster());
            //}

            // While generating rides
            while (amountRides > 0)
            {
                
                // Instantiate new rides
                rollerCoaster = new RollerCoaster();
                thrillRide = new ThrillRide();
                train = new Train();

                rollerCoaster.SetStatus(2);
                thrillRide.SetStatus(2);

                // RNG if Risk
                Rides.Add(rollerCoaster);
                Rides.Add(thrillRide);
                Rides.Add(train);
                // Trains no risk

                amountRides--;

            }

            return this;
        }

        public Park GenerateSales()
        {

            int amountVisitors = 50;

            while (amountVisitors > 0)
            {
                JohnDoe = new Visitor();
                JohnDoe.SetStatus(2);

                Visitors.Add(JohnDoe);

                amountVisitors--;
            }

            return this;
        }
    }
}
