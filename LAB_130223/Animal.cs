using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_130223
{
    internal class Animal
    {
        public string Name { get; set; }
        public string Characteristics { get; set; }

        public Animal(string name, string characteristics)
        {
            Name = name;
            Characteristics = characteristics;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes a sound.");
        }

        public virtual string GetInformation()
        {
            return $"Name: {Name}\nCharacteristics: {Characteristics}";
        }
    }

    internal class Tiger : Animal
    {
        public int Stripes { get; set; }

        public Tiger(string name, int stripes) : base(name, "Striped and predatory")
        {
            Stripes = stripes;
        }

        public override void MakeSound()
        {
            Console.WriteLine("The tiger roars.");
        }

        public override string GetInformation()
        {
            return $"{base.GetInformation()}\nStripes: {Stripes}";
        }
    }

    internal class Crocodile : Animal
    {
        public bool Saltwater { get; set; }

        public Crocodile(string name, bool saltwater) : base(name, "Reptile with large jaws")
        {
            Saltwater = saltwater;
        }

        public override void MakeSound()
        {
            Console.WriteLine("The crocodile hisses.");
        }

        public override string GetInformation()
        {
            return $"{base.GetInformation()}\nSaltwater: {Saltwater}";
        }
    }

    internal class Kangaroo : Animal
    {
        public bool Pouch { get; set; }

        public Kangaroo(string name, bool pouch) : base(name, "Marsupial with powerful hind legs")
        {
            Pouch = pouch;
        }

        public override void MakeSound()
        {
            Console.WriteLine("The kangaroo growls.");
        }

        public override string GetInformation()
        {
            return $"{base.GetInformation()}\nPouch: {Pouch}";
        }
    }
}
