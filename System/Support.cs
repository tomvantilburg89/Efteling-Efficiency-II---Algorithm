namespace Control
{
    using Bogus;
    using Bogus.DataSets;
    using Status;
    public class Support
    {
        private Risks Status { get; set; }

        public Support()
        {
            
        }


        public static int FakeAge()
        {
            return DateTime.Now.Year - new Person().DateOfBirth.Year;
        }

        private static String FakeRideName()
        {
            return new Commerce().Color() + " " + new Person().LastName;
        }

        public static String FakeName(bool isRide = false)
        {
            return !isRide ? new Person().FullName : Support.FakeRideName();
        }

        // Determinination of high risk profilication
        public bool IsHighRisk()
        {
            return this.Status == Risks.HIGH;
        }

        public bool IsNoRisk()
        {
            return this.Status == Risks.NONE;
        }

        public void SetStatus(int randNo)
        {
            Status = (Risks) new Random().Next(randNo);
        }
        public Risks GetStatus()
        {
            return Status;
        }

    }
}
