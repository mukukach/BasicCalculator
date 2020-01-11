using System;
using System.Collections.Generic;
using System.Text;

namespace Operations
{
  public  class Randomizer
    {
        private readonly Random rand = new Random(0);
        public int GetInt()
        {
            return rand.Next(1, 7);

        }
        public double Getdouble()
        {
            return (rand.Next(180, 759) / 20);
        }
    }
}
