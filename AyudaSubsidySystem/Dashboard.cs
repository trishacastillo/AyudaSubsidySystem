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
    public partial class Dashboard : Form
    {
        int budget = 1000000, head=5000;
        string conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Trisha Castillo\Documents\CaseStudy\AyudaSubsidySystem\Ayuda.accdb";
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AplicationForm frm = new AplicationForm();
            frm.Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
           
        }

        private void Btn_Benificiries_Click(object sender, EventArgs e)
        {
            Frm_Benificiries frm = new Frm_Benificiries();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cmdstr = "SELECT Count(*) from Beneficiries";
            OleDbConnection con = new OleDbConnection(conn);
            OleDbCommand com = new OleDbCommand(cmdstr, con);
            {
                con.Open();
                using (OleDbDataReader myreader = com.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(myreader);
                    int countbeneficiries = dt.Rows.Count+1;
                    int currentbudget = budget-(countbeneficiries * head);
                    label_beneficiries.Text = countbeneficiries.ToString();
                    label_currentBudget.Text = currentbudget.ToString(); 
                }
            }

            label_budget.Text = budget.ToString();
            con.Close();
        }
    }
}
