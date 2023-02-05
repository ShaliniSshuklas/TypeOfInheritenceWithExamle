using System;

namespace SingleLevelInheritence
{
    public class Animal
    {
        public int MyProperty { get; set; }

        protected void Sleep()
        {
            Console.WriteLine("all animal sleep.");
        }
    }

    public class Dog : Animal
    {
        public int count { get; set; }

        public void Functionality()
        {
            this.Sleep();
            base.Sleep();
            Dog dog = new Dog();
            dog.Sleep();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog obj = new Dog();
            obj.Functionality();
        }
    }
}
