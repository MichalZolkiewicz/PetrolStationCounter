using System.Diagnostics;
using System.Runtime.CompilerServices;

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
        
        public override void AddLiters(double liters, string fileName)
        {
            if (liters > 0)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(liters);
                    if (LitersAdded != null)
                    {
                        LitersAdded(this, new EventArgs());
                    }
                }
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        public override void AddLiters(string liters, string fileName)
        {
            if(double.TryParse(liters, out double result))
            {
                this.AddLiters(result, fileName);
            }
            else
            {
                throw new Exception("String is not a double!");
            }
        }      

        public String ChooseFile(string input)
        {
            string fileName = "";

            switch (input)
            {
                case "A":
                    fileName = petrol95File;
                    break;
                case "B":
                    fileName = petrol98File;
                    break;
                case "C":
                    fileName = dieselFile;
                    break;
                case "D":
                    fileName = dieselUltimateFile;
                    break;
                case "Q":
                case "q":
                        break;
                        
                default:
                    throw new Exception("Wrong letter!");
            }

            return fileName;
        }

        private List<double> GetLitersFromFile(string filename)
        {
            var liters = new List<double>();
            if(File.Exists(filename))
            {
                using(var reader = File.OpenText(filename))
                {
                    var line = reader.ReadLine();
                    while(line != null)
                    {
                        double liter = double.Parse(line);
                        liters.Add(liter);
                        line = reader.ReadLine();
                    }
                }
            }
            return liters;
        }

        public override Statistics GetStatistics(string fileName)
        {
            var litersFromFile = this.GetLitersFromFile(fileName);
            var statistics = new Statistics();
            
            foreach(var liter in litersFromFile)
            {
                statistics.AddLiters(liter);
            }
            return statistics;
        }
    }
}
