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
using System.Data.SqlClient;


namespace WinCrud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            String query = "SELECT * FROM EMPLOYEES";
            SqlDataAdapter adapter = new SqlDataAdapter(query, cs);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "employees");

            DataRow row = ds.Tables["employees"].NewRow();

            row[0] = textBox_id.Text;
            row[1] = textBox_name.Text;
            row[2] = textBox_dept.Text;
            row[3] = textBox_loc.Text;


            ds.Tables["employees"].Rows.Add(row);

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(ds.Tables["employees"]);
            dgView1.DataSource = ds.Tables["employees"];
        }
    }
}
