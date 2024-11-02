
namespace Program
{

    using Park;
    class Program
    {

        private Park efteling = new Park();
        static void Main(string[] args)
        {
            RiskAI riskAI = new RiskAI(new Park());
        }
    }
}
