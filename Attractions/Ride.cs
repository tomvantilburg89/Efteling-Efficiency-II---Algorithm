namespace Attractions
{
    abstract public class Ride
    {
        private bool CardioVascularRisk { get; set; }

        private string Name { get; set; }

        public bool IsRisk() { return CardioVascularRisk; }

        public Ride(string name, bool cardioRisk = false) { 
            Name = name;
            CardioVascularRisk = cardioRisk;
        }

    }
}
