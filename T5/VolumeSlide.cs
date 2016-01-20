using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    class VolumeSlide
    {
        private readonly int maxVolume = 9;
        private readonly int minVolume = 0;

        private int volume;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value <= maxVolume)
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

    }
}
