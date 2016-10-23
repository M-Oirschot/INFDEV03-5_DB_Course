using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DEV3_5_Assignment1
{
    public partial class Assigment1 : Form
    {
        public Assigment1()
        {
            InitializeComponent();
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Server=localhost;Database=dev3-05;Uid=root;Pwd=";
            MySqlConnection connection = new MySqlConnection(ConnectionString); ;
            MySqlCommand cmd;
            connection.Open();

            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO employee(bsn)VALUES(@bsn)";
                cmd.Parameters.AddWithValue("@bsn", int.Parse(txtBsn.Text));

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if(connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    LoadData();
                }
            }
        }

        private void LoadData()
        {
            string ConnectionString = "Server=localhost;Database=dev3-05;Uid=root;Pwd=";
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM employee";
                MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if(connection.State == ConnectionState.Open)
                {
                    connection.Clone();
                }
            }

        }
    }
}
