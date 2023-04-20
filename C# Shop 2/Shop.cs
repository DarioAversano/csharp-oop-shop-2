using C__Shop_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C__Shop_2
{
    public class Shop
    {
        // ATTRIBUTI 

        private string name;
        private string city;
        private string address;
        private int civicNumber;
        private string type;
        private List<Prodotto> itemsInShop;

        // COSTRUTTORE

        public Shop(string name, string city, string address, int civicNumber, string type)
        {
            this.name = name;
            this.city = city;
            this.address = address;
            this.civicNumber = civicNumber;
            this.type = type;
            this.itemsInShop = new List<Prodotto>();
        }

        // GETTERS

        public string getName()
        {
            return this.name;
        }

        public string getCity()
        {
            return this.city;
        }

        public string getAddress()
        {
            return this.address;
        }

        public int getCivicNumber()
        {
            return this.civicNumber;
        }

        public List<Prodotto> GetShopList()
        {
            return this.itemsInShop;
        }

        // SETTERS

        public void SetType(string type)
        {
            this.type = type;
        }

        // METODI

        public void addItem(Prodotto newItemShop)
        {
            itemsInShop.Add(newItemShop);
        }

        public void AddListItems(List<Prodotto> newItems)
        {
            //itemShop = (List<itemShop>)itemShop.Concat(newItems);

            foreach (Prodotto itemScansionato in newItems)
            {
                itemsInShop.Add(itemScansionato);
            }
        }

        public string InfoShop()
        {
            string rapprInfoShop = "Il nome del negozio è: " + this.name + "\n";
            rapprInfoShop += "La città in cui si trova è: " + this.city + "\n";
            rapprInfoShop += "All'indirizzo: " + this.address + "\n";
            rapprInfoShop += "Numero civico: " + this.civicNumber + "\n";
            rapprInfoShop += "Lista prodotti trattati: " + "\n";
            foreach (Prodotto itemScansionato in itemsInShop)
            {
                rapprInfoShop += " - " + itemScansionato.StampaProdotto() + "\n";
            }
            return rapprInfoShop;

        }
    }



}
