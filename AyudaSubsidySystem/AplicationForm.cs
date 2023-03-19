using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AyudaSubsidySystem
{
    public partial class AplicationForm : Form
    {
        string conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Trisha Castillo\Documents\CaseStudy\AyudaSubsidySystem\Ayuda.accdb";

        public AplicationForm()
        {
            InitializeComponent();
        }

        private void Btn_Dashboard_Click(object sender, EventArgs e)
        {
            Dashboard frm = new Dashboard();
            frm.Show();
            this.Hide();
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            String status;
            OleDbConnection con = new OleDbConnection(conn);
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            if (Convert.ToInt32(text_MonthlyIncome.Text) >= 12000)
            {
                 status = "Waiting";
               
            }
            else
            {
                 status = "Approved";
            }

            cmd.CommandText = "Insert into ApplicationForm (lastname, firstname, middlename, birthdate, sex, address, occupation, monthly_income, contact, application_status)" + " " + " " +
                "values('" + this.text_Lastname.Text + "', '" + this.text_Firstname.Text + "', '" + this.text_Middlename.Text
                + "', '" + this.text_Birthdate.Text + "', '" + this.text_Sex.Text + "', '" + this.text_Address.Text
                + "', '" + this.text_Occupation.Text + "', '" + this.text_MonthlyIncome.Text + "', '" + this.text_Contact.Text + "', '" + status + "');";
            cmd.ExecuteNonQuery(); 
            con.Close();
            if (status == "Waiting")
            {
                MessageBox.Show("Temporary your application is in Waiting List." +
                    " Thank you!");
            }
            else
            {
                MessageBox.Show("Your Application will process for Verification." +
                    " Thank you!");
            }
           
        }

        private void Btn_Beneficiries_Click(object sender, EventArgs e)
        {
            Frm_Benificiries frm = new Frm_Benificiries();
            frm.Show();
            this.Hide();
        }
    }
}
