namespace PetrolStationCounter
{
    internal class PetrolStationCounterInMemory : BasePetrolStationCounter
    {
        private List<double> petrol95 = new List<double>();
        private List<double> petrol98 = new List<double>();
        private List<double> dieselFuel = new List<double>();
        private List<double> dieselUltimateFuel = new List<double>();
        
        public override event LitersAddedDelegate LitersAdded;

        public PetrolStationCounterInMemory(string name, string location)
            : base(name, location)
        {
    
        }

        public override void AddLiters(double liters, List<double> fuelType)
        {
            throw new NotImplementedException();
        }

        public override void AddLiters(string liters, string type)
        {
            throw new NotImplementedException();
        }

        public List<double> ChooseList(string input)
        {
            List<double> fuelList;

            switch (input)
            {
                case "A":
                case "a":
                    fuelList = this.petrol95;
                    break;
                case "B":
                case "b":
                    fuelList = this.petrol98;
                    break;
                case "C":
                case "c":
                    fuelList = this.dieselFuel;
                    break;
                case "D":
                case "d":
                    fuelList = this.dieselUltimateFuel;
                    break;
                default:
                    throw new Exception("Wrong letter!");
            }

            return fuelList;
        }

        public override Statistics GetStatistics(string type)
        {
            throw new NotImplementedException();
        }
    }
}
