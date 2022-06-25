using ClassLibrary;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassHello hello = new ClassHello();
            string message = hello.GetMessage();
            System.Console.WriteLine(message);
        }
    }
}
