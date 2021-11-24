

namespace EscribanoChova
{
    public class product
    {
        private string name;

        private int id;

        private string description;

        private string manufacturer;

        private int quantity;

        private double price;

        public product(string name,int id, string description,string manufacturer, int quantity, double price)
        {
            this.name = name;
            this.id = id;
            this.description = description;
            this.manufacturer = manufacturer;
            this.quantity = quantity;
            this.price = price;
        }
        public product()
        {

        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
              
                    this.name = value; 
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
              
                    this.id = value;
                    
            }
        }

        public string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                this.description = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            set
            {
                this.manufacturer = value;
            }
        }

        public int Quantity
        {
            get
            {
                return this.quantity;
            }

            set
            {
             
                    this.quantity = value;
             
            }
        }

        public double Price
        {
            get
            {
                return this.price;
            }

            set
            {
                    this.price = value;
            }
        }

        public void applyDiscount(double discount)
        {
            this.price = this.price * (1 - (discount / 100));
        }
    }
}
