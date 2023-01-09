using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_3
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
                Console.WriteLine("3.........Remove item");
                Console.WriteLine("4.........Search item by name");
                Console.WriteLine("5.........Search item by price");
                Console.WriteLine("6.........Edit/Re-stock item");
                Console.WriteLine("7.........Exit");


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
                        i1.addItem(n,p,q);
                        break;
                    case 2:
                        i1.displayItem();
                        break;

                    case 3:
                        Console.WriteLine("Enter item name to remove ");
                        string removen = Console.ReadLine();
                        i1.removeItem(removen);
                        break;
                    case 4:
                        Console.WriteLine("Enter item name to search ");
                        string searchn = Console.ReadLine();
                        i1.searchItemByName(searchn);
                        break;

                    case 5:

                        Console.WriteLine("Enter price to search ");
                        double searchPrice = Convert.ToDouble(Console.ReadLine());
                        i1.searchItemByPrice(searchPrice);
                        break;

                    case 6:
                        Console.WriteLine("Enter item name to edit stock ");
                        string n2 = Console.ReadLine();

                        Console.WriteLine("Enter new stock quantity for this item ");
                        string inputQuantity = Console.ReadLine();
                        int editQuantity = Convert.ToInt32(inputQuantity);

                        i1.editItem(n2, editQuantity);
                        break;

                    case 7:
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

        public void removeItem(string n)
        {
            
            
            int foundItem = -1;

            //SCANNING LIST COLLECTION
            for (int i = 0; i < count; i++)
            {

                //CHECKING WHETHER USER GIVEN NAME IS EQUAL TO THE CURRENT ITEMS NAME
                //OR NOT
                if (l1[i].Name.Equals(n)) //IF FOUND THE ITEM
                {
                    
                    Console.WriteLine("Item Found");
                    foundItem = i;
                    break;
                }
            }

            if (foundItem == -1)
            {
                Console.WriteLine("Item not found");
                return;
            }
            //loop through every entry and skip the found item then set the new array equal to this array
            Item[] l2= new Item[100];
            int k = 0;
            for (int j = 0; j < 100; j++)
            { // Loop through all array items
                if (j == foundItem)
                    continue;

                l2[k] = l1[j]; // Set entry
                k++; // Add 1 to i
            }
            l1 = l2;

        }

        //SEARCH ITEM BY NAME
        public void searchItemByName(string n)
        {
            
            int flag = 0;
            //DISPLAY HEADING
            string s = String.Format("{0,10}{1,10}{2,10}", "name", "price", "quantity");
            Console.WriteLine(s + "\n");

            //SCANNING TOTAL LIST
            foreach (Item i in l1)
            {
                if (i == null)
                    continue;
                //IF USER GIVEN NAME FOUND
                if (i.Name.Equals(n))
                {
                    //DISPLAY THE DETAILS
                    string s1 = String.Format("{0,10}{1,10}{2,10}", i.Name, i.Price, i.Qty);
                    Console.WriteLine(s1 + "\n");
                    flag = 1;
                    break;
                }

            }

            if (flag == 0)
                Console.WriteLine("Item not found");


        }

        //SEARCH ITEM BY PRICE
        public void searchItemByPrice(double p)
        {

            int flag = 0;
            string s = String.Format("{0,10}{1,10}{2,10}", "name", "price", "quantity");
            Console.WriteLine(s + "\n");

            //SCANNING TOTAL LIST
            foreach (Item i in l1)
            {
                if (i == null)
                    continue;
                //IF USER GIVEN PRICE FOUND
                if (i.Price == p)
                {
                    //DISPLAY THAT ITEM
                    string s1 = String.Format("{0,10}{1,10}{2,10}", i.Name, i.Price, i.Qty);
                    Console.WriteLine(s1 + "\n");
                    flag = 1;
                    break;
                }

            }

            if (flag == 0)
                Console.WriteLine("Item not found");

        }


        public void editItem(string n, int q)
        {

            

            //SCANNING EACH ITEM
            foreach (Item i in l1)
            {
                if (i == null)
                    continue;

                if (i.Name.Equals(n))//IF ITEM FOUND
                {
                    i.Qty = q;//CHANGING THE QUANTITY
                    Console.WriteLine("quantity updated");
                    break;
                }

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


            Console.WriteLine("Removing Eggs");
            im.removeItem("Eggs");

            Console.WriteLine("Displaying items for 1.99");
            im.searchItemByPrice(1.99);

            Console.WriteLine("Search for Pancakes");
            im.searchItemByName("Pancakes");

            Console.WriteLine("Edit TV Stock to 50");
            im.editItem("TV", 50);
            im.displayItem();
        }
    }
}
