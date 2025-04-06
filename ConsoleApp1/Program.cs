namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                // Get username from command line argument
                string username = args[0];

                string output = HelloLibrary.HelloHelper.GetHello(username);


                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("Please provide a username as a command line argument.");
            }

        }
    }
}
