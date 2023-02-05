using System;

namespace HierarchicalInheritence
{
    public class Main
    {
        public int Id { get; set; }

        public void Functionality()
        {
            Console.WriteLine("main method is nothing life is to short");
        }
    }

    public class Sub: Main
    {
        public int SubId { get; set; }

        public void SubFunctionality()
        {
            Console.WriteLine("functionality");
        }
    }

    public class SubMain : Main
    {
        public int SubMainId { get; set; }

        public void SubMainFunctionality()
        {
            Console.WriteLine("functionality");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sub obj = new Sub();
            obj.Functionality();

            SubMain objnew = new SubMain();
            objnew.SubMainId = 8;
        }
    }
}
