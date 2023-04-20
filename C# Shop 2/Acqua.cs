using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Shop_2
{

    public class Acqua : Prodotto
    {
        //attributi

        private double litri;
        public double Litri
        {
            get
            {
                return litri;
            }
            set
            {
                if (value > 1.5)
                {
                    this.litri = 1.5;
                }
                else
                {
                    litri = value;
                }

            }

        }
        private double ph;
        public double Ph
        {
            get
            {
                return ph;
            }

        }

        private string sorgente;
        public string Sorgente
        {
            get
            {
                return sorgente;
            }

        }

        public Acqua(string name, double litri, double ph, string sorgente) : base(name)
        {
            this.Litri = litri;
            this.ph = ph;
            this.sorgente = sorgente;
        }


        // GETTERS

        public double GetLitri()
        {
            return this.litri;
        }

        public double GetPh()
        {
            return this.ph;
        }

        public string GetSorgente()
        {
            return this.sorgente;

        }


        // METODI

        public void Bevi(double litriDaBere)
        {
            this.litri = (this.litri - litriDaBere);
        }

        public void Riempi(double litriDaRiempire)
        {
            this.litri = (this.litri + litriDaRiempire);
        }
        // ***
        public override string StampaProdotto()
        {
            string rapprString = base.StampaProdotto();
            rapprString += "\t - Litri :" + this.litri + "\n";
            rapprString += "\t - Ph: " + this.ph + "\n";
            rapprString += "\t - Sorgente: " + this.sorgente;

            return rapprString;

        }
    }
}
