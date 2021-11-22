using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FinalCountdown
{
    public class Inventory
    {
        private List<product> product_list;

        public List<product> Product_list
        {
            get
            {
                return this.product_list;
            }

            set
            {
                this.product_list = value;
            }
        }

        public bool add(product _product)
        {
            if (product_list.Count != 0)
            {
                for (int i = 0; i < product_list.Count; i++)
                {
                    if (_product.Name == product_list[i].Name)
                    {
                        MessageBox.Show("This product already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    if (_product.Id == product_list[i].Id)
                    {
                        MessageBox.Show("This product already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            this.product_list.Add(_product);
            return true;
        }

        public void delete(int pos)
        {
            this.product_list.RemoveAt(pos);
        }

        public Inventory()
        {
            this.product_list = new List<product>();
        }
        public void applyDiscount(double percentage)
        {
            if (this.product_list.Count != 0)
            {
                for(int i=0; i< product_list.Count; i++)
                {
                    product_list[i].applyDiscount(percentage);
                }
            }
        }
        public string ToXML()
        {
            using (var stringwriter = new System.IO.StringWriter())
            {
                var serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stringwriter, this);
                return stringwriter.ToString();
            }
        }
    }
}

