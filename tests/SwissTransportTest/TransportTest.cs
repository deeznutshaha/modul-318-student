using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SwissTransport
{
    [TestClass]
    public class TransportTest
    {
        private ITransport testee;

        [TestMethod]
        public void Locations()
        {
            testee = new Transport();
            var stations = testee.GetStations("Sursee,");

            Assert.AreEqual(50, stations.StationList.Count);
        }

        [TestMethod]
        public void LocationsWithCoordinates()
        {
            testee = new Transport();
            var stations = testee.GetStations(47.0715826, 8.3470905);
            Assert.AreEqual("Adligenswil, Stuben", stations.StationList[0].Name);
        }

        [TestMethod]
        public void StationBoard()
        {
            testee = new Transport();
            var stationBoard = testee.GetStationBoard("Sursee", "8502007");

            Assert.IsNotNull(stationBoard);
        }

        [TestMethod]
        public void Connections()
        {
            testee = new Transport();
            var connections = testee.GetConnections("Sursee", "Luzern", "2017-05-23", "17:00");

            Assert.IsNotNull(connections);
        }
    }
}
