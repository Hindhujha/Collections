using System;
namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO COLLECTIONS");
            Console.WriteLine("CREATING A LIST OF NAMES");
            List();
        }

        private  static void List()
        {
            List<string> list = new List<string>();
            list.Add("HINDHUJHA");
            list.Add("SRIDHAR");
            list.Add("ANITA");
            list.Add("RONI");

            foreach(var element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}
