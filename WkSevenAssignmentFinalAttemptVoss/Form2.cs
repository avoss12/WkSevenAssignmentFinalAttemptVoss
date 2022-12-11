using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WkSevenAssignmentFinalAttemptVoss
{
    public partial class Form2 : Form
        
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridViewLookUpProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var table = new DataTable();
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\andre\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\WeekSevenDatabaseVoss.mdf"";Integrated Security=True;Connect Timeout=30";
            using (var con = new SqlConnection { ConnectionString = connectionString })

            {
                using (var command = new SqlCommand { Connection = con })
                {
                    con.Open();
                    command.CommandText = @"SELECT * From Inventory";
                    table.Load(command.ExecuteReader());
                    dataGridViewLookUpProduct.DataSource = table.DefaultView;
                }
            }
        }

        private void txtBoxLookUpProduct_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connn = new SqlConnection();
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\andre\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\WeekSevenDatabaseVoss.mdf"";Integrated Security=True;Connect Timeout=30";
            string sqlquery = "select * from Inventory";
            connn.Open();
            SqlCommand com = new SqlCommand(sqlquery, connn);
            SqlDataAdapter sdr = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridViewLookUpProduct.DataSource = dt;
            connn.Close();

        }
    }
}

