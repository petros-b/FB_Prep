using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> linked = new LinkedList<string>();
            //add first 3 elem. to string

            linked.AddLast("pet");
            linked.AddLast("ali");
            linked.AddLast("viv");
            linked.AddLast("kenny");

            //insert node b/4 2nd node. So right after the first one

            LinkedListNode<string> node = linked.Find("pet");
            linked.AddAfter(node, "dumb-fuck"); // finds node pet, then adds it AFTER it

            foreach(var value in linked)
            {
                Console.WriteLine(value);
                
            }
            Console.ReadKey();
        }
    }
}