namespace Interface1
{



    interface IEmployee
    {
        void show();

    }
    class partTimeEmployees : IEmployee
    {
        public void show()
        {
            Console.WriteLine("this is amethod of  IEmployee interface");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            partTimeEmployees pte = new partTimeEmployees();
            pte.show();
            Console.ReadLine();
        }
    }
}