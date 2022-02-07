using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient ;

namespace WinCrud
{
    public partial class Select : Form
    {
        public Select()
        {
            InitializeComponent();
        }

        private void select_button_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            String query = "SELECT * FROM EMPLOYEES";
            SqlDataAdapter adapter = new SqlDataAdapter(query, cs);

            DataSet ds = new DataSet();
            adapter.Fill(ds,"employees");
            dgView.DataSource = ds.Tables["employees"];
        }    
    }
}
