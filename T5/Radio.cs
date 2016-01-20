using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    class Radio
    {
        public bool IsOn;

        private readonly int maxVolume = 9;
        private readonly int minVolume = 0;

        private readonly double maxStation = 26000.0;
        private readonly double minStation = 2000.0;


        private int volume;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if(value<=maxVolume)
                {
                    if (value >= minVolume) volume = value;
                    else
                    {
                        Console.WriteLine("Volume too low - volume set to min");
                        volume = minVolume;
                    }
                }
                else
                {
                    Console.WriteLine("Volume too high - volume set to max");
                    volume = maxVolume;
                }
            }
        }

        private double station;
        public double Station
        {
            get
            {
                return station;
            }
            set
            {
                if (value <= maxStation)
                {
                    if (value >= minStation) station = value;
                    else
                    {
                        Console.WriteLine("Station too low - station set to " + minStation);
                        station = minStation;
                    }
                }
                else
                {
                    Console.WriteLine("Station too high - station set to " + maxStation);
                    station = maxStation;
                }
            }
        }

        public override string ToString()
        {
            return "\n Radio is on: " + IsOn + "\n Volume is: " + volume + "\n Station is: " + station;
        }
    }
}
