using System;
using System.ComponentModel.DataAnnotations;

namespace OblFootballPlayer
{
    public class FootballPlayer
    {
        private int _id;
        private string _name;
        private int _price;
        private int _shirtNumber;

        public FootballPlayer(int id, string name, int price, int shirtNumber)
        {
            _id = id;
            _name = name;
            _price = price;
            _shirtNumber = shirtNumber;
        }

        public FootballPlayer()
        {

        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 4) throw new ArgumentOutOfRangeException();
                _name = value;
            }
        }

        public int Price
        {
            get => _price;
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException();
                _price = value;
            }
        }

        public int ShirtNumber
        {
            get => _shirtNumber;
            set
            {
                if (value < 1 || value > 100) throw new ArgumentOutOfRangeException();
                _shirtNumber = value;
            }
        }

        public override string ToString()
        {
            return $"ID: {Id}, Navn: {Name}, Pris: {Price}, Trøje nummer: {ShirtNumber}";
        }
    }
}
