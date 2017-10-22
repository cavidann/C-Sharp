using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1;
using Taxi_ns;
using Person_ns;
using System.Linq;

namespace Operator_ns
{
    class Operator
    {
        Person personinfo;
        List<Taxi> taxiinfo;
        double taxidistance;
        double persondistance;
        double lastChoiceTaxi;
        public Operator(Person person, List<Taxi> taxiList)
        {
            List<double> bestChoice = new List<double>();
            this.personinfo = person;
            this.persondistance = Math.Round(Math.Sqrt(Math.Pow(this.personinfo.createCoorX()[0] - this.personinfo.createCoorX1()[0], 2) + Math.Pow(this.personinfo.createCoorY()[0] - this.personinfo.createCoorY1()[0], 2)));

            this.taxiinfo = taxiList;
          
            for (int re=0;re< 3; re++ )
            {
                this.taxidistance = Math.Round(Math.Sqrt(Math.Pow(this.taxiinfo[re].createCoorX()[0] - this.personinfo.createCoorX()[0], 2) + Math.Pow(this.taxiinfo[re].createCoorY()[0] - this.personinfo.createCoorY()[0], 2)));
                bestChoice.Add(this.taxidistance);
            }
            double[] min=bestChoice.ToArray();

            lastChoiceTaxi = min.Min();
          //  Console.WriteLine(this.taxiinfo[re].createCoorX()[re].Count);
        }

        public double money()
        {          
           double money = persondistance * 0.2;
           return money;
        }
        double speed = 3;
        public double persontime()
        {            
            double time = Math.Round(persondistance / speed);             
            return time;
        }
        public double taxiTime()
        {
            double time = Math.Round(lastChoiceTaxi / speed);
            return time;
        }
    }
}
