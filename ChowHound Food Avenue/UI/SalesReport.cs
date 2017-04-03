using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Chowhound_Food_Avenue.UI
{
    public partial class SalesReport : Form
    {


        string cs = "Data Source=.;Initial Catalog=ChowhoundDb;Integrated Security=true;";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;

        public SalesReport()
        {
            InitializeComponent();

        }


        private void SalesReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chowhoundDbDataSet1.Table_1' table. You can move, or remove it, as needed.
            this.table_1TableAdapter.Fill(this.chowhoundDbDataSet1.Table_1);
            // TODO: This line of code loads data into the 'chowhoundDbDataSet.Table_1' table. You can move, or remove it, as needed.
            this.table_1TableAdapter.Fill(this.chowhoundDbDataSet.Table_1);
            // TODO: This line of code loads data into the 'chowhoundDbDataSet.Chowhound_Table' table. You can move, or remove it, as needed.
            this.chowhound_TableTableAdapter.Fill(this.chowhoundDbDataSet.Chowhound_Table);


            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from Table_1", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void Home_Click(object sender, EventArgs e)
        {
            Billing_System billing = new Billing_System();
            this.Hide();
            billing.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from Table_1 where Username like '" + textBox1.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
