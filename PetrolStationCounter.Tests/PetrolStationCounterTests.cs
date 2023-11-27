using PetrolStationCounter;

namespace PetrolStationCounter.Tests
{
    public class PetrolStationCounterTests
    {

        [Test]
        public void WhenAddLitersToPetrol95List_ReturnCorrectSum()
        {
            var petrolStation = new PetrolStationInMemory("BP", "Kraków");
            string petrolType = "petrol95";


            petrolStation.AddLiters(3, petrolType);
            petrolStation.AddLiters(10, petrolType);
            petrolStation.AddLiters("5", petrolType);

            var statistics = petrolStation.GetStatistics(petrolType);

            Assert.AreEqual(18, statistics.Sum);
        }

        [Test]
        public void WhenAddLitersToPetrol95List_ReturnCorrectCount()
        {
            var petrolStation = new PetrolStationInMemory("BP", "Kraków");
            string petrolType = "petrol95";


            petrolStation.AddLiters(3, petrolType);
            petrolStation.AddLiters(10, petrolType);
            petrolStation.AddLiters("5", petrolType);

            var statistics = petrolStation.GetStatistics(petrolType);

            Assert.AreEqual(3, statistics.Count);
        }

        [Test]
        public void WhenAddLitersToPetrol95List_ReturnCorrectMinAndMax()
        {
            var petrolStation = new PetrolStationInMemory("BP", "Kraków");
            string petrolType = "petrol95";


            petrolStation.AddLiters(3, petrolType);
            petrolStation.AddLiters(10, petrolType);
            petrolStation.AddLiters("5", petrolType);

            var statistics = petrolStation.GetStatistics(petrolType);

            Assert.AreEqual(3, statistics.Min);
            Assert.AreEqual(10, statistics.Max);
        }

        [Test]
        public void WhenAddLitersToPetrol95List_ReturnCorrectAverage()
        {
            var petrolStation = new PetrolStationInMemory("BP", "Kraków");
            string petrolType = "petrol95";


            petrolStation.AddLiters(3, petrolType);
            petrolStation.AddLiters(10, petrolType);
            petrolStation.AddLiters("5", petrolType);

            var statistics = petrolStation.GetStatistics(petrolType);

            Assert.AreEqual(6, statistics.Average);
        }

        [Test]
        public void WhenAddLitersToPetrol98List_ReturnCorrectSum()
        {
            var petrolStation = new PetrolStationInMemory("BP", "Kraków");
            string petrolType = "petrol98";


            petrolStation.AddLiters(3, petrolType);
            petrolStation.AddLiters(10, petrolType);
            petrolStation.AddLiters("5", petrolType);

            var statistics = petrolStation.GetStatistics(petrolType);

            Assert.AreEqual(18, statistics.Sum);
        }

        [Test]
        public void WhenAddLitersToPetrol98List_ReturnCorrectCount()
        {
            var petrolStation = new PetrolStationInMemory("BP", "Kraków");
            string petrolType = "petrol98";


            petrolStation.AddLiters(3, petrolType);
            petrolStation.AddLiters(10, petrolType);
            petrolStation.AddLiters("5", petrolType);

            var statistics = petrolStation.GetStatistics(petrolType);

            Assert.AreEqual(3, statistics.Count);
        }

        [Test]
        public void WhenAddLitersToPetrol98List_ReturnCorrectMinAndMax()
        {
            var petrolStation = new PetrolStationInMemory("BP", "Kraków");
            string petrolType = "petrol98";


            petrolStation.AddLiters(3, petrolType);
            petrolStation.AddLiters(10, petrolType);
            petrolStation.AddLiters("5", petrolType);

            var statistics = petrolStation.GetStatistics(petrolType);

            Assert.AreEqual(3, statistics.Min);
            Assert.AreEqual(10, statistics.Max);
        }

        [Test]
        public void WhenAddLitersToPetrol98List_ReturnCorrectAverage()
        {
            var petrolStation = new PetrolStationInMemory("BP", "Kraków");
            string petrolType = "petrol98";


            petrolStation.AddLiters(3, petrolType);
            petrolStation.AddLiters(10, petrolType);
            petrolStation.AddLiters("5", petrolType);

            var statistics = petrolStation.GetStatistics(petrolType);

            Assert.AreEqual(6, statistics.Average);
        }

