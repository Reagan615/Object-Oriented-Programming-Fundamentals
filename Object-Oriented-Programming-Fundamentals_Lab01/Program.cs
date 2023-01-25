using OOPF_Lab01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
VendingMachine vendingMachine = new VendingMachine();

vendingMachine.StockItem("milk", 12, "A1", 5);

vendingMachine.StockFloat(10, 2);
vendingMachine.StockFloat(5, 4);
vendingMachine.StockFloat(2, 5);
vendingMachine.StockFloat(1, 10);

vendingMachine.VendItem("A1", 10);


namespace OOPF_Lab01
{
    internal class VendingMachine
    {
        public string SerialNumber { get; set; }


        private Dictionary<int, int> MoneyFloat = new Dictionary<int, int>();

        private Dictionary<string, int> Inventory = new Dictionary<string, int>();

        private Dictionary<string, string> CodeAry = new Dictionary<string, string>();

        private Dictionary<string, int> PriceAry = new Dictionary<string, int>();
        public void StockItem(string product, int number, string serialNumber, int price)
        {
            SerialNumber = serialNumber;
            if (!CodeAry.ContainsKey(serialNumber))
            {
                CodeAry.Add(serialNumber, product);
            }

            if (Inventory.ContainsKey(product))
            {
                Inventory[product] = Inventory[product] + number;
            }
            else
            {
                Inventory.Add(product, number);
                PriceAry.Add(product, price);
            }


            Console.WriteLine($"{product}'s code is {SerialNumber}, price is {price}, quantity is {Inventory[product]}");


        }

        public void StockFloat(int moneyDenomination, int quantity)
        {
            MoneyFloat.Add(moneyDenomination, quantity);

            Console.WriteLine($"${moneyDenomination}: {MoneyFloat[moneyDenomination]}");
        }

        public void VendItem(string code, int money)
        {




            if (!CodeAry.ContainsKey(code))
            {
                Console.WriteLine($"“Error, no item with code {code}");

            }

            string name = CodeAry[code];
            int itemCost = PriceAry[name];
            int change = money - itemCost;

            if (Inventory[name] == 0)
            {
                Console.WriteLine($"“Error: {name} is out of stock");

            }


            if (change < 0)
            {

                Console.WriteLine($"Error: insufficient money provided");

            }
            else
            {
                Console.WriteLine($"Please enjoy your {name} and take your change of ${change}");
                Inventory[name]--;

            }


            Dictionary<int, int> changeReturned = new Dictionary<int, int>();

            foreach (KeyValuePair<int, int> coins in MoneyFloat)
            {
                changeReturned.Add(coins.Key, 0);
            }


            foreach (KeyValuePair<int, int> pair in MoneyFloat)
            {
                while (pair.Key <= change && MoneyFloat[pair.Key] > 0 && change > 0)
                {
                    change = change - pair.Key;
                    changeReturned[pair.Key]++;
                    MoneyFloat[pair.Key]--;
                }
            }

            if (change == 0)
            {
                Console.WriteLine("Returned coins:");
                foreach (KeyValuePair<int, int> pair in changeReturned)
                {
                    Console.WriteLine($"{pair.Key} {pair.Value} coins");
                }

            }
            else
            {
                Console.WriteLine("sorry,no more money");
            }

            Console.WriteLine("All of the amounts of money in the float inventory is:");
            foreach (KeyValuePair<int, int> pair in MoneyFloat)
            {
                Console.WriteLine($"${pair.Key}: {pair.Value} coins");
            }



        }


    }

    internal class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Code { get; set; }

        public string Output()
        {
            return $"confirming the product: {Name}, code: {Code}, price: {Price}";
        }
        public Product(string name, int price, int code)
        {
            Name = name;
            Price = price;
            Code = code;
        }
    }



}



