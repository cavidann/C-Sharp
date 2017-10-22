using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using hospital;
using main_ns;

namespace main_ns
{
    class Doctors
    {
        public static void Doctor()
        {           
            Dictionary<byte, string> doctor_types = new Dictionary<byte, string>();
            doctor_types.Add(1, "Audiologist");
            doctor_types.Add(2, "Allergist");
            doctor_types.Add(3, "Anesthesiologist");
            foreach (KeyValuePair<byte, string> item in doctor_types)
            {
                Console.WriteLine(item.Key+". "+item.Value);
            }
        }        
    }
    class Names
    {
        public static void DoctorNames(byte number)
        {
            Dictionary<byte, string> doctor_names = new Dictionary<byte, string>();
           
            doctor_names.Add(1, "Traktor");
            doctor_names.Add(2, "Eli");
            Dictionary<byte, string> doctor_names1 = new Dictionary<byte, string>();
          
            doctor_names1.Add(1, "Veli");
            doctor_names1.Add(2, "Minaye");
            Dictionary<byte, string> doctor_names2 = new Dictionary<byte, string>();
            
            doctor_names2.Add(1, "Zerife");
            doctor_names2.Add(2, "Adel");
            switch (number)
            {
                case 1:
                    Console.WriteLine("Audiologist sobesinin hekimleri");
                    foreach (KeyValuePair<byte, string> item in doctor_names)
                    {
                        Console.WriteLine(item.Key + ". " + item.Value);
                    }
                    break;
                case 2:
                    Console.WriteLine("Allergist sobesinin hekimleri");
                    foreach (KeyValuePair<byte, string> item in doctor_names1)
                    {
                        Console.WriteLine(item.Key + ". " + item.Value);
                    }
                    break;
                case 3:
                    Console.WriteLine("Anesthesiologist sobesinin hekimleri");
                    foreach (KeyValuePair<byte, string> item in doctor_names2)
                    {
                        Console.WriteLine(item.Key + ". " + item.Value);
                    }
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
   class work_time
    {
        public static Dictionary<string, string> doctor_time = new Dictionary<string, string>();
        public static void Time(byte doc)
        {
            if (doc<=2)
            {
               
                doctor_time.Add( "8:00-10:00","full");
                doctor_time.Add( "10:00-12:00","full");
                doctor_time.Add("12:00-14:00","empty");
                doctor_time.Add( "14:00-16:00", "empty");
                doctor_time.Add( "16:00-18:00", "empty");
                //int i=0;
                foreach (KeyValuePair<string, string> item in doctor_time)
                {
                    //i++;
                    //Console.Write("\t" + i+". ");
                    Console.WriteLine(item.Key + ". " + item.Value+"\n");
                }
              
                   
                }
            
            else
            {
                Console.WriteLine("error");
            }
           
        }
    }
    class Check
    {
        public static void check(string num)
        {
            if (work_time.doctor_time[num]=="full")
            {
                Console.WriteLine("Yer doludur!");
            }
            else
            {
                Console.WriteLine("Registrasiya olundu");
            }         
                
            
            
        }
    }
}
