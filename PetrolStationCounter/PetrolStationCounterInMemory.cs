namespace PetrolStationCounter
{
    internal class PetrolStationCounterInMemory : BasePetrolStationCounter
    {
        public override event LitersAddedDelegate LitersAdded;

        public PetrolStationCounterInMemory(string name, string location)
            : base(name, location)
        {
    
        }

        public override void AddLiters(double liters, string fileName)
        {
            throw new NotImplementedException();
        }

        public override void AddLiters(string liters, string fileName)
        {
            throw new NotImplementedException();
        }

        public override Statistics GetStatistics(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
