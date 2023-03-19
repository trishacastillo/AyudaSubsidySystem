using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyudaSubsidySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Enter_Click(object sender, EventArgs e)
        {
            if((text_User.Text=="admin") && text_Password.Text == "admin")
            {
                Dashboard frm = new Dashboard();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect. Access Denied!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Frm_Info frm = new Frm_Info();
            frm.Show();
           
        }
    }
}
