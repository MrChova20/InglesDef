using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalCountdown
{
    public partial class passwordForm : Form
    {
        
        public passwordForm()
        {
            InitializeComponent();
            
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        int count = 0;
        private void Button1_Click(object sender, EventArgs e)
        {
            string password = passwordText.Text;
            if (password == "hola")
            {

                this.Close();
            }
            else if(count==2){
              
                    Application.Exit();
                
              
            }else{
                count++;
            }
        }

        private void passwordText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
