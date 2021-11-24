using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EscribanoChova
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
            String prod1 = prod.Name + " - ID:" + prod.Id.ToString() + " - " + prod.Description + " - Manufacturer:" + prod.Manufacturer.ToString() + " - Stock:" + prod.Quantity.ToString() + " -Price:" + prod.Price.ToString() + "€";
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
                        bool correctManufacturer = Regex.IsMatch(addManufacturerText.Text, "[A-Z, a-z]{1,100}");
                        if (correctManufacturer == true)
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


                                    product newItem = new product(addNameText.Text, id, addDescriptionText.Text, addManufacturerText.Text, quantity, price);
                                    bool correctly_added = _form1.inventory1.add(newItem);
                                    if (correctly_added == true)
                                    {
                                        addToListBox(newItem);
                                    }

                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("The price should be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                            else
                            {
                                MessageBox.Show("The quantity should be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("The manufacturer should be a text", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MessageBox.Show("The description should be a text", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The id should be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("The name should be a text", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void addManufacturerText_TextChanged(object sender, EventArgs e)
        {

        }

        private void addDescriptionText_TextChanged(object sender, EventArgs e)
        {

        }

        private void addPriceLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
