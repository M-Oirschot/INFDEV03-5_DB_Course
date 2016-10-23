namespace DEV3_5_Assignment1
{
    partial class Assigment1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btAdd = new System.Windows.Forms.Button();
            this.tbAfirstname = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btEditEmployee = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            this.tbAsurname = new System.Windows.Forms.TextBox();
            this.tbAbsn = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbEditAddress = new System.Windows.Forms.Button();
            this.btDeleteAddress = new System.Windows.Forms.Button();
            this.dgEAdresses = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.nudEmpID = new System.Windows.Forms.NumericUpDown();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.tbZIP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nudHouseNumber = new System.Windows.Forms.NumericUpDown();
            this.btAddAddress = new System.Windows.Forms.Button();
            this.lbTempEmpID = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dgvEDegrees = new System.Windows.Forms.DataGridView();
            this.dgvEPosition = new System.Windows.Forms.DataGridView();
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.lbTempAdressID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEAdresses)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHouseNumber)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEDegrees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(166, 355);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(143, 23);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Save/Add new employee";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbAfirstname
            // 
            this.tbAfirstname.Location = new System.Drawing.Point(134, 303);
            this.tbAfirstname.Name = "tbAfirstname";
            this.tbAfirstname.Size = new System.Drawing.Size(175, 20);
            this.tbAfirstname.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(695, 258);
            this.dataGridView1.TabIndex = 9;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(955, 520);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbTempEmpID);
            this.tabPage1.Controls.Add(this.btEditEmployee);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btDelete);
            this.tabPage1.Controls.Add(this.tbAsurname);
            this.tabPage1.Controls.Add(this.tbAbsn);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btAdd);
            this.tabPage1.Controls.Add(this.tbAfirstname);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(947, 494);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employees";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btEditEmployee
            // 
            this.btEditEmployee.Location = new System.Drawing.Point(435, 270);
            this.btEditEmployee.Name = "btEditEmployee";
            this.btEditEmployee.Size = new System.Drawing.Size(130, 23);
            this.btEditEmployee.TabIndex = 10;
            this.btEditEmployee.Text = "Edit selected row";
            this.btEditEmployee.UseVisualStyleBackColor = true;
            this.btEditEmployee.Click += new System.EventHandler(this.btEditEmployee_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Firstname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "BSN:";
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(571, 270);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(130, 23);
            this.btDelete.TabIndex = 6;
            this.btDelete.Text = "Delete selected row";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // tbAsurname
            // 
            this.tbAsurname.Location = new System.Drawing.Point(134, 329);
            this.tbAsurname.Name = "tbAsurname";
            this.tbAsurname.Size = new System.Drawing.Size(175, 20);
            this.tbAsurname.TabIndex = 3;
            // 
            // tbAbsn
            // 
            this.tbAbsn.Location = new System.Drawing.Point(134, 277);
            this.tbAbsn.Name = "tbAbsn";
            this.tbAbsn.Size = new System.Drawing.Size(175, 20);
            this.tbAbsn.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbTempAdressID);
            this.tabPage2.Controls.Add(this.btAddAddress);
            this.tabPage2.Controls.Add(this.nudHouseNumber);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tbZIP);
            this.tabPage2.Controls.Add(this.tbStreet);
            this.tabPage2.Controls.Add(this.tbCity);
            this.tabPage2.Controls.Add(this.tbCountry);
            this.tabPage2.Controls.Add(this.nudEmpID);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tbEditAddress);
            this.tabPage2.Controls.Add(this.btDeleteAddress);
            this.tabPage2.Controls.Add(this.dgEAdresses);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(947, 494);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Adresses";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbEditAddress
            // 
            this.tbEditAddress.Location = new System.Drawing.Point(443, 274);
            this.tbEditAddress.Name = "tbEditAddress";
            this.tbEditAddress.Size = new System.Drawing.Size(172, 23);
            this.tbEditAddress.TabIndex = 2;
            this.tbEditAddress.Text = "Edit selected row";
            this.tbEditAddress.UseVisualStyleBackColor = true;
            this.tbEditAddress.Click += new System.EventHandler(this.tbEditAddress_Click);
            // 
            // btDeleteAddress
            // 
            this.btDeleteAddress.Location = new System.Drawing.Point(621, 274);
            this.btDeleteAddress.Name = "btDeleteAddress";
            this.btDeleteAddress.Size = new System.Drawing.Size(172, 23);
            this.btDeleteAddress.TabIndex = 1;
            this.btDeleteAddress.Text = "Delete selected row";
            this.btDeleteAddress.UseVisualStyleBackColor = true;
            this.btDeleteAddress.Click += new System.EventHandler(this.btDeleteAddress_Click);
            // 
            // dgEAdresses
            // 
            this.dgEAdresses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEAdresses.Location = new System.Drawing.Point(6, 6);
            this.dgEAdresses.Name = "dgEAdresses";
            this.dgEAdresses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEAdresses.Size = new System.Drawing.Size(787, 262);
            this.dgEAdresses.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvEDegrees);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(947, 494);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Degrees";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Employee ID";
            // 
            // nudEmpID
            // 
            this.nudEmpID.Location = new System.Drawing.Point(93, 282);
            this.nudEmpID.Name = "nudEmpID";
            this.nudEmpID.Size = new System.Drawing.Size(120, 20);
            this.nudEmpID.TabIndex = 5;
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(93, 308);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(120, 20);
            this.tbCountry.TabIndex = 6;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(93, 334);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(120, 20);
            this.tbCity.TabIndex = 7;
            // 
            // tbStreet
            // 
            this.tbStreet.Location = new System.Drawing.Point(93, 360);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(120, 20);
            this.tbStreet.TabIndex = 8;
            // 
            // tbZIP
            // 
            this.tbZIP.Location = new System.Drawing.Point(93, 412);
            this.tbZIP.Name = "tbZIP";
            this.tbZIP.Size = new System.Drawing.Size(120, 20);
            this.tbZIP.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Country";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Street";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "City";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "ZIP";
            // 
            // nudHouseNumber
            // 
            this.nudHouseNumber.Location = new System.Drawing.Point(93, 386);
            this.nudHouseNumber.Name = "nudHouseNumber";
            this.nudHouseNumber.Size = new System.Drawing.Size(120, 20);
            this.nudHouseNumber.TabIndex = 16;
            // 
            // btAddAddress
            // 
            this.btAddAddress.Location = new System.Drawing.Point(93, 438);
            this.btAddAddress.Name = "btAddAddress";
            this.btAddAddress.Size = new System.Drawing.Size(120, 23);
            this.btAddAddress.TabIndex = 17;
            this.btAddAddress.Text = "Add new address";
            this.btAddAddress.UseVisualStyleBackColor = true;
            this.btAddAddress.Click += new System.EventHandler(this.button4_Click);
            // 
            // lbTempEmpID
            // 
            this.lbTempEmpID.AutoSize = true;
            this.lbTempEmpID.Location = new System.Drawing.Point(15, 360);
            this.lbTempEmpID.Name = "lbTempEmpID";
            this.lbTempEmpID.Size = new System.Drawing.Size(0, 13);
            this.lbTempEmpID.TabIndex = 11;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvEPosition);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(947, 494);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Position";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dgvProjects);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(947, 494);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Projects";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dgvEDegrees
            // 
            this.dgvEDegrees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEDegrees.Location = new System.Drawing.Point(6, 6);
            this.dgvEDegrees.Name = "dgvEDegrees";
            this.dgvEDegrees.Size = new System.Drawing.Size(727, 213);
            this.dgvEDegrees.TabIndex = 0;
            // 
            // dgvEPosition
            // 
            this.dgvEPosition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEPosition.Location = new System.Drawing.Point(3, 6);
            this.dgvEPosition.Name = "dgvEPosition";
            this.dgvEPosition.Size = new System.Drawing.Size(732, 227);
            this.dgvEPosition.TabIndex = 0;
            // 
            // dgvProjects
            // 
            this.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjects.Location = new System.Drawing.Point(6, 6);
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.Size = new System.Drawing.Size(839, 230);
            this.dgvProjects.TabIndex = 0;
            // 
            // lbTempAdressID
            // 
            this.lbTempAdressID.AutoSize = true;
            this.lbTempAdressID.Location = new System.Drawing.Point(6, 448);
            this.lbTempAdressID.Name = "lbTempAdressID";
            this.lbTempAdressID.Size = new System.Drawing.Size(0, 13);
            this.lbTempAdressID.TabIndex = 18;
            // 
            // Assigment1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 531);
            this.Controls.Add(this.tabControl1);
            this.Name = "Assigment1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEAdresses)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHouseNumber)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEDegrees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox tbAfirstname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.TextBox tbAsurname;
        private System.Windows.Forms.TextBox tbAbsn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDeleteAddress;
        private System.Windows.Forms.DataGridView dgEAdresses;
        private System.Windows.Forms.Button btEditEmployee;
        private System.Windows.Forms.Button tbEditAddress;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.NumericUpDown nudEmpID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btAddAddress;
        private System.Windows.Forms.NumericUpDown nudHouseNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbZIP;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.Label lbTempEmpID;
        private System.Windows.Forms.DataGridView dgvEDegrees;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dgvEPosition;
        private System.Windows.Forms.DataGridView dgvProjects;
        private System.Windows.Forms.Label lbTempAdressID;
    }
}

