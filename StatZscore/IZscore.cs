using System;
using System.Collections.Generic;
using System.Text;

namespace StatZscore
{
  public  interface IZscore
    {
        public double ZScore(dynamic score, dynamic values);
    }
}
