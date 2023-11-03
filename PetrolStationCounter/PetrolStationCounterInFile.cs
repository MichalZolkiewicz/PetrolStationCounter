namespace PetrolStationCounter
{
    internal class PetrolStationCounterInFile : BasePetrolStationCounter
    {
        public override event LitersAddedDelegate LitersAdded;

        private const string petrol95File = "95.txt";
        private const string petrol98File = "98.txt";
        private const string dieselFile = "ON.txt";
        private const string dieselUltimateFile = "Ulti.txt";

        public PetrolStationCounterInFile(string name, string location)
            : base(name, location)
        {
        }

        public override void AddLiters(double liters)
        {
            throw new NotImplementedException();
        }

        public override void AddLiters(char liters)
        {
            throw new NotImplementedException();
        }

        public override void AddLiters(string liters)
        {
            throw new NotImplementedException();
        }

        public override Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}
