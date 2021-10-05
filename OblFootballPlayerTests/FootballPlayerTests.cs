using Microsoft.VisualStudio.TestTools.UnitTesting;
using OblFootballPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OblFootballPlayer.Tests
{
    [TestClass()]
    public class FootballPlayerTests
    {
        private FootballPlayer _footballPlayer;
        [TestInitialize]
        public void BeforeTest()
        {
            _footballPlayer = new FootballPlayer(1, "Bob", 1000, 5);
        }

        [TestMethod()]
        public void NameTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => _footballPlayer.Name = "Bob");

            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => _footballPlayer.Name = "");

            _footballPlayer.Name = "Jens";
            Assert.AreEqual("Jens", _footballPlayer.Name);

            _footballPlayer.Name = "Asmus";
            Assert.AreEqual("Asmus", _footballPlayer.Name);
        }

        [TestMethod()]
        public void PriceTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => _footballPlayer.Price = 0);

            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => _footballPlayer.Price = -1);

            _footballPlayer.Price = 1;
            Assert.AreEqual(1, _footballPlayer.Price);

            _footballPlayer.Price = 1000;
            Assert.AreEqual(1000, _footballPlayer.Price);
        }

        [TestMethod()]
        public void ShirtNumberTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => _footballPlayer.ShirtNumber = 0);

            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => _footballPlayer.ShirtNumber = 101);

            _footballPlayer.ShirtNumber = 1;
            Assert.AreEqual(1, _footballPlayer.ShirtNumber);

            _footballPlayer.ShirtNumber = 50;
            Assert.AreEqual(50, _footballPlayer.ShirtNumber);

            _footballPlayer.ShirtNumber = 100;
            Assert.AreEqual(100, _footballPlayer.ShirtNumber);
        }
    }
}