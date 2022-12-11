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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnListProducts_Click(object sender, EventArgs e)

        {
            /* // TODO: This line of code loads data into the 'weekSevenDatabaseVossDataSet.Inventory' table. You can move, or remove it, as needed.
             this.inventoryTableAdapter.Fill(this.weekSevenDatabaseVossDataSet.Inventory);*/

            var table = new DataTable();
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\andre\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\WeekSevenDatabaseVoss.mdf"";Integrated Security=True;Connect Timeout=30";
            using (var con = new SqlConnection { ConnectionString = connectionString })

            {
                using (var command = new SqlCommand { Connection = con })
                {
                    con.Open();
                    command.CommandText = @"SELECT * From Inventory";
                    table.Load(command.ExecuteReader());
                    dataGridViewListProducts.DataSource = table.DefaultView;

                }
            }

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewLookUpProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
        }

        private void btnOpenLookUpProduct_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }


        /* private void Form1_Load(object sender, EventArgs e)
*//*{
    string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\andre\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\WeekSevenDatabaseVoss.mdf"";Integrated Security=True;Connect Timeout=30";
    SqlConnection sqlconnn = new SqlConnection(connectionString);
    string sqlquery = "select * from Inventory";
    sqlconnn.Open();
    SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconnn);
    SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
    DataTable dt = new DataTable();
    sdr.Fill(dt);


}*//*
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
    }*/


    }
    }

    

