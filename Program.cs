




namespace Notenrechner
{
    internal class Program
    {
        public

        static void Main(string[] args)
        {

            ConsoleColor color = Console.ForegroundColor = ConsoleColor.Cyan; //Farbe wird auf Hellblau gesetzt

            DateTime Heute = DateTime.Now;             //Aktuelles Datum wird ausgegeben
            Console.WriteLine(Heute);
            Console.WriteLine("Notenrechner");

            double Note1;
            double Note2;
            double Note3;                         //Die einzelnen Noten werden als double deklariert
            double Note4;
            double Note5;
            double Note6;
            double Note7;
            double Note8;



            while (true)
            {
                try
                {



                    Console.WriteLine("Bitte geben Sie Ihre Noten ein:");
                    Console.WriteLine("Note 1:");

                    Note1 = Convert.ToDouble(Console.ReadLine());
                   

                    Console.WriteLine("Bitte geben Sie Ihre Noten ein:");
                    Console.WriteLine("Note 2:");

                    Note2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Bitte geben Sie Ihre Noten ein:");
                    Console.WriteLine("Note 3:");

                    Note3 = Convert.ToDouble(Console.ReadLine());
                   
                    Console.WriteLine("Bitte geben Sie Ihre Noten ein:");
                    Console.WriteLine("Note 4:");                                                     // Eingabe der Noten

                    Note4 = Convert.ToDouble(Console.ReadLine());
                   
                    Console.WriteLine("Bitte geben Sie Ihre Noten ein:");
                    Console.WriteLine("Note 5:");

                    Note5 = Convert.ToDouble(Console.ReadLine());
                   
                    Console.WriteLine("Bitte geben Sie Ihre Noten ein:");
                    Console.WriteLine("Note 6");

                    Note6 = Convert.ToDouble(Console.ReadLine());
                   
                    Console.WriteLine("Bitte geben Sie Ihre Noten ein:");
                    Console.WriteLine("Note 7");

                    Note7 = Convert.ToDouble(Console.ReadLine());
                   

                    Console.WriteLine("Bitte geben Sie Ihre Noten ein:");
                    Console.WriteLine("Note 8 ");

                    Note8 = Convert.ToDouble(Console.ReadLine());
                  
                  
                    double Durchschnitt = (Note1 + Note2 + Note3 + Note4 + Note5 + Note6 + Note7 + Note8) / 8;          //Berechnung des Durchschnitts
                    Console.WriteLine("Ihr Durchschnitt ist: " + Durchschnitt);
                
                }

                catch
                {
                    Console.WriteLine("Bitte geben Sie eine Zahl ein!");
                }


            }


        }
    }

}
