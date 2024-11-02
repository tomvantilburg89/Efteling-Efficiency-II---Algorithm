using Rides;
using Visitors;
using Control;
using Microsoft.VisualBasic;
using System;
namespace Park
{
    public class RiskAI : Support
    {
        private readonly Park Efteling;

        private readonly List<Ride> RiskRides = [];
        private readonly List<Ride> GentleRides = [];
        private readonly List<Visitor> RiskVisitors = [];
        private readonly List<Visitor> GentleVisitors = [];

        public RiskAI(Park efteling)
        {
            Efteling = efteling;

            RidesProfiler()
                .VisitorProfiler()
                .QueueObserver()
                ;
        }

        public RiskAI RidesProfiler()
        {
            Efteling.Rides.ForEach(e =>
            {
                if (e.IsHighRisk())
                {
                    RiskRides.Add(e);
                    return;
                }
                GentleRides.Add(e);
            });
            return this;
        }

        public RiskAI VisitorProfiler()
        {
            Efteling.Visitors.ForEach(e =>
            {
                if (e.IsHighRisk())
                {
                    RiskVisitors.Add(e);
                    return;
                }
                GentleVisitors.Add(e);
            });

            return this;

        }

        public void QueueObserver()
        {
            Console.CursorVisible = false;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            //Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.SetCursorPosition(0, 3);
     
            
            Console.SetCursorPosition(0, 9);
            //Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            Dictionary<Ride, Visitor> rideQueues = [];
            
            //foreach 


            foreach (Ride ride in Efteling.Rides)
            {

                ListHelper.Shuffle(Efteling.Visitors);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;

                Console.SetCursorPosition(0, 0);
                Console.WriteLine(new string(' ', Console.WindowWidth * 2));
                Console.SetCursorPosition(0, 2);
                Console.WriteLine(ride.Name);

                foreach (Visitor visitor in Efteling.Visitors)
                {
                    Console.SetCursorPosition(0, 4);

                    Console.ForegroundColor = ConsoleColor.White;

                    if (visitor.IsHighRisk() && ride.IsHighRisk())
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }

                    Console.WriteLine("Name: " + visitor.Name);
                    Console.WriteLine("Age: " + visitor.Age);
                    String foodPreference = "Food: Green   ";

                    Console.ForegroundColor = ConsoleColor.Green;
                    if (visitor.GetStatus() == Status.Risks.HIGH)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        foodPreference = "Food: Greasy   ";
                    }
                    Console.WriteLine(foodPreference);

                    Thread.Sleep(visitor.IsHighRisk() ? visitor.IsHighRisk() && ride.IsHighRisk() ? 1000 : 100 : 1);
                    Console.SetCursorPosition(0, 4);
                    Console.WriteLine(new string(' ', Console.WindowWidth * 24));
                }
            }

            Efteling.Visitors.ForEach(person =>
            {
                Efteling.Rides.ForEach(ride =>
                {
                    // TODO: Finish this

                });
            });
        }
    }
}
