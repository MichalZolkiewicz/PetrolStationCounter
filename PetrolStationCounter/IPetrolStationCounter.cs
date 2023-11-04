using static PetrolStationCounter.BasePetrolStationCounter;

namespace PetrolStationCounter
{
    public interface IPetrolStationCounter
    {
        string Name { get; }
        string Location { get; }

        void AddLiters(double liters, string fileName);
        void AddLiters(string liters, string fileName);
        Statistics GetStatistics(string fileName);

        event LitersAddedDelegate LitersAdded;
    }
}
