using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    public class Product
    {

        //attributes
        private double serialNumber;
        private string name;
        private string description = "Nessuna descrizione disponibile";
        private float price;
        private float vat;

        //construcor

        public Product(string productName, float productPrice, float productVat )
        {
            this.Name = productName;
            this.Price = productPrice;
            this.Vat = productVat;
            GenerateSerialNumber();
            
        }


        //PROPRETIES

        //serial number
        public double SerialNumber
        {
            get {
                return this.serialNumber;
            }
        }


        //name
        public string Name
        {
            get
            {
                return this.name;
            }

            set { this.name = value; }
        }


        //description
        public string Description
        {
            get
            {
                return this.description;
            }
            set 
            {
                if (value.Length < 255)
                    this.description = value;
                else
                    Console.WriteLine("Descrizione troppo lunga");
            }
        }

        //serial number
        public float Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value > 0)
                    this.price = value;
                else
                    Console.WriteLine("Indicare un prezzo");
            }
        }

        //vat
        public float Vat
        {
            get
            {
                return this.vat;
            }

            set
            {
                if (value > 0)
                    this.vat = value;
                else
                    Console.WriteLine("Inserire IVA del prodotto");
            }
        }

        //GETTER

        //get the total price with vat
        public float GetIvaTotalPrice()
        {
            float totalPrice = 0;
            totalPrice = this.price + ((this.price *  this.vat) / 100);
            return MathF.Round(totalPrice, 2);

        }


        //get the univoque name of your product
        public string GetIdentificationName()
        {
            string fullName = $"{this.name} (S/N {this.serialNumber})";
            return fullName;
        }



        //CLASS FUNCTIONS
        private void GenerateSerialNumber()
        {
            string serialString = "";
            Random rnd = new Random();
            for(int i = 1; i < 14;  i++)
            {
                serialString += $"{rnd.Next(10)}";
            }
            this.serialNumber = double.Parse(serialString);
        }
    }
}
