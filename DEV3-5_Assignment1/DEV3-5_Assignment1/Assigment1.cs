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

                if (lbTempEmpID.Text != "")
                {  
                    cmd.CommandText = "UPDATE employee SET bsn=@bsn, name=@name, surename=@surname WHERE employeeID=@idd";
                    cmd.Parameters.AddWithValue("@idd", lbTempEmpID.Text);
                    cmd.Parameters.AddWithValue("@bsn", int.Parse(tbAbsn.Text));
                    cmd.Parameters.AddWithValue("@name", tbAfirstname.Text);
                    cmd.Parameters.AddWithValue("@surname", tbAsurname.Text);

                    tbAbsn.Text = "";
                    tbAfirstname.Text = "";
                    tbAsurname.Text = "";

                    lbTempEmpID.Text = "";
                }
                else
                {
                    cmd.CommandText = "INSERT INTO employee(bsn,name,surename)VALUES(@bsn,@name,@surname)";
                    cmd.Parameters.AddWithValue("@bsn", int.Parse(tbAbsn.Text));
                    cmd.Parameters.AddWithValue("@name", tbAfirstname.Text);
                    cmd.Parameters.AddWithValue("@surname", tbAsurname.Text);

                    lbTempEmpID.Text = "";
                }

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

                MySqlCommand cmd2 = connection.CreateCommand();
                cmd2.CommandText = "SELECT employeeID, country, city, street, number, zip FROM addresses";
                MySqlDataAdapter adapt2 = new MySqlDataAdapter(cmd2);
                DataSet ds2 = new DataSet();
                adapt2.Fill(ds2);
                dgEAdresses.DataSource = ds2.Tables[0].DefaultView;

                MySqlCommand cmd3 = connection.CreateCommand();
                cmd3.CommandText = "SELECT * FROM employee_degree";
                MySqlDataAdapter adapt3 = new MySqlDataAdapter(cmd3);
                DataSet ds3 = new DataSet();
                adapt3.Fill(ds3);
                dgvEDegrees.DataSource = ds3.Tables[0].DefaultView;
                
                MySqlCommand cmd4 = connection.CreateCommand();
                cmd4.CommandText = "SELECT * FROM employee_position";
                MySqlDataAdapter adapt4 = new MySqlDataAdapter(cmd4);
                DataSet ds4 = new DataSet();
                adapt4.Fill(ds4);
                dgvEPosition.DataSource = ds4.Tables[0].DefaultView;

                MySqlCommand cmd5 = connection.CreateCommand();
                cmd5.CommandText = "SELECT * FROM projects";
                MySqlDataAdapter adapt5 = new MySqlDataAdapter(cmd5);
                DataSet ds5 = new DataSet();
                adapt5.Fill(ds5);
                dgvProjects.DataSource = ds5.Tables[0].DefaultView;
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

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                string id = dataGridView1.SelectedCells[0].Value.ToString();

                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    string ConnectionString = "Server=localhost;Database=dev3-05;Uid=root;Pwd=";
                    MySqlConnection connection = new MySqlConnection(ConnectionString);
                    connection.Open();
                    try
                    {
                        int selID = dataGridView1.SelectedCells[0].RowIndex;
                        MySqlCommand cmd = connection.CreateCommand();
                        cmd.CommandText = "DELETE FROM employee WHERE employeeID=@id";
                        cmd.Parameters.AddWithValue("@id", id);
                        MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapt.Fill(ds);
                        //dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    }
                    catch (Exception)
                    {
                        throw; //still throws exception cannot find table 0.. But the delete works atm
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                        {
                            connection.Clone();
                            LoadData();
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Server=localhost;Database=dev3-05;Uid=root;Pwd=";
            MySqlConnection connection = new MySqlConnection(ConnectionString); ;
            MySqlCommand cmd;
            connection.Open();

            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO addresses(employeeID, country, city, street, number, zip)VALUES(@empID, @country, @city, @street, @number, @zip)";
                cmd.Parameters.AddWithValue("@empID", nudEmpID);
                cmd.Parameters.AddWithValue("@country", tbCountry.Text);
                cmd.Parameters.AddWithValue("@city", tbCity.Text);
                cmd.Parameters.AddWithValue("@street", tbStreet.Text);
                cmd.Parameters.AddWithValue("@number", nudHouseNumber.Text);
                cmd.Parameters.AddWithValue("@zip", tbZIP.Text);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    LoadData();
                }
            }
        }

        private void btDeleteAddress_Click(object sender, EventArgs e)
        {
            if (dgEAdresses.SelectedCells.Count > 0)
            {
                string id = dgEAdresses.SelectedCells[0].Value.ToString();
                string street = dgEAdresses.SelectedCells[3].Value.ToString();

                foreach (DataGridViewRow item in this.dgEAdresses.SelectedRows)
                {
                    string ConnectionString = "Server=localhost;Database=dev3-05;Uid=root;Pwd=";
                    MySqlConnection connection = new MySqlConnection(ConnectionString);
                    connection.Open();
                    try
                    {
                        int selID = dgEAdresses.SelectedCells[0].RowIndex;
                        MySqlCommand cmd = connection.CreateCommand();
                        cmd.CommandText = "DELETE FROM addresses WHERE employeeID=@id AND street=@street";
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@street", street);
                        MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapt.Fill(ds);
                        //dgEAdresses.DataSource = ds.Tables[0].DefaultView;
                    }
                    catch (Exception)
                    {
                        throw; //still throws exception cannot find table 0.. But the delete works atm
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                        {
                            connection.Clone();
                            LoadData();
                        }
                    }
                }
            }
        }

        private void btEditEmployee_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                string id = dataGridView1.SelectedCells[0].Value.ToString();
                string bsn = dataGridView1.SelectedCells[1].Value.ToString();
                string name = dataGridView1.SelectedCells[2].Value.ToString();
                string surname = dataGridView1.SelectedCells[3].Value.ToString();

                tbAbsn.Text = bsn;
                tbAfirstname.Text = name;
                tbAsurname.Text = surname;

                lbTempEmpID.Text = id;
            }
        }

        private void tbEditAddress_Click(object sender, EventArgs e)
        {
            if (dgEAdresses.SelectedCells.Count > 0)
            {
                string id = dgEAdresses.SelectedCells[0].Value.ToString();
                string country = dgEAdresses.SelectedCells[1].Value.ToString();
                string city = dgEAdresses.SelectedCells[2].Value.ToString();
                string street = dgEAdresses.SelectedCells[3].Value.ToString();
                string number = dgEAdresses.SelectedCells[4].Value.ToString();
                string zip = dgEAdresses.SelectedCells[5].Value.ToString();

                tbCountry.Text = country;
                tbCity.Text = city;
                tbStreet.Text = street;
                nudHouseNumber = number;
                tbZIP = zip;

                lbTempAdressID.Text = id;
            }
        }
    }
}
