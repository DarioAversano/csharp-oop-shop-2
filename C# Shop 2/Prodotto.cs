using C__Shop_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Shop_2
{
    public class Prodotto
    {
        //ATTRIBUTI

        private string name;
        private List<Category> categories;
        // COSTRUTTORE

        public Prodotto(string name)
        {
            this.name = name;
            this.categories = new List<Category>();
        }

        // GETTERS 

        public string GetName()
        {
            return this.name;
        }

        public List<Category> GetCategoriesList()
        {
            return this.categories;
        }


        public virtual string StampaProdotto()
        {
            string rapprString = "Nome prodotto: " + this.name + "\n";
            rapprString += "\t Categorie prodotto: \n";
            foreach (Category categoriaScansionata in categories)
            {
                rapprString += "\t - " + categoriaScansionata.GetName() + "\n";
            }

            return rapprString;

        }

        public void addCategory(Category newCategory)
        {
            this.categories.Add(newCategory);
        }
    }
}
