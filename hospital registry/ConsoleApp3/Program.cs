using System;
using main_ns;

namespace hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adinizi daxil edin: ");
            string name = Console.ReadLine();
            Console.WriteLine(name+" xos gelmisiniz");
            Console.WriteLine("Xestexananin sobeleri: ");
            Doctors.Doctor();
            Console.Write("Sobeni secin: ");
            byte doctor_type = Convert.ToByte(Console.ReadLine());
            Names.DoctorNames(doctor_type);
            Console.Write("hekim secin: ");
            byte doctor_number = Convert.ToByte(Console.ReadLine());
            work_time.Time(doctor_number);
            Console.Write("Registrasiya vaxtini daxil edin: ");
            string registyr_number = Console.ReadLine();
            Check.check(registyr_number);
            Console.ReadLine();
        }
    }
}