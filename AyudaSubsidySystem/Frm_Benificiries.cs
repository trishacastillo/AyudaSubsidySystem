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
    public partial class Frm_Benificiries : Form
    {
        string conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Trisha Castillo\Documents\CaseStudy\AyudaSubsidySystem\Ayuda.accdb";

        public Frm_Benificiries()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            text_id.Text = dr.Cells[0].Value.ToString();
            text_household.Text = dr.Cells[1].Value.ToString();
            text_Lastname.Text = dr.Cells[2].Value.ToString();
            text_Firstname.Text = dr.Cells[3].Value.ToString();
            text_Middlename.Text = dr.Cells[4].Value.ToString();
            text_Birthdate.Text = dr.Cells[5].Value.ToString();
            text_Sex.Text = dr.Cells[6].Value.ToString();
            text_Address.Text = dr.Cells[7].Value.ToString();
            text_Occupation.Text = dr.Cells[8].Value.ToString();
            text_MonthlyIncome.Text = dr.Cells[9].Value.ToString();
            text_Contact.Text = dr.Cells[10].Value.ToString();
            text_Age.Text = dr.Cells[11].Value.ToString();
        }

        private void Frm_Benificiries_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ayudaDataSet.Beneficiries' table. You can move, or remove it, as needed.
            this.beneficiriesTableAdapter.Fill(this.ayudaDataSet.Beneficiries);

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(conn);
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Beneficiries";
            cmd.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            con.Close();

            //dAdapter.Fill(dataTable);
            //for (int i = 0; i < dataTable.Rows.Count; i++)
            //{
            //    dataGridView1.Rows.Add(dataTable.Rows[i][0], dataTable.Rows[i][1]);
            //}

        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(conn);
            int count = 0;
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Beneficiries WHERE lastname='"+text_Search.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dataTable);
            count = Convert.ToInt32(dataTable.Rows.Count.ToString());
            dataGridView1.DataSource = dataTable;
            con.Close();
            if (count == 0)
            {
                MessageBox.Show("Record not found!");
            }
        }

        private void Btn_WaitListed_Click(object sender, EventArgs e)
        {
            Frm_WaitListed frm = new Frm_WaitListed();
            frm.Show();
            this.Hide();
        }
    }
}
