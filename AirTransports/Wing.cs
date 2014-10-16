using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transports.AirTransports
{
    public class Wing
    {
        private int length;
        private int heigth;
 
        public Wing(int length, int height)
        {
            Length = length;
            Heigth = height;
        }

        public Wing()
        {
            Length = 100;
            Heigth = 2;
        }

        public int Length
        {
            get { return length; }
            set
            {
                if (value < 1) throw new ArgumentException("length must be positive");
                length = value;
            }
        }

        public int Heigth
        {
            get { return heigth; }
            set
            {
                if (value < 1)
                    throw new ArgumentException("Heigth must be positive");
                heigth = value;
            }
        }
    }
}
