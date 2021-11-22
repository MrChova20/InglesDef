using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalCountdown
{
    public partial class Add : Form
    {
        private MainForm _form1;
        public Add(MainForm form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        private int converterInt(string number)
        {
            int i = 0;
            if (!Int32.TryParse(number, out i))
            {
                i = -1;
            }
            return i;
        }

        private double converterDouble(string number)
        {
            double i = 0;
            if (!Double.TryParse(number, out i))
            {
                i = -1;
            }
            return i;
        }

        private void addToListBox(product prod)
        {
            String prod1 = prod.Name + " - ID:" + prod.Id.ToString() + " - " + prod.Description + " - Stock:" + prod.Quantity.ToString() + " -Price:" + prod.Price.ToString() + "€";
            _form1.itemList.Items.Add(prod1);
        }

       

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {

            bool correctName = Regex.IsMatch(addNameText.Text, "[A-Z, a-z]{1,15}");
            if (correctName == true)
            {
                bool correctID = Regex.IsMatch(addIdText.Text, "[0-9]{3}");
                if (correctID == true)
                {
                    bool correctDescription = Regex.IsMatch(addDescriptionText.Text, "[A-Z, a-z]{1,100}");
                    if (correctDescription == true)
                    {
                        bool correctQuantity = Regex.IsMatch(addQuantitytext.Text, "[0-9]{3}");
                        if (correctQuantity == true)
                        {
                            bool correctPrice = Regex.IsMatch(addPriceText.Text, "[0-9]{1,4}([.]?[0-9]{0,4})");
                            if (correctPrice == true)
                            {

                                int id = converterInt(addIdText.Text);
                                int quantity = converterInt(addQuantitytext.Text);
                                double price = converterDouble(addPriceText.Text);


                                product newItem = new product(addNameText.Text, id, addDescriptionText.Text, quantity, price);
                                bool correctly_added = _form1.inventory1.add(newItem);
                                if (correctly_added == true)
                                {
                                    addToListBox(newItem);
                                }

                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("It's blank or the price is not a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("It's blank or the quantity is not a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("It's blank or the description is not in the correct format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("It's blank or the id is not a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("It's blank or the name is not in the correct format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