        [Test]
        public void WhenAddLitersToDieselFuelList_ReturnCorrectSum()
        {
            var petrolStation = new PetrolStationInMemory("BP", "Kraków");
            string petrolType = "dieselFuel";


            petrolStation.AddLiters(3, petrolType);
            petrolStation.AddLiters(10, petrolType);
            petrolStation.AddLiters("5", petrolType);

            var statistics = petrolStation.GetStatistics(petrolType);

            Assert.AreEqual(18, statistics.Sum);
        }

        [Test]
        public void WhenAddLitersToDieselFuelList_ReturnCorrectCount()
        {
            var petrolStation = new PetrolStationInMemory("BP", "Kraków");
            string petrolType = "dieselFuel";


            petrolStation.AddLiters(3, petrolType);
            petrolStation.AddLiters(10, petrolType);
            petrolStation.AddLiters("5", petrolType);

            var statistics = petrolStation.GetStatistics(petrolType);

            Assert.AreEqual(3, statistics.Count);
        }

        [Test]
        public void WhenAddLitersToDieselFuelList_ReturnCorrectMinAndMax()
        {
            var petrolStation = new PetrolStationInMemory("BP", "Kraków");
            string petrolType = "dieselFuel";


            petrolStation.AddLiters(3, petrolType);
            petrolStation.AddLiters(10, petrolType);
            petrolStation.AddLiters("5", petrolType);

            var statistics = petrolStation.GetStatistics(petrolType);

            Assert.AreEqual(3, statistics.Min);
            Assert.AreEqual(10, statistics.Max);
        }

        [Test]
        public void WhenAddLitersToDieselFuelList_ReturnCorrectAverage()
        {
            var petrolStation = new PetrolStationInMemory("BP", "Kraków");
            string petrolType = "dieselFuel";


            petrolStation.AddLiters(3, petrolType);
            petrolStation.AddLiters(10, petrolType);
            petrolStation.AddLiters("5", petrolType);

            var statistics = petrolStation.GetStatistics(petrolType);

            Assert.AreEqual(6, statistics.Average);
        }

        [Test]
        public void WhenAddLitersToDieselUltimateFuelList_ReturnCorrectSum()
        {
            var petrolStation = new PetrolStationInMemory("BP", "Kraków");
            string petrolType = "dieselUltimateFuel";


            petrolStation.AddLiters(3, petrolType);
            petrolStation.AddLiters(10, petrolType);
            petrolStation.AddLiters("5", petrolType);

            var statistics = petrolStation.GetStatistics(petrolType);

            Assert.AreEqual(18, statistics.Sum);
        }

        [Test]
        public void WhenAddLitersToDieselUltimateFuelList_ReturnCorrectCount()
        {
            var petrolStation = new PetrolStationInMemory("BP", "Kraków");
            string petrolType = "dieselUltimateFuel";


            petrolStation.AddLiters(3, petrolType);
            petrolStation.AddLiters(10, petrolType);
            petrolStation.AddLiters("5", petrolType);

            var statistics = petrolStation.GetStatistics(petrolType);

            Assert.AreEqual(3, statistics.Count);
        }

        [Test]
        public void WhenAddLitersToDieselUltimateFuelList_ReturnCorrectMinAndMax()
        {
            var petrolStation = new PetrolStationInMemory("BP", "Kraków");
            string petrolType = "dieselUltimateFuel";


            petrolStation.AddLiters(3, petrolType);
            petrolStation.AddLiters(10, petrolType);
            petrolStation.AddLiters("5", petrolType);

            var statistics = petrolStation.GetStatistics(petrolType);

            Assert.AreEqual(3, statistics.Min);
            Assert.AreEqual(10, statistics.Max);
        }

        [Test]
        public void WhenAddLitersToDieselUltimateFuelList_ReturnCorrectAverage()
        {
            var petrolStation = new PetrolStationInMemory("BP", "Kraków");
            string petrolType = "dieselUltimateFuel";


            petrolStation.AddLiters(3, petrolType);
            petrolStation.AddLiters(10, petrolType);
            petrolStation.AddLiters("5", petrolType);

            var statistics = petrolStation.GetStatistics(petrolType);

            Assert.AreEqual(6, statistics.Average);
        }
    }
}
