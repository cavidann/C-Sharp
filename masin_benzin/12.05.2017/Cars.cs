using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._05._2017
{
    class Cars
    {
        private double localDistance;
        private double globalDistance;
        private double fuelUsage=10;
        private int fuelCapacity=900;
        public double fuelCurrent=0;

        public double LocalDistance
        {
            set
            {
                this.localDistance = value;
            }
            get
            {
                return this.localDistance;
            }
        }
        
        public double GlobalDistance
        {
            get
            {
                return this.globalDistance;
            }
        }

        public double FuelUsage
        {
            set
            {
                this.fuelUsage = value;
            }
            get
            {
                return this.fuelUsage;
            }
        }

        public int FuelCapacity
        {
            get
            {
                return this.fuelCapacity;
            }
        }


        /// <summary>
        ///  Yoxlayirki bakda olan benzin-e elave olundugu halda bak movcudlugunda cox olur mu olmayirmi
        /// </summary>
        /// <param name="litr">Ne qeder benzin elave edilmek istendiyi gonedrilecek</param>
        /// <returns></returns>
        public bool checkFuelAviable(double litr)
        {
            if (this.fuelCurrent + litr <= this.FuelCapacity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Baka benzin elave edir
        /// </summary>
        /// <param name="litr">Elave edilecek benzin miqdari</param>
        /// <returns></returns>
        public bool addFuel(double litr)
        {
            if (this.checkFuelAviable(litr))
            {
                this.fuelCurrent += litr;
                Console.WriteLine("dolduruldu");
                return true;
            }
            else
            {
                Console.WriteLine("hecmi coxdur");
                return false;
            }
        }

        
        public double possibleDistance()
        {
           
                return (fuelCurrent) / this.FuelUsage;            
        }
        /// <summary>
        ///  Girilen km gedib gede bilmeyeyeceni tapan funksiya 
        /// </summary>
        /// <param name="km"></param>
        /// <returns></returns>
        public bool checkDistance(double km)
        {
            if (this.possibleDistance() >= km)
            {
                Console.WriteLine("gede biler");
                this.LocalDistance += km;
                this.globalDistance += km;
                fuelCurrent = fuelCurrent - fuelUsage * km;
                return true;
               
            }
            else
            {
                Console.WriteLine("gede bilmez");
                return false;
            }
            
        }

    }
}
