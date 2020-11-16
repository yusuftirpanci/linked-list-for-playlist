using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubPlayer
{
    class Program
    {
        static int[] array = {
            8,23,16,46,82,-31,0,-62,15 };
        static void Main(string[] args)                                                                                
        { 
            var rap = CreateList();
            var pop = CreateList();
            AddPostItem(pop,"AlperenYurtseven");
            AddPostItem(pop, "AlperenOnal");
            AddPostItem(pop, "ZArdaTasyurek");
            AddPostItem(pop, "YusufTirpanci");
            sortItems(array);
    
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

       
       
        static void sortItems(int[] dizi)
        {
            int counter=0;
            int enkucuk=dizi[counter];
            int temp=0;

            for (int i = 0; i < dizi.Length; i++) //Algoritma ile diziyi baştan sonra okuyup en küçüğünü bulup 1. indise yerleştir.Daha sonra 2.indisi bulup 
            {
                

                for (int j = i; j < dizi.Length; j++)
                {
                  
                    if (dizi[j] < enkucuk)
                    {
                        enkucuk = dizi[j];
                        temp = dizi[i];
                        dizi[i] = enkucuk;
                        dizi[j] = temp;
                    }
                }
                counter++;
                if (counter==dizi.Length)
                {
                    break;
                }
                enkucuk = dizi[counter];
                
            }
            
            foreach (var item in dizi)
            {
                Console.Write(item);
                Console.Write(",");
            }

        }

    }
}
