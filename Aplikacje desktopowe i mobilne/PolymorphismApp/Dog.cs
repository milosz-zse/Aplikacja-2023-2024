using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismApp
{

    class Dog : Animal
    {
        public Dog() //: base() - to jest domyslne
        {
            name = "Azor";
        }

        public Dog(string name, byte age) : base(name, age)
        {
        }

        public Dog(Dog dogToCopy): base(dogToCopy)
        {
        }

        public void ShowInfo()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("Pies o imieniu " + name + " ma " + age + " lat");
            Console.WriteLine("***********************");
        }

        public void Bark()
        {
            Console.WriteLine("Pies o imieniu " + name + " szczeka");
        }

        public void ChasePostman()
        {
            Console.WriteLine("Pies o imieniu " + name + " goni listonosza");
        }
    }
}
