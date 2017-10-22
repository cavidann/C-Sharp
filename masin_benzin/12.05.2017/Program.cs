using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _12._05._2017;

namespace _12._05._2017
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars mycar = new Cars();
       

            Console.WriteLine("\t\t\t\t 1. Masini sur\n\t\t\t\t 2. Benzin doldur\n\t\t\t\t 3. Local Distance\n\t\t\t\t 4. Global Distance\n\t\t\t\t 5. Exit");

            int selection = 0;
            int distance = 0;
            int fuel = 0;
            do
            {
                Console.WriteLine("bakda "+ mycar.fuelCurrent+" litr benzin var");
                selection = Convert.ToInt32(Console.ReadLine());
                switch (selection)
                {
                    case 1:                        
                        Console.Write("getmek istediyiniz mesafeni daxil edin: ");
                        distance = Convert.ToInt32(Console.ReadLine());
                        mycar.checkDistance(distance);
                     
                           // mycar.ascGlobalDistance(distance);
                            //mycar.ascLocalDistance(distance);
                       



                       
                        break;
                    case 2:                      
                        Console.Write("Elave etmek istediyiniz yanacaq miqdarini daxil edin: ");
                        fuel = Convert.ToInt32(Console.ReadLine());
                        mycar.addFuel(fuel);
                        //Console.WriteLine("bakda " + mycar.fuelCurrent + " litr benzin var");
                        break;
                    case 3:
                        Console.WriteLine("Local mesafe "+mycar.LocalDistance+" kilometrdirdir");
                        Console.WriteLine("/t reset? (yes/no)");
                        string reset_local = Convert.ToString(Console.ReadLine());                        
                        if (reset_local=="yes")
                        {
                            Console.WriteLine("reseted");
                            mycar.LocalDistance = 0;
                        }else if (reset_local == "no")
                        {
                            Console.WriteLine("did not reseted");
                        }
                        else
                        {
                            Console.WriteLine("eror");
                        }
                        
                        break;
                    case 4:
                        Console.WriteLine("Global mesafe "+mycar.GlobalDistance+ " kilometrdirdir");                 
                        break;
                    case 5:
                        System.Environment.Exit(0);
                        break;
                    default :
                        Console.WriteLine("error");               
                        break;
                }
            } while (selection != 5);
       }
    }
}
