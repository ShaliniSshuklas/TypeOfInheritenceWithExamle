using System;

namespace MultipleInheritence
{
    public class Parents
    {
        public int ParentsId { get; set; }
    }

    public class SubParents
    {
        public int SubParentsId { get; set; }
    }

    public class ThirdParents : Parents, SubParents
    {

    }
    /// <summary>
    /// /To OverCome this we make interface.......
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
