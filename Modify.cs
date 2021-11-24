using System;
using System.Windows.Forms;


using System.Text.RegularExpressions;


namespace EscribanoChova
{
    public partial class Modify : Form
    {
        private MainForm _form1;
        public Modify(MainForm form1)
        {
            InitializeComponent();
            _form1 = form1;
            int pos = _form1.itemList.SelectedIndex;
            modifyNameText.Text = _form1.inventory1.Product_list[pos].Name;
            modifyIdText.Text = _form1.inventory1.Product_list[pos].Id.ToString();
            modifyDescriptionText.Text = _form1.inventory1.Product_list[pos].Description;
            modifyManufacturerText.Text = _form1.inventory1.Product_list[pos].Manufacturer;

            modifyQuantityText.Text = _form1.inventory1.Product_list[pos].Quantity.ToString();
            modifyPriceText.Text = _form1.inventory1.Product_list[pos].Price.ToString();
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
            String prod1 = prod.Name + " - ID:" + prod.Id.ToString() + " - " + prod.Description + " -Manufacturer: " + prod.Manufacturer + " - Stock:" + prod.Quantity.ToString() + " -Price:" + prod.Price.ToString() + "€";
            _form1.itemList.Items.Add(prod1);
        }

        private void Modify_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            bool correctName = Regex.IsMatch(modifyNameText.Text, "[A-Z, a-z]{1,15}");
            if (correctName == true)
            {
                DialogResult result = MessageBox.Show("Do you want to edit?", "OK", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int pos = _form1.itemList.SelectedIndex;
                    _form1.inventory1.Product_list[pos].Name = modifyNameText.Text;

                    _form1.itemList.Items.Clear();
                    for (int i = 0; i < _form1.inventory1.Product_list.Count; i++)
                    {
                        addToListBox(_form1.inventory1.Product_list[i]);
                    }
                    _form1.itemList.SelectedIndex = pos;
                }
            }
            else
            {
                MessageBox.Show("The name should be a text", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   

        private void Button3_Click_1(object sender, EventArgs e)
        {
            bool correctID = Regex.IsMatch(modifyIdText.Text, "[0-9]{3}");
            if (correctID == true)
            {
                DialogResult result = MessageBox.Show("Do you want to edit?", "OK", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int id = converterInt(modifyIdText.Text);
                    int pos = _form1.itemList.SelectedIndex;
                    _form1.inventory1.Product_list[pos].Id = id;

                    _form1.itemList.Items.Clear();
                    for (int i = 0; i < _form1.inventory1.Product_list.Count; i++)
                    {
                        addToListBox(_form1.inventory1.Product_list[i]);
                    }
                    _form1.itemList.SelectedIndex = pos;
                }
            }
            else
            {
                MessageBox.Show("ID should be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            bool correctDescription = Regex.IsMatch(modifyDescriptionText.Text, "[A-Z, a-z]{1,100}");
            if (correctDescription == true)
            {
                DialogResult result = MessageBox.Show("Do you want to edit?", "OK", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int pos = _form1.itemList.SelectedIndex;
                    _form1.inventory1.Product_list[pos].Description = modifyDescriptionText.Text;

                    _form1.itemList.Items.Clear();
                    for (int i = 0; i < _form1.inventory1.Product_list.Count; i++)
                    {
                        addToListBox(_form1.inventory1.Product_list[i]);
                    }
                    _form1.itemList.SelectedIndex = pos;
                }
            }
            else
            {
                MessageBox.Show("The description should be a text", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            bool correctQuantity = Regex.IsMatch(modifyQuantityText.Text, "[0-9]{3}");
            if (correctQuantity == true)
            {
                DialogResult result = MessageBox.Show("Do you want to edit?", "OK", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int quantity = converterInt(modifyQuantityText.Text);
                    int pos = _form1.itemList.SelectedIndex;
                    _form1.inventory1.Product_list[pos].Quantity = quantity;

                    _form1.itemList.Items.Clear();
                    for (int i = 0; i < _form1.inventory1.Product_list.Count; i++)
                    {
                        addToListBox(_form1.inventory1.Product_list[i]);
                    }
                    _form1.itemList.SelectedIndex = pos;
                }
            }
            else
            {
                MessageBox.Show("Should be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button6_Click_1(object sender, EventArgs e)
        {
            bool correctPrice = Regex.IsMatch(modifyPriceText.Text, "[0-9]{1,4}([.]?[0-9]{0,4})");
            if (correctPrice == true)
            {
                DialogResult result = MessageBox.Show("Do you want to edit??", "OK", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    double price = converterDouble(modifyPriceText.Text);
                    int pos = _form1.itemList.SelectedIndex;
                    _form1.inventory1.Product_list[pos].Price = price;

                    _form1.itemList.Items.Clear();
                    for (int i = 0; i < _form1.inventory1.Product_list.Count; i++)
                    {
                        addToListBox(_form1.inventory1.Product_list[i]);
                    }
                    _form1.itemList.SelectedIndex = pos;
                }
            }
            else
            {
                MessageBox.Show("Do you want to edit?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            bool correctPrice = Regex.IsMatch(modifyDiscountText.Text, "[0-9]{2}");
            if (correctPrice == true)
            {
                DialogResult result = MessageBox.Show("Do you want to edit?", "OK", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    double discount = converterDouble(modifyDiscountText.Text);
                    int pos = _form1.itemList.SelectedIndex;
                    _form1.inventory1.Product_list[pos].applyDiscount(discount);


                    _form1.itemList.Items.Clear();
                    for (int i = 0; i < _form1.inventory1.Product_list.Count; i++)
                    {
                        addToListBox(_form1.inventory1.Product_list[i]);
                    }
                    _form1.itemList.SelectedIndex = pos;
                    modifyPriceText.Text = _form1.inventory1.Product_list[pos].Price.ToString();
                }
            }
            else
            {
                MessageBox.Show("Should be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button7_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modifyDescriptionText_TextChanged(object sender, EventArgs e)
        {

        }

        private void modifyDiscountLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void modifyManufacturerText_TextChanged(object sender, EventArgs e)
        {

        }

        private void modifyManufacturerButton_Click(object sender, EventArgs e)
        {
            bool correctManufacturer = Regex.IsMatch(modifyManufacturerText.Text, "[A-Z, a-z]{1,100}");
            if (correctManufacturer == true)
            {
                DialogResult result = MessageBox.Show("Do you want to edit?", "OK", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int pos = _form1.itemList.SelectedIndex;
                    _form1.inventory1.Product_list[pos].Manufacturer = modifyManufacturerText.Text;

                    _form1.itemList.Items.Clear();
                    for (int i = 0; i < _form1.inventory1.Product_list.Count; i++)
                    {
                        addToListBox(_form1.inventory1.Product_list[i]);
                    }
                    _form1.itemList.SelectedIndex = pos;
                }
            }
            else
            {
                MessageBox.Show("The manufacturer should be a text", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Modify_Load_1(object sender, EventArgs e)
        {

        }
    }
}
