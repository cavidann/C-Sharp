using System;
using System.Collections.Generic;
using System.Text;

namespace Taxi_ns
{
    class Taxi
    {
        string num;
        int CoorX;
        int CoorY;
        public Taxi(string num, int CoorX, int CoorY)
        {
            this.num = num;
            this.CoorX = CoorX;
            this.CoorY = CoorY;
        }
        public List<string> createTaxi()
        {
            List<string> taxiNum = new List<string>();
            taxiNum.Add(this.num);           
            return taxiNum;
        }

        public List<int> createCoorX()
        {
            List<int> taxiCoorX = new List<int>();
            taxiCoorX.Add(CoorX);

            return taxiCoorX;
        }


        public List<int> createCoorY()
        {
            List<int> taxiCoorY = new List<int>();
            taxiCoorY.Add(CoorY);
            return taxiCoorY;
        }
    }
}

