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
    public partial class MainForm : Form
    {
       public Inventory inventory1 = new Inventory();
        public MainForm()
        {
            InitializeComponent();
            passwordForm childWindow = new passwordForm();
            childWindow.ShowDialog(this);
          
        }

        private void Button2_Click(object sender, EventArgs e)
        {

           
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
        }

      

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            var add = new Add(this);
            add.ShowDialog();


        }

        

      

        private void Button3_Click_1(object sender, EventArgs e)
        {
            AboutUsForm childWindow = new AboutUsForm();
            childWindow.ShowDialog(this);
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

        private void Button5_Click(object sender, EventArgs e)
        {
            double discount = converterDouble(discountText.Text);
            inventory1.applyDiscount(discount);
            itemList.Items.Clear();
            for(int i=0; i < inventory1.Product_list.Count; i++)
            {
                addToListBox(inventory1.Product_list[i]);
            }
        }
        private void addToListBox(product prod)
        {
            String prod1 = prod.Name + " - ID:" + prod.Id.ToString() + " - " + prod.Description + " - Stock:" + prod.Quantity.ToString() + " -Price:" + prod.Price.ToString() + "€";
            itemList.Items.Add(prod1);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            double discount = converterDouble(raisePriceText.Text)*-1;
            inventory1.applyDiscount(discount);
            itemList.Items.Clear();
            for (int i = 0; i < inventory1.Product_list.Count; i++)
            {
                addToListBox(inventory1.Product_list[i]);
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            DataViewer childWindow = new DataViewer(this);
            childWindow.ShowDialog(this);
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really wish to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int posListBox = itemList.SelectedIndex;
                itemList.Items.Remove(itemList.SelectedItem);
                inventory1.delete(posListBox);
            }
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            if (itemList.SelectedIndex != -1)
            {
                var modify = new Modify(this);
                modify.ShowDialog();
            }
        }
    }
}
