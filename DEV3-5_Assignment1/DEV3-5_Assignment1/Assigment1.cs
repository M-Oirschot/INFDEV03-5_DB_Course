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

                MySqlCommand cmd6 = connection.CreateCommand();
                cmd6.CommandText = "SELECT * FROM projectmembers";
                MySqlDataAdapter adapt6 = new MySqlDataAdapter(cmd6);
                DataSet ds6 = new DataSet();
                adapt6.Fill(ds6);
                dgvProMembers.DataSource = ds6.Tables[0].DefaultView;
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
                if (lbTempAdressID.Text != "")
                {
                    string streetChk = dgEAdresses.SelectedCells[3].Value.ToString();
                    cmd.CommandText = "UPDATE employee SET country=@country, city=@city, street=@street, number=@number, zip=@zip WHERE employeeID=@idd AND street=@streetChk";
                    cmd.Parameters.AddWithValue("@idd", lbTempAdressID.Text);
                    cmd.Parameters.AddWithValue("@country", tbCountry.Text);
                    cmd.Parameters.AddWithValue("@city", tbCity.Text);
                    cmd.Parameters.AddWithValue("@street", tbStreet.Text);
                    cmd.Parameters.AddWithValue("@number", nudHouseNumber.Value);
                    cmd.Parameters.AddWithValue("@zip", tbZIP.Text);

                    cmd.Parameters.AddWithValue("@streetChk", streetChk);

                    tbCountry.Text = "";
                    tbCity.Text = "";
                    tbStreet.Text = "";
                    tbZIP.Text = "";
                    nudHouseNumber.Value = 0;

                    lbTempEmpID.Text = "";
                }
                else
                {
                    cmd.CommandText = "INSERT INTO addresses(employeeID, country, city, street, number, zip)VALUES(@empID, @country, @city, @street, @number, @zip)";
                    cmd.Parameters.AddWithValue("@empID", nudEmpID.Value);
                    cmd.Parameters.AddWithValue("@country", tbCountry.Text);
                    cmd.Parameters.AddWithValue("@city", tbCity.Text);
                    cmd.Parameters.AddWithValue("@street", tbStreet.Text);
                    cmd.Parameters.AddWithValue("@number", nudHouseNumber.Value);
                    cmd.Parameters.AddWithValue("@zip", tbZIP.Text);

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

                nudEmpID.Value = int.Parse(id);
                tbCountry.Text = country;
                tbCity.Text = city;
                tbStreet.Text = street;
                nudHouseNumber.Value = int.Parse(number);
                tbZIP.Text = zip;

                lbTempAdressID.Text = id;
            }
        }

        private void btDegAdd_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Server=localhost;Database=dev3-05;Uid=root;Pwd=";
            MySqlConnection connection = new MySqlConnection(ConnectionString); ;
            MySqlCommand cmd;
            connection.Open();

            try
            {
                cmd = connection.CreateCommand();

                if (lbDegTempID.Text != "")
                {
                    string courseChk = dgvEDegrees.SelectedCells[1].Value.ToString();
                    cmd.CommandText = "UPDATE employee_degree SET employeeID=@empid, course=@course, school=@school, level=@level WHERE employeeID=@empid AND course=@courseChk";

                    cmd.Parameters.AddWithValue("@empid", nudDegEmpID.Value);
                    cmd.Parameters.AddWithValue("@course", tbDegCourse.Text);
                    cmd.Parameters.AddWithValue("@school", tbDegSchool.Text);
                    cmd.Parameters.AddWithValue("@level", tbDegLevel.Text);
                    cmd.Parameters.AddWithValue("@courseChk", courseChk);

                    tbDegCourse.Text = "";
                    tbDegSchool.Text = "";
                    tbDegLevel.Text = "";

                    lbDegTempID.Text = "";
                }
                else
                {
                    cmd.CommandText = "INSERT INTO employee_degree(employeeID,course,school,level)VALUES(@empid,@course,@school,@level)";
                    cmd.Parameters.AddWithValue("@empid", nudDegEmpID.Value);
                    cmd.Parameters.AddWithValue("@course", tbDegCourse.Text);
                    cmd.Parameters.AddWithValue("@school", tbDegSchool.Text);
                    cmd.Parameters.AddWithValue("@level", tbDegLevel.Text);

                    lbDegTempID.Text = "";
                }

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

        private void btDegEdit_Click(object sender, EventArgs e)
        {
            if (dgvEDegrees.SelectedCells.Count > 0)
            {
                string id = dgvEDegrees.SelectedCells[0].Value.ToString();
                string course = dgvEDegrees.SelectedCells[1].Value.ToString();
                string school = dgvEDegrees.SelectedCells[2].Value.ToString();
                string level = dgvEDegrees.SelectedCells[3].Value.ToString();

                nudDegEmpID.Value = int.Parse(id);
                tbDegCourse.Text = course;
                tbDegSchool.Text = school;
                tbDegLevel.Text = level;

                lbDegTempID.Text = id;
            }
        }

        private void btDegDelete_Click(object sender, EventArgs e)
        {
            if (dgvEDegrees.SelectedCells.Count > 0)
            {
                string id = dgvEDegrees.SelectedCells[0].Value.ToString();
                string coursee = dgvEDegrees.SelectedCells[1].Value.ToString();

                foreach (DataGridViewRow item in this.dgvEDegrees.SelectedRows)
                {
                    string ConnectionString = "Server=localhost;Database=dev3-05;Uid=root;Pwd=";
                    MySqlConnection connection = new MySqlConnection(ConnectionString);
                    connection.Open();
                    try
                    {
                        int selID = dgvEDegrees.SelectedCells[0].RowIndex;
                        MySqlCommand cmd = connection.CreateCommand();
                        cmd.CommandText = "DELETE FROM employee_degree WHERE employeeID=@id AND course=@course";
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@course", coursee);

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

        private void btPosAdd_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Server=localhost;Database=dev3-05;Uid=root;Pwd=";
            MySqlConnection connection = new MySqlConnection(ConnectionString); ;
            MySqlCommand cmd;
            connection.Open();

            try
            {
                cmd = connection.CreateCommand();

                if (lbPosEmpID.Text != "")
                {
                    cmd.CommandText = "UPDATE employee_position SET employeeID=@empid, description=@description, hourFee=@hourFee, locationHQID=@locationHQID WHERE employeeID=@empid";

                    cmd.Parameters.AddWithValue("@empid", nudPosEmpID.Value);
                    cmd.Parameters.AddWithValue("@description", tbPosDesc.Text);
                    cmd.Parameters.AddWithValue("@hourFee", tbPosHour.Text);
                    cmd.Parameters.AddWithValue("@locationHQID", tbPosHQID.Text);

                    tbPosHQID.Text = "";
                    tbPosHour.Text = "";
                    tbPosDesc.Text = "";

                    lbPosEmpID.Text = "";
                }
                else
                {
                    cmd.CommandText = "INSERT INTO employee_position(employeeID,description,hourFee,locationHQID)VALUES(@empid,@description,@hourFee,@locationHQID)";
                    cmd.Parameters.AddWithValue("@empid", nudPosEmpID.Value);
                    cmd.Parameters.AddWithValue("@description", tbPosDesc.Text);
                    cmd.Parameters.AddWithValue("@hourFee", tbPosHour.Text);
                    cmd.Parameters.AddWithValue("@locationHQID", tbPosHQID.Text);

                    lbPosEmpID.Text = "";
                }

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

        private void btPosDelete_Click(object sender, EventArgs e)
        {
            if (dgvEPosition.SelectedCells.Count > 0)
            {
                string id = dgvEPosition.SelectedCells[0].Value.ToString();

                foreach (DataGridViewRow item in this.dgvEPosition.SelectedRows)
                {
                    string ConnectionString = "Server=localhost;Database=dev3-05;Uid=root;Pwd=";
                    MySqlConnection connection = new MySqlConnection(ConnectionString);
                    connection.Open();
                    try
                    {
                        int selID = dgvEPosition.SelectedCells[0].RowIndex;
                        MySqlCommand cmd = connection.CreateCommand();
                        cmd.CommandText = "DELETE FROM employee_position WHERE employeeID=@id";
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

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void btPosEdit_Click(object sender, EventArgs e)
        {
            if (dgvEPosition.SelectedCells.Count > 0)
            {
                string id = dgvEPosition.SelectedCells[0].Value.ToString();
                string desc = dgvEPosition.SelectedCells[1].Value.ToString();
                string hourfee = dgvEPosition.SelectedCells[2].Value.ToString();
                string locationid = dgvEPosition.SelectedCells[3].Value.ToString();

                nudPosEmpID.Value = int.Parse(id);
                tbPosDesc.Text = desc;
                tbPosHour.Text = hourfee;
                tbPosHQID.Text = locationid;

                lbPosEmpID.Text = id;
            }
        }

        private void btProAdd_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Server=localhost;Database=dev3-05;Uid=root;Pwd=";
            MySqlConnection connection = new MySqlConnection(ConnectionString); ;
            MySqlCommand cmd;
            connection.Open();

            try
            {
                cmd = connection.CreateCommand();

                if (lbProTempEmpID.Text != "")
                {
                    cmd.CommandText = "UPDATE projects SET name=@name, budget=@budget, allocatedHours=@hours WHERE id=@id";
                    cmd.Parameters.AddWithValue("@id", lbProTempEmpID.Text);
                    cmd.Parameters.AddWithValue("@name", tbProName.Text);
                    cmd.Parameters.AddWithValue("@budget", nudProBudget.Value);
                    cmd.Parameters.AddWithValue("@hours", nudProHours.Value);

                    tbProName.Text = "";
                    nudProHours.Value = 0;
                    nudProBudget.Value = 0;
                    lbProTempEmpID.Text = "";
                }
                else
                {
                    cmd.CommandText = "INSERT INTO projects(name,budget,allocatedHours)VALUES(@name,@budget,@hours)";
                  
                    cmd.Parameters.AddWithValue("@name", tbProName.Text);
                    cmd.Parameters.AddWithValue("@budget", nudProBudget.Value);
                    cmd.Parameters.AddWithValue("@hours", nudProHours.Value);

                    lbProTempEmpID.Text = "";
                }

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

        private void btProEdit_Click(object sender, EventArgs e)
        {
            if (dgvProjects.SelectedCells.Count > 0)
            {
                string id = dgvProjects.SelectedCells[0].Value.ToString();
                string budget = dgvProjects.SelectedCells[1].Value.ToString();
                string hours = dgvProjects.SelectedCells[2].Value.ToString();
                string name = dgvProjects.SelectedCells[3].Value.ToString();

                
                nudProBudget.Value = int.Parse(budget);
                nudProHours.Value = int.Parse(hours);
                tbProName.Text = name;

                lbProTempEmpID.Text = id;
            }
        }

        private void btProDelete_Click(object sender, EventArgs e)
        {
            if (dgvProjects.SelectedCells.Count > 0)
            {
                string id = dgvProjects.SelectedCells[0].Value.ToString();

                foreach (DataGridViewRow item in this.dgvProjects.SelectedRows)
                {
                    string ConnectionString = "Server=localhost;Database=dev3-05;Uid=root;Pwd=";
                    MySqlConnection connection = new MySqlConnection(ConnectionString);
                    connection.Open();
                    try
                    {
                        int selID = dgvProjects.SelectedCells[0].RowIndex;
                        MySqlCommand cmd = connection.CreateCommand();
                        cmd.CommandText = "DELETE FROM projects WHERE id=@id";
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

        private void btProMAdd_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Server=localhost;Database=dev3-05;Uid=root;Pwd=";
            MySqlConnection connection = new MySqlConnection(ConnectionString); ;
            MySqlCommand cmd;
            connection.Open();

            try
            {
                cmd = connection.CreateCommand();

                if (lbPMTempID.Text != "")
                {
                    cmd.CommandText = "UPDATE projectmembers SET employeeID=@ide, projectID=@idp WHERE employeeID=@id AND projectID=@pid";
                    cmd.Parameters.AddWithValue("@id", lbPMTempID.Text);
                    cmd.Parameters.AddWithValue("@pid", label23.Text);

                    cmd.Parameters.AddWithValue("@ide", nudPMEID.Value);
                    cmd.Parameters.AddWithValue("@idp", nudPMPID.Value);

                    nudPMEID.Value = 0;
                    nudPMPID.Value = 0;
                    lbPMTempID.Text = "";
                }
                else
                {
                    cmd.CommandText = "INSERT INTO projectmembers(employeeID,projectID)VALUES(@ide,@idp)";

                    cmd.Parameters.AddWithValue("@ide", nudPMEID.Value);
                    cmd.Parameters.AddWithValue("@idp", nudPMPID.Value);

                    lbPMTempID.Text = "";
                }

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

        private void btProMEdit_Click(object sender, EventArgs e)
        {
            if (dgvProMembers.SelectedCells.Count > 0)
            {
                string id = dgvProMembers.SelectedCells[0].Value.ToString();
                string projID = dgvProMembers.SelectedCells[1].Value.ToString();

                nudPMEID.Text = id;
                nudPMPID.Text = projID;

                lbPMTempID.Text = id;
                label23.Text = projID;
            }
        }

        private void btProMDelete_Click(object sender, EventArgs e)
        {
            if (dgvProMembers.SelectedCells.Count > 0)
            {
                string id = dgvProMembers.SelectedCells[0].Value.ToString();

                foreach (DataGridViewRow item in this.dgvProMembers.SelectedRows)
                {
                    string ConnectionString = "Server=localhost;Database=dev3-05;Uid=root;Pwd=";
                    MySqlConnection connection = new MySqlConnection(ConnectionString);
                    connection.Open();
                    try
                    {
                        int selID = dgvProMembers.SelectedCells[0].RowIndex;
                        MySqlCommand cmd = connection.CreateCommand();
                        cmd.CommandText = "DELETE FROM projectmembers WHERE employeeID=@id AND projectID=@pid";
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@pid", dgvProMembers.SelectedCells[1].Value.ToString());

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
    }
}
