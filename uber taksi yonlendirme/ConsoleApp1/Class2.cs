using System;
using System.Collections.Generic;
using System.Text;
using Taxi_ns;

namespace Person_ns
{
    class Person
    {
       
        public int firstCoorX;
        public int firstCoorY;
        public int lastCoorX;
        public int lastCoorY;
        public string name;

        public Person(string name, int firstCoorX, int firstCoorY, int lastCoorX, int lastCoorY)
        {
            this.firstCoorX= firstCoorX;
            this.firstCoorY= firstCoorY;
            this.lastCoorX= lastCoorX;
            this.lastCoorY= lastCoorY;
            this.name=name;
        } 

        public List<string> createPerson()
        {
            List<string> personName = new List<string>();
            personName.Add(this.name);
            return personName;
        }
        public List<int> createCoorX()
        {
            List<int> personFirstCoorX = new List<int>();
            personFirstCoorX.Add(this.firstCoorX);

            return personFirstCoorX;
        }


        public List<int> createCoorY()
        {
            List<int> personFirstCoorY = new List<int>();
            personFirstCoorY.Add(this.firstCoorY);
            return personFirstCoorY;
        }
        public List<int> createCoorX1()
        {
            List<int> personLastCoorX = new List<int>();
            personLastCoorX.Add(this.lastCoorX);

            return personLastCoorX;
        }


        public List<int> createCoorY1()
        {
            List<int> personLastCoorY = new List<int>();
            personLastCoorY.Add(this.lastCoorY);
            return personLastCoorY;
        }
    }
}
