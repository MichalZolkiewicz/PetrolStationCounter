using static PetrolStationCounter.BasePetrolStationCounter;

namespace PetrolStationCounter
{
    public interface IPetrolStationCounter
    {
        string Name { get; }
        string Location { get; }

        void AddLiters(double liters);
        void AddLiters(char liters);
        void AddLiters(string liters);
        Statistics GetStatistics();

        event LitersAddedDelegate LitersAdded;
    }
}
