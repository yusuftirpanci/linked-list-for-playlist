using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubPlayer
{ 
    class Program
    { 
        static void Main(string[] args)                                                                                
        { 
            var rap = CreateList();
            var pop = CreateList();
            AddPostItem(pop,"AlperenYurtseven");
            AddPostItem(pop, "AlperenOnal");
            AddPostItem(pop, "ZArdaTasyurek");
            AddPostItem(pop, "YusufTirpanci");
            PrintList(pop);
            Console.WriteLine(ListLenght(pop).ToString());
            pop=sortItems(pop);
            PrintList(pop);
    
        } 
        //  10 5 8  9
        static Node CreateList()
        {
            Node root = new Node();
            root.data = "First Node";
            root.prev = null;
            root.next = null;
            return root;
        }
        static void AddPostItem(Node node,string data)
        {
            Node n = new Node();
            Node tempRoot = node;
            if (tempRoot.next == null)
            {
                tempRoot.next = n;
                tempRoot.prev = n;
                n.prev = tempRoot;
                n.next = tempRoot;
                n.data = data;

                return;
            }
            while (node.next != tempRoot)
            {
                node = node.next;
            }
          
            node.next = n;
            n.prev = node;
            n.data = data;
            n.next = tempRoot;
            tempRoot.prev = n;
        }
       static void PrintList(Node n)
        {
            var popRoot = n;
            do
            {
                Console.WriteLine(n.data);
                n = n.next;
            }
            while (n != popRoot);
        }
        static int ListLenght(Node n)
        {
            var popRoot = n;
            int counter = 0;
            do
            {
                counter++;
                n = n.next;
            }
            while (n != popRoot);

            return counter;
        }

        static Node SwapNodes(Node first, Node second)
        {
            Node tempNext = second.next;
            Node tempPrev = second.prev;

            second.next = first.next;
            second.prev = first.prev;
            first.next = tempNext;
            first.prev = tempPrev;
           
            return second;
        }
       
        static Node sortItems(Node n)
        {
            Node temp;
            int i, j;
            bool swapped;

            for (i = 0; i <= ListLenght(n); i++)
            {

                temp = n;
                swapped = false;
                for (j = 0; j < ListLenght(n) - i - 1; j++)
                {

                    Node n1 = temp;
                    Node n2 = n1.next;
                    byte[] bytes_n1 = Encoding.ASCII.GetBytes(n1.data);
                    byte[] bytes_n2 = Encoding.ASCII.GetBytes(n2.data);

                    if (bytes_n1[j] > bytes_n2[j])
                    {
                        temp = SwapNodes(n1, n2);
                        swapped = true;
                    }
                    if(bytes_n1[i] == bytes_n2[i])
                    {

                    }
                    if(bytes_n1[i] < bytes_n2[i])
                    {
                        break;
                    }

                    temp = temp.next;
                }
                if (swapped) break;
            }



            return n;
        }

    }
}
