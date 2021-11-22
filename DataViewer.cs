using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FinalCountdown
{
    
    public partial class DataViewer : Form
    {
        private MainForm main;
        public DataViewer(MainForm _main)
        {
            main = _main;
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (TXTradioButton.Checked)
            {
                const string sPath = "save.txt";
                StreamWriter SaveFile = new StreamWriter(sPath);
               for(int i=0; i<main.inventory1.Product_list.Count;i++)
                {
                    String prod1 = main.inventory1.Product_list[i].Name + " - ID:" + main.inventory1.Product_list[i].Id.ToString() + " - " + main.inventory1.Product_list[i].Description + " - Stock:" + main.inventory1.Product_list[i].Quantity.ToString() + " -Price:" + main.inventory1.Product_list[i].Price.ToString() + "€";
                    SaveFile.WriteLine(prod1);
                }
                SaveFile.Close();
                try
                {
                   
                    string txtString = File.ReadAllText(sPath, Encoding.UTF8);
                    dataViewerText.Text = txtString;
                }
                catch (IOException exception)
                {
                    string error = exception.Message;
                    dataViewerText.Text = error;
                }

            }
            if (JSONradioButton.Checked)
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                string jsonString = serializer.Serialize(main.inventory1.Product_list);
                dataViewerText.Text = jsonString;
                  
            }
            if (XMLradioButton.Checked)
            {


                string XML = main.inventory1.ToXML();
                dataViewerText.Text = XML;

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}
