using SchoolApp.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    class School
    {
        private SchoolDatabaseContext schoolDatabaseContext = new SchoolDatabaseContext();

        public void Run()
        {
            while(true)
            {
                ShowMenu();

                int chosenOption = GetOption();


            }
        }

        private int GetOption()
        {
            int option;

            //Console.WriteLine("Wybierz opcję:");
            //option = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Wybierz opcję:");
            } while (!int.TryParse(Console.ReadLine(), out option));

            return option;
        }

        private void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Wybierz opcje:");
            Console.WriteLine("1.  ");

            Console.WriteLine("0. Koniec programu");
        }
    }
}
