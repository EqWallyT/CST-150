using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone2Item
{
    class Program
    {
        static void Main(string[] args)
        {
            InventoryManager i1 = new InventoryManager();

            int ch;
            //Using the Driver Class to test i1
            Driver d = new Driver();
            d.Test(i1);
            //Then display user interactions
            for (; ; )
            {
                //Console scripting for user intput
                Console.WriteLine("1.........Add item");
                Console.WriteLine("2.........Display item");      
                Console.WriteLine("3.........Exit");


                Console.WriteLine("Enter choice");
                ch = Convert.ToInt32(Console.ReadLine());


                switch (ch)
                {
                    case 1:
                        string n;
                        double p;
                        int q;


                        Console.WriteLine("Enter item name ");
                        n = Console.ReadLine();

                        Console.WriteLine("Enter item price ");
                        p = Convert.ToDouble(Console.ReadLine());


                        Console.WriteLine("Enter item quantity ");
                        q = Convert.ToInt32(Console.ReadLine());
                        i1.addItem(n, p, q);
                        break;
                    case 2:
                        i1.displayItem();
                        break;

                    case 3:
                        Environment.Exit(0);
                        break;

                }

            }

        }
    }
        class InventoryManager
        {
            int count = 0;

            //Array collection
            Item[] l1 = new Item[100];



            public void addItem(string n, double p, int q)
            {


                Item i = new Item(n, p, q); //CREATING NEW ITEM

                l1[count] = i;//set next count value to i

                count = count + 1;
            }
        public void displayItem()
        {

            string s = String.Format("{0,10}{1,10}{2,10}", "name", "price", "quantity");
            Console.WriteLine(s + "\n");

            foreach (Item i in l1)
            {
                if (i == null)
                    continue;
                string s1 = String.Format("{0,10}{1,10}{2,10}", i.Name, i.Price, i.Qty);
                Console.WriteLine(s1 + "\n");

            }
        }

        }
        class Item
        {

            //INSTANCE VARIABLES
            string name;
            double price;
            int qty;

            //CONSTRUCTOR
            public Item(string n, double p, int q)
            {
                Name = n;
                Price = p;
                Qty = q;

            }
            
            //GETTER AND SETTER
            public string Name { get => name; set => name = value; }
            public double Price { get => price; set => price = value; }
            public int Qty { get => qty; set => qty = value; }


        }
        class Driver
        {
            public void Test(InventoryManager im)
            {
                im.addItem("TV", 150.99, 25);
                im.addItem("Pancakes", 5.99, 35);
                im.addItem("Eggs", 8.99, 15);
                im.addItem("Chips", 1.99, 45);
                im.displayItem();
            }
        }
    }


