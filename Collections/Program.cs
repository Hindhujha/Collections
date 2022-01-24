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
            Console.WriteLine("****************************************");
            Console.WriteLine("CREATING A STACK OF FRUITS");
            Stack();
            Console.WriteLine("****************************************");
            Console.WriteLine("CREATING A DICTIONARY");
            Dictionary();
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

        private static void Stack()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("APPLE");
            stack.Push("ORANGE");
            stack.Push("MANGO");
            stack.Push("PAPAYA");

            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            //pop
            string pop = stack.Pop();
            Console.WriteLine("****************************************");
            Console.WriteLine("AFTER DELETING FIRST ELEMENT BY POP");
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
        }


        private static void Dictionary()
        {
            Dictionary<int,string> dictionary = new Dictionary<int,string>();
            dictionary.Add(1, "RAM");
            dictionary.Add(2, "SITA");
            dictionary.Add(3, "POOJA");

            foreach (var element in dictionary)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("SHOWS FIRST POSITON: " + dictionary[1]);
        }
    }
}
