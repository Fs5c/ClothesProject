using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clothes.GUL
{


    public partial class UserPro : Form
    {
       public static UserPro instence;
        public System.Windows.Forms.TextBox tb1;
        public UserPro()
        {

            InitializeComponent();
            instence = this;
            tb1 = txtU;
        }
      

        private void btnAddPic_Click(object sender, EventArgs e)
        { 
        }

        private void UserPro_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(txtPhone.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Enter numbers only!");
            }

        }

        private void btnloign_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            
          f.frmMain_Load(txtU.Text,txtPassword.Text);
            f.Show();
            // Close();
        }



        private void picUser_Click(object sender, EventArgs e)
        {
         
        }
    }
}
    



