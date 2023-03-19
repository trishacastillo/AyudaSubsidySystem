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
    public partial class Frm_WaitListed : Form
    {
        public Frm_WaitListed()
        {
            InitializeComponent();
        }

        private void Frm_WaitListed_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ayudaDataSet.Waiting' table. You can move, or remove it, as needed.
            this.waitingTableAdapter.Fill(this.ayudaDataSet.Waiting);

        }
    }
}
