

namespace Visitors
{
    //using Bogus.DataSets;
    using Control;
    using Status;

    public class Visitor : Support
    {
        public string Name { get; init; }
        public int Age { get; init; }
        
        public Visitor()
        {
            Name = FakeName();
            Age = FakeAge();
        }

        public new bool IsHighRisk()
        {
            return GetStatus() == Risks.HIGH && Age >= 55;
        }
    }
}
