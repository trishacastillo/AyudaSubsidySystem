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
    public partial class Frm_Verify : Form
    {
        public Frm_Verify()
        {
            InitializeComponent();
        }

        private void Frm_Verify_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ayudaDataSet.Verification' table. You can move, or remove it, as needed.
            this.verificationTableAdapter.Fill(this.ayudaDataSet.Verification);

        }
    }
}
