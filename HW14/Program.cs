using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW14
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    abstract class Animal
    {
        public abstract string Name { get; set; }
        public Animal (string name)
        {
            Name = name;
        }
        public abstract void Say();
        public void ShowInfo()
        {
            Console.Write(Name);
            Say();
        }
    }
    class Cat: Animal
    {
        string name;
        public Cat (string name)
            :base (name)
        {

        }
        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public void ShowInfo()
        {
            Console.Write(Name);
            Say();
        }
    }
    class Dog : Animal
    {
        string name;
        public Dog (string name)
            : base(name)
        {

        }
        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public void ShowInfo()
        {
            Console.Write(Name);
            Say();
        }
    }
}
