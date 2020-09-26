using System;
using System.Collections.Generic;
using System.Text;

namespace domantas.kernagis
{
    class building
    {
        private int floorNumber; //tells the number of floors in a building

        public building(int _floorNumber)
        {
            FloorNumber = _floorNumber;
        }

        public int FloorNumber
        {
            get { return floorNumber; }
            set
            {
                if (value < 101)
                    floorNumber = value;
                else
                    floorNumber = 100;
            }
        }
    }
}
