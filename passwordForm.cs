using System;

using System.Windows.Forms;

namespace EscribanoChova
{
    public partial class PasswordForm : Form
    {
        
        public PasswordForm()
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
            if (password == "developer")
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

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
