using static PetrolStationCounter.BasePetrolStationCounter;

namespace PetrolStationCounter
{
    public interface IPetrolStationCounter
    {
        string Name { get; }
        string Location { get; }

        public double AddLiters(double liters);
        public double AddLiters(char liters);
        public double AddLiters(string liters);
        Statistics GetStatistics();

        event LitersAddedDelegate LitersAdded;
    }
}
