using System.Diagnostics;
using System.Xml.Linq;

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

        public override void AddLiters(double liters, string fuelType)
        {
            if (liters > 0 && fuelType == "petrol95")
            {
                switch(fuelType)
                {
                    case "petrol95":
                        petrol95.Add(liters); 
                        break;
                    case "petrol98":
                        petrol98.Add(liters);
                        break;
                    case "dieselFuel":
                        dieselFuel.Add(liters);
                        break;
                    case "dieselUltimateFuel":
                        dieselUltimateFuel.Add(liters);
                        break;
                    default:
                        throw new Exception("Wrong fuel type!");
                }

                if (LitersAdded != null)
                {
                    LitersAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid liters value!");
            }
        }

        public override void AddLiters(string liters, string type)
        {
            if (double.TryParse(liters, out double result))
            {
                this.AddLiters(result, type);
            }
            else
            {
                throw new Exception("String is not a double!");
            }
        }

        public String ChooseList(string input)
        {
            string listType;

            switch (input)
            {
                case "A":
                case "a":
                    listType = "petrol95";
                    break;
                case "B":
                case "b":
                    listType = "petrol98";
                    break;
                case "C":
                case "c":
                    listType = "dieselFuel";
                    break;
                case "D":
                case "d":
                    listType = "dieselUltimateFuel";
                    break;
                default:
                    throw new Exception("Wrong letter!");
            }

            return listType;
        }

        public override Statistics GetStatistics(string type)
        {
            throw new NotImplementedException();
        }
    }
}
