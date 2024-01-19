using System;

namespace Notenrechner
{
    internal class Program
    {
        public
            
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine(today);
            Console.WriteLine("Notenrechner");

           double Note1;
           double Note2;
           double Note3;
           double Note4;
           double Note5;
           double Note6;
           double Note7;
           double Note8;

            Console.WriteLine("Bitte geben Sie Ihre Noten ein:");
            Console.WriteLine("Note 1:");
            Console.ReadLine();
          Note1 =  Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Bitte geben Sie Ihre Noten ein:");
            Console.WriteLine("Note 2:");
            Console.ReadLine();
            Note2= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Bitte geben Sie Ihre Noten ein:");
            Console.WriteLine("Note 3:");
            Console.ReadLine();
            Note3= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Bitte geben Sie Ihre Noten ein:");
            Console.WriteLine("Note 4:");
            Console.ReadLine();
            Note4= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Bitte geben Sie Ihre Noten ein:");
            Console.WriteLine("Note 4:");
            Console.ReadLine();
            Note5= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Bitte geben Sie Ihre Noten ein:");
            Console.WriteLine("Note 5");
            Console.ReadLine();
            Note6= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Bitte geben Sie Ihre Noten ein:");
            Console.WriteLine("Note 6");
            Console.ReadLine();
            Note7= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Bitte geben Sie Ihre Noten ein:");
            Console.WriteLine("Note ");
            Console.ReadLine();
            Note8= Convert.ToDouble(Console.ReadLine());

      

            double Durchschnitt = (Note1 + Note2 + Note3 + Note4 + Note5 + Note6 + Note7 + Note8) / 8;
            Console.WriteLine("Ihr Durchschnitt ist: " + Durchschnitt);










        }
    }
}