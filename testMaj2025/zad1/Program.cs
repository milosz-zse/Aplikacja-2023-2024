// See https://aka.ms/new-console-template for more information
using System.Net;
using System.Reflection.PortableExecutable;

public class Devices
{
    public void WyswietlKomunikat(string komunikat)
    {
        Console.WriteLine("Komunikat: " + komunikat);
    }


}
public class WashingMachine : Devices
{
        private int numProgWashing = 0;

        public void SetWashingProgram(int programNumber)
        {

            if (programNumber >= 1 && programNumber <= 12)
            {
                numProgWashing = programNumber;
            }
            else
            {
                numProgWashing = 0;
            }
        }
    }
    public class vacuumCleaner: Devices
{
        private bool VacuumCleanerStatus = true;

        public void on()
        {
            if (!VacuumCleanerStatus)
            {
                VacuumCleanerStatus = true;
                WyswietlKomunikat("odkurzacz wlaczono");
            }



        }
        public void off()
        {
            if (!VacuumCleanerStatus)
            {
                VacuumCleanerStatus = true;
                WyswietlKomunikat("odkurzacz wylaczono");
            }



        }
    }



public class Program
{
    public static void Main()
    {
        WashingMachine pralka1 = new WashingMachine();
        WashingMachine pralka2 = new WashingMachine();


        vacuumCleaner odkurzacz1 = new vacuumCleaner();
        vacuumCleaner odkurzacz2 = new vacuumCleaner();

        
        pralka1.SetWashingProgram(4);
        pralka2.SetWashingProgram(8);

        odkurzacz1.on();
        odkurzacz1.on();

        odkurzacz2.on();
        odkurzacz1.off();
    }
}


