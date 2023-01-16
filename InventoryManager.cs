using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone1
{
    public class InventoryManager
    {
        public InventoryManager()
        {
            addItem("TV", 150.99, 25);
            addItem("Pancakes", 5.99, 35);
            addItem("Eggs", 8.99, 15);
            addItem("Chips", 1.99, 45);
        }
        //List collection
        List<Item> l1 = new List<Item>();

        public void addItem(string name, double price, int quantity)
        {
            Item i = new Item(name, price, quantity); //CREATING NEW ITEM
            l1.Add(i);//ADDING ITEM TO LIST
        }

        public List<Item> getItems()
        {
            return new List<Item>(l1);
        }

        public void removeItem(string name)
        {
            //SCANNING LIST COLLECTION
            for (int i = 0; i < l1.Count; i++)
            {
                //CHECKING WHETHER USER GIVEN NAME IS EQUAL TO THE CURRENT ITEMS NAME
                //OR NOT
                if (l1[i].Name.Equals(name)) //IF FOUND THE ITEM
                {
                    l1.RemoveAt(i);//REMOVE THE ITEM ON THAT INDEX
                    break;
                }
            }
        }

        //SEARCH ITEM BY NAME
        public Item searchItemByName(string n)
        {
            //SCANNING TOTAL LIST
            foreach (Item i in l1)
            {
                //IF USER GIVEN NAME FOUND
                if (i.Name.Equals(n))
                {
                    //DISPLAY THE DETAILS
                    return i;
                }
            }

            return null;
        }

        //SEARCH ITEM BY PRICE
        public Item searchItemByPrice(double p)
        {
            var res = new List<Item>();
            //SCANNING TOTAL LIST
            foreach (Item i in l1)
            {
                //IF USER GIVEN PRICE FOUND
                if (i.Price == p)
                {
                    return i;
                }
            }

            return null;
        }
        public void sortData()
        {
            //Compare the Names of each list item and sort them by Alphabetical order
            l1 = getItems().OrderBy(s => s.Name).ToList();
        }

        public void editItem(string n,int quantity)
        {
            //SCANNING EACH ITEM
            foreach (Item i in l1)
            {
                if (i.Name.Equals(n))//IF ITEM FOUND
                {
                    i.Qty = quantity;//CHANGING THE QUANTITY
                    break;
                }
            }
        }
    }
    public class Item
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
}
