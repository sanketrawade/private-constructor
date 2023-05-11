namespace private_constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This line raises error because
            // the constructor is inaccessible
            //Geeks obj1 = new Geeks();

            //Here, the only default
            //  constructor will invoke
            Geeks obj2 = new Geeks("Ankita", 2);

            //Here, the data members of Geeks
            //class are directly accessed
            //because they are static members
            //and static members are accessed
            //directly with the class name
            Console.WriteLine(Geeks.name + ", " + Geeks.num);

            //singleton pattern implmentation
            //var geeks = Geeks.GetInstance();
            //var geeks2 = Geeks.GetInstance();
            //if (geeks == geeks2)
            //{
            //    Console.WriteLine("Two Objects are same.");
            //}
            //else
            //{
            //    Console.WriteLine("Two Objects are not same.");
            //}

        }
    }

    public class Geeks
    {
        // Variables
        public static string name;
        public static int num;

        // Creating private Constructor
        // using private keyword
        private Geeks()
        {
            Console.WriteLine("Welcome to Private Constructor");
        }

        // Default Constructor
        // with parameters
        public Geeks(string a, int b)
        {

            name = a;
            num = b;
        }
    }

    //singleton pattern implmentation

    //public sealed class Geeks
    //{
    //    private Geeks() { }

    //    private static Geeks? instance;
    //    public static Geeks GetInstance()
    //    {
    //        if (instance == null)
    //            instance = new Geeks();
    //        return instance;
    //    }
    //}
}