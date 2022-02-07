using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCrud
{
    public partial class Mdiform : Form
    {
        public Mdiform()
        {
            InitializeComponent();
        }
       private void sELECTOPERATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Select sc = new Select();
            sc.Show();
            sc.MdiParent = this;

        }

        private void iNSERTOPERATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            frm.MdiParent = this;


        }
    }
}
