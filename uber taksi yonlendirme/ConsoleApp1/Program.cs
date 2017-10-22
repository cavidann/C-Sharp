using System;
using System.Collections.Generic;
using System.Text;
using Taxi_ns;
using Person_ns;
using Operator_ns;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            Taxi taxi = new Taxi("90-Az-123",900,120);

            Console.WriteLine("Taxi number: "+taxi.createTaxi()[0]+"  "+"\nTaxi Coordinates: "+taxi.createCoorX()[0]+"  "+taxi.createCoorY()[0]+"\n----------------------------");
            Taxi taxi1 = new Taxi("90-Az-473", 900, 820);
            Console.WriteLine("Taxi number: " + taxi1.createTaxi()[0] + "  " + "\nTaxi Coordinates: " + taxi1.createCoorX()[0] + "  " + taxi1.createCoorY()[0] + "\n----------------------------");
            Taxi taxi2 = new Taxi("90-Az-349", 191, 0);
            Console.WriteLine("Taxi number: " + taxi2.createTaxi()[0] + "  " + "\nTaxi Coordinates: " + taxi2.createCoorX()[0] + "  " + taxi2.createCoorY()[0] + "\n----------------------------");
            


            List<Taxi> taxiList = new List<Taxi>();
            taxiList.Add(taxi);
            taxiList.Add(taxi1);
            taxiList.Add(taxi2);

            Person person = new Person("husey",100,0,0,0);
            Console.WriteLine("Person name: " + person.createPerson()[0] + "  " + "\nPerson First Coordinates: " + person.createCoorX()[0] + "  " + person.createCoorY()[0]  +"\nPerson Last Coordinates: " + person.createCoorX1()[0] + "  " + person.createCoorY1()[0] + "\n----------------------------");
            
            Operator operator1 = new Operator(person, taxiList);
            
            Console.WriteLine("Hormetli "+ person.createPerson()[0]+ " bey Taksiniz "+operator1.taxiTime()+ "  deqiqeye adresinizde olacaq, qeyd etdiyiniz adrese catma vatxiniz "+ operator1.persontime() + " deqiqedir ve gedis haqqiniz "+ operator1.money()+ " AZN olacaqdir. \nBizi secdiyiniz ucun tesekkur edirik");
            Console.ReadLine();
        }
        
    }
}