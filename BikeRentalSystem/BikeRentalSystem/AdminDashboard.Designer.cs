﻿namespace BikeRentalSystem
{
    partial class AdminDashboard
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
            this.components = new System.ComponentModel.Container();
            this.tabControlAdminDashboard = new System.Windows.Forms.TabControl();
            this.tabPageadmin = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageCashier = new System.Windows.Forms.TabPage();
            this.panelRight = new System.Windows.Forms.Panel();
            this.dataGridViewDisplayAll = new System.Windows.Forms.DataGridView();
            this.panel = new System.Windows.Forms.Panel();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.comboBoxDropdown = new System.Windows.Forms.ComboBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelInputs = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelEmpID = new System.Windows.Forms.Label();
            this.textBoxEmployeeId = new System.Windows.Forms.TextBox();
            this.buttonAddorUpdateorDelete = new System.Windows.Forms.Button();
            this.tabPagebike = new System.Windows.Forms.TabPage();
            this.panelrightbike = new System.Windows.Forms.Panel();
            this.dataGridViewBike = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxDropdownBike = new System.Windows.Forms.ComboBox();
            this.panelleftbike = new System.Windows.Forms.Panel();
            this.panelBikeInput = new System.Windows.Forms.Panel();
            this.pictureBoxBikeImage = new System.Windows.Forms.PictureBox();
            this.buttonChooseBikeImage = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxBikeColor = new System.Windows.Forms.TextBox();
            this.textBoxBikeName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxBikeId = new System.Windows.Forms.TextBox();
            this.buttonBike = new System.Windows.Forms.Button();
            this.timerUpdater = new System.Windows.Forms.Timer(this.components);
            this.timerUpdaterBike = new System.Windows.Forms.Timer(this.components);
            this.tabControlAdminDashboard.SuspendLayout();
            this.tabPageadmin.SuspendLayout();
            this.tabPageCashier.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayAll)).BeginInit();
            this.panel.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelInputs.SuspendLayout();
            this.tabPagebike.SuspendLayout();
            this.panelrightbike.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBike)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelleftbike.SuspendLayout();
            this.panelBikeInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBikeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAdminDashboard
            // 
            this.tabControlAdminDashboard.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlAdminDashboard.Controls.Add(this.tabPageadmin);
            this.tabControlAdminDashboard.Controls.Add(this.tabPageCashier);
            this.tabControlAdminDashboard.Controls.Add(this.tabPagebike);
            this.tabControlAdminDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdminDashboard.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdminDashboard.Multiline = true;
            this.tabControlAdminDashboard.Name = "tabControlAdminDashboard";
            this.tabControlAdminDashboard.SelectedIndex = 0;
            this.tabControlAdminDashboard.Size = new System.Drawing.Size(772, 446);
            this.tabControlAdminDashboard.TabIndex = 0;
            this.tabControlAdminDashboard.TabStop = false;
            this.tabControlAdminDashboard.SelectedIndexChanged += new System.EventHandler(this.tabControlAdminDashboard_SelectedIndexChanged);
            // 
            // tabPageadmin
            // 
            this.tabPageadmin.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tabPageadmin.Controls.Add(this.label1);
            this.tabPageadmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPageadmin.Location = new System.Drawing.Point(23, 4);
            this.tabPageadmin.Name = "tabPageadmin";
            this.tabPageadmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageadmin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPageadmin.Size = new System.Drawing.Size(745, 438);
            this.tabPageadmin.TabIndex = 0;
            this.tabPageadmin.Text = "admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin";
            // 
            // tabPageCashier
            // 
            this.tabPageCashier.Controls.Add(this.panelRight);
            this.tabPageCashier.Controls.Add(this.panel);
            this.tabPageCashier.Controls.Add(this.panelLeft);
            this.tabPageCashier.Location = new System.Drawing.Point(23, 4);
            this.tabPageCashier.Name = "tabPageCashier";
            this.tabPageCashier.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCashier.Size = new System.Drawing.Size(745, 438);
            this.tabPageCashier.TabIndex = 1;
            this.tabPageCashier.Text = "Cashier";
            this.tabPageCashier.UseVisualStyleBackColor = true;
            // 
            // panelRight
            // 
            this.panelRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRight.BackColor = System.Drawing.Color.DarkGray;
            this.panelRight.Controls.Add(this.dataGridViewDisplayAll);
            this.panelRight.Location = new System.Drawing.Point(243, 35);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(497, 403);
            this.panelRight.TabIndex = 4;
            // 
            // dataGridViewDisplayAll
            // 
            this.dataGridViewDisplayAll.AllowUserToAddRows = false;
            this.dataGridViewDisplayAll.AllowUserToDeleteRows = false;
            this.dataGridViewDisplayAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDisplayAll.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDisplayAll.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewDisplayAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewDisplayAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDisplayAll.GridColor = System.Drawing.Color.MediumAquamarine;
            this.dataGridViewDisplayAll.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDisplayAll.Name = "dataGridViewDisplayAll";
            this.dataGridViewDisplayAll.ReadOnly = true;
            this.dataGridViewDisplayAll.Size = new System.Drawing.Size(497, 403);
            this.dataGridViewDisplayAll.TabIndex = 0;
            this.dataGridViewDisplayAll.TabStop = false;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel.Controls.Add(this.labelEmployee);
            this.panel.Controls.Add(this.comboBoxDropdown);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(3, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(739, 32);
            this.panel.TabIndex = 5;
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployee.ForeColor = System.Drawing.Color.White;
            this.labelEmployee.Location = new System.Drawing.Point(209, 2);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(323, 24);
            this.labelEmployee.TabIndex = 3;
            this.labelEmployee.Text = "Employee Information Record";
            // 
            // comboBoxDropdown
            // 
            this.comboBoxDropdown.FormattingEnabled = true;
            this.comboBoxDropdown.Items.AddRange(new object[] {
            "SHOW ALL",
            "ADD",
            "UPDATE",
            "DELETE"});
            this.comboBoxDropdown.Location = new System.Drawing.Point(3, 5);
            this.comboBoxDropdown.Name = "comboBoxDropdown";
            this.comboBoxDropdown.Size = new System.Drawing.Size(113, 21);
            this.comboBoxDropdown.TabIndex = 2;
            this.comboBoxDropdown.TabStop = false;
            this.comboBoxDropdown.SelectedIndexChanged += new System.EventHandler(this.comboBoxDropdown_SelectedIndexChanged);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.panelLeft.Controls.Add(this.panelInputs);
            this.panelLeft.Controls.Add(this.labelEmpID);
            this.panelLeft.Controls.Add(this.textBoxEmployeeId);
            this.panelLeft.Controls.Add(this.buttonAddorUpdateorDelete);
            this.panelLeft.Location = new System.Drawing.Point(3, 35);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(234, 403);
            this.panelLeft.TabIndex = 3;
            this.panelLeft.Visible = false;
            // 
            // panelInputs
            // 
            this.panelInputs.Controls.Add(this.label2);
            this.panelInputs.Controls.Add(this.textBoxEmail);
            this.panelInputs.Controls.Add(this.labelContact);
            this.panelInputs.Controls.Add(this.labelAddress);
            this.panelInputs.Controls.Add(this.labelName);
            this.panelInputs.Controls.Add(this.labelPassword);
            this.panelInputs.Controls.Add(this.labelUsername);
            this.panelInputs.Controls.Add(this.textBoxContact);
            this.panelInputs.Controls.Add(this.textBoxAddress);
            this.panelInputs.Controls.Add(this.textBoxName);
            this.panelInputs.Controls.Add(this.textBoxPassword);
            this.panelInputs.Controls.Add(this.textBoxUsername);
            this.panelInputs.Location = new System.Drawing.Point(0, 75);
            this.panelInputs.Name = "panelInputs";
            this.panelInputs.Size = new System.Drawing.Size(231, 274);
            this.panelInputs.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(3, 245);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(225, 23);
            this.textBoxEmail.TabIndex = 11;
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContact.Location = new System.Drawing.Point(3, 181);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(60, 16);
            this.labelContact.TabIndex = 10;
            this.labelContact.Text = "Contact";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(3, 136);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(59, 16);
            this.labelAddress.TabIndex = 9;
            this.labelAddress.Text = "Address";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(3, 91);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(43, 16);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Name";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(3, 46);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(69, 16);
            this.labelPassword.TabIndex = 7;
            this.labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(3, 1);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(71, 16);
            this.labelUsername.TabIndex = 6;
            this.labelUsername.Text = "Username";
            // 
            // textBoxContact
            // 
            this.textBoxContact.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContact.Location = new System.Drawing.Point(3, 200);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(225, 23);
            this.textBoxContact.TabIndex = 5;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.Location = new System.Drawing.Point(3, 155);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(225, 23);
            this.textBoxAddress.TabIndex = 4;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(3, 110);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(225, 23);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(3, 65);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(225, 23);
            this.textBoxPassword.TabIndex = 2;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(3, 20);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(225, 23);
            this.textBoxUsername.TabIndex = 1;
            // 
            // labelEmpID
            // 
            this.labelEmpID.AutoSize = true;
            this.labelEmpID.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpID.Location = new System.Drawing.Point(3, 29);
            this.labelEmpID.Name = "labelEmpID";
            this.labelEmpID.Size = new System.Drawing.Size(88, 16);
            this.labelEmpID.TabIndex = 14;
            this.labelEmpID.Text = "Employee ID";
            // 
            // textBoxEmployeeId
            // 
            this.textBoxEmployeeId.Enabled = false;
            this.textBoxEmployeeId.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmployeeId.Location = new System.Drawing.Point(3, 48);
            this.textBoxEmployeeId.Name = "textBoxEmployeeId";
            this.textBoxEmployeeId.Size = new System.Drawing.Size(225, 23);
            this.textBoxEmployeeId.TabIndex = 13;
            this.textBoxEmployeeId.TextChanged += new System.EventHandler(this.textBoxEmployeeId_TextChanged);
            // 
            // buttonAddorUpdateorDelete
            // 
            this.buttonAddorUpdateorDelete.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddorUpdateorDelete.Location = new System.Drawing.Point(77, 355);
            this.buttonAddorUpdateorDelete.Name = "buttonAddorUpdateorDelete";
            this.buttonAddorUpdateorDelete.Size = new System.Drawing.Size(79, 30);
            this.buttonAddorUpdateorDelete.TabIndex = 12;
            this.buttonAddorUpdateorDelete.Text = "Add";
            this.buttonAddorUpdateorDelete.UseVisualStyleBackColor = true;
            this.buttonAddorUpdateorDelete.Click += new System.EventHandler(this.buttonAddorUpdateorDelete_Click);
            // 
            // tabPagebike
            // 
            this.tabPagebike.Controls.Add(this.panelrightbike);
            this.tabPagebike.Controls.Add(this.panel2);
            this.tabPagebike.Controls.Add(this.panelleftbike);
            this.tabPagebike.Location = new System.Drawing.Point(23, 4);
            this.tabPagebike.Name = "tabPagebike";
            this.tabPagebike.Size = new System.Drawing.Size(745, 438);
            this.tabPagebike.TabIndex = 2;
            this.tabPagebike.Text = "Bike";
            this.tabPagebike.UseVisualStyleBackColor = true;
            // 
            // panelrightbike
            // 
            this.panelrightbike.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelrightbike.BackColor = System.Drawing.Color.DarkGray;
            this.panelrightbike.Controls.Add(this.dataGridViewBike);
            this.panelrightbike.Location = new System.Drawing.Point(243, 35);
            this.panelrightbike.Name = "panelrightbike";
            this.panelrightbike.Size = new System.Drawing.Size(497, 403);
            this.panelrightbike.TabIndex = 7;
            // 
            // dataGridViewBike
            // 
            this.dataGridViewBike.AllowUserToAddRows = false;
            this.dataGridViewBike.AllowUserToDeleteRows = false;
            this.dataGridViewBike.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewBike.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewBike.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBike.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBike.Name = "dataGridViewBike";
            this.dataGridViewBike.ReadOnly = true;
            this.dataGridViewBike.Size = new System.Drawing.Size(497, 403);
            this.dataGridViewBike.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.comboBoxDropdownBike);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(745, 32);
            this.panel2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(239, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bike Information Record";
            // 
            // comboBoxDropdownBike
            // 
            this.comboBoxDropdownBike.FormattingEnabled = true;
            this.comboBoxDropdownBike.Items.AddRange(new object[] {
            "SHOW ALL",
            "ADD",
            "UPDATE",
            "DELETE"});
            this.comboBoxDropdownBike.Location = new System.Drawing.Point(3, 5);
            this.comboBoxDropdownBike.Name = "comboBoxDropdownBike";
            this.comboBoxDropdownBike.Size = new System.Drawing.Size(113, 21);
            this.comboBoxDropdownBike.TabIndex = 2;
            this.comboBoxDropdownBike.TabStop = false;
            this.comboBoxDropdownBike.SelectedIndexChanged += new System.EventHandler(this.comboBoxDropdownBike_SelectedIndexChanged);
            // 
            // panelleftbike
            // 
            this.panelleftbike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.panelleftbike.Controls.Add(this.panelBikeInput);
            this.panelleftbike.Controls.Add(this.label10);
            this.panelleftbike.Controls.Add(this.textBoxBikeId);
            this.panelleftbike.Controls.Add(this.buttonBike);
            this.panelleftbike.Location = new System.Drawing.Point(3, 35);
            this.panelleftbike.Name = "panelleftbike";
            this.panelleftbike.Size = new System.Drawing.Size(234, 403);
            this.panelleftbike.TabIndex = 6;
            this.panelleftbike.Visible = false;
            // 
            // panelBikeInput
            // 
            this.panelBikeInput.Controls.Add(this.pictureBoxBikeImage);
            this.panelBikeInput.Controls.Add(this.buttonChooseBikeImage);
            this.panelBikeInput.Controls.Add(this.label7);
            this.panelBikeInput.Controls.Add(this.label8);
            this.panelBikeInput.Controls.Add(this.label9);
            this.panelBikeInput.Controls.Add(this.textBoxBikeColor);
            this.panelBikeInput.Controls.Add(this.textBoxBikeName);
            this.panelBikeInput.Location = new System.Drawing.Point(0, 75);
            this.panelBikeInput.Name = "panelBikeInput";
            this.panelBikeInput.Size = new System.Drawing.Size(231, 284);
            this.panelBikeInput.TabIndex = 15;
            // 
            // pictureBoxBikeImage
            // 
            this.pictureBoxBikeImage.Location = new System.Drawing.Point(44, 139);
            this.pictureBoxBikeImage.Name = "pictureBoxBikeImage";
            this.pictureBoxBikeImage.Size = new System.Drawing.Size(140, 132);
            this.pictureBoxBikeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBikeImage.TabIndex = 10;
            this.pictureBoxBikeImage.TabStop = false;
            // 
            // buttonChooseBikeImage
            // 
            this.buttonChooseBikeImage.Location = new System.Drawing.Point(6, 110);
            this.buttonChooseBikeImage.Name = "buttonChooseBikeImage";
            this.buttonChooseBikeImage.Size = new System.Drawing.Size(94, 23);
            this.buttonChooseBikeImage.TabIndex = 9;
            this.buttonChooseBikeImage.Text = "Choose Image";
            this.buttonChooseBikeImage.UseVisualStyleBackColor = true;
            this.buttonChooseBikeImage.Click += new System.EventHandler(this.buttonChooseBikeImage_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Bike Image:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Bike Color:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Bike Name:";
            // 
            // textBoxBikeColor
            // 
            this.textBoxBikeColor.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBikeColor.Location = new System.Drawing.Point(3, 65);
            this.textBoxBikeColor.Name = "textBoxBikeColor";
            this.textBoxBikeColor.Size = new System.Drawing.Size(225, 23);
            this.textBoxBikeColor.TabIndex = 2;
            // 
            // textBoxBikeName
            // 
            this.textBoxBikeName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBikeName.Location = new System.Drawing.Point(3, 20);
            this.textBoxBikeName.Name = "textBoxBikeName";
            this.textBoxBikeName.Size = new System.Drawing.Size(225, 23);
            this.textBoxBikeName.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Bike ID";
            // 
            // textBoxBikeId
            // 
            this.textBoxBikeId.Enabled = false;
            this.textBoxBikeId.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBikeId.Location = new System.Drawing.Point(3, 48);
            this.textBoxBikeId.Name = "textBoxBikeId";
            this.textBoxBikeId.Size = new System.Drawing.Size(225, 23);
            this.textBoxBikeId.TabIndex = 13;
            this.textBoxBikeId.TextChanged += new System.EventHandler(this.textBoxBikeId_TextChanged);
            // 
            // buttonBike
            // 
            this.buttonBike.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBike.Location = new System.Drawing.Point(74, 365);
            this.buttonBike.Name = "buttonBike";
            this.buttonBike.Size = new System.Drawing.Size(79, 30);
            this.buttonBike.TabIndex = 0;
            this.buttonBike.Text = "Add";
            this.buttonBike.UseVisualStyleBackColor = true;
            this.buttonBike.Click += new System.EventHandler(this.buttonBike_Click);
            // 
            // timerUpdater
            // 
            this.timerUpdater.Enabled = true;
            this.timerUpdater.Tick += new System.EventHandler(this.timerUpdater_Tick);
            // 
            // timerUpdaterBike
            // 
            this.timerUpdaterBike.Enabled = true;
            this.timerUpdaterBike.Tick += new System.EventHandler(this.timerUpdaterBike_Tick);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 446);
            this.Controls.Add(this.tabControlAdminDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.tabControlAdminDashboard.ResumeLayout(false);
            this.tabPageadmin.ResumeLayout(false);
            this.tabPageadmin.PerformLayout();
            this.tabPageCashier.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayAll)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelInputs.ResumeLayout(false);
            this.panelInputs.PerformLayout();
            this.tabPagebike.ResumeLayout(false);
            this.panelrightbike.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBike)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelleftbike.ResumeLayout(false);
            this.panelleftbike.PerformLayout();
            this.panelBikeInput.ResumeLayout(false);
            this.panelBikeInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBikeImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAdminDashboard;
        private System.Windows.Forms.TabPage tabPageadmin;
        private System.Windows.Forms.TabPage tabPageCashier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPagebike;
        private System.Windows.Forms.ComboBox comboBoxDropdown;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelEmpID;
        private System.Windows.Forms.TextBox textBoxEmployeeId;
        private System.Windows.Forms.Button buttonAddorUpdateorDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Timer timerUpdater;
        private System.Windows.Forms.Panel panelInputs;
        private System.Windows.Forms.DataGridView dataGridViewDisplayAll;
        private System.Windows.Forms.Timer timerUpdaterBike;
        private System.Windows.Forms.Panel panelrightbike;
        private System.Windows.Forms.DataGridView dataGridViewBike;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxDropdownBike;
        private System.Windows.Forms.Panel panelleftbike;
        private System.Windows.Forms.Panel panelBikeInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxBikeColor;
        private System.Windows.Forms.TextBox textBoxBikeName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxBikeId;
        private System.Windows.Forms.Button buttonBike;
        private System.Windows.Forms.PictureBox pictureBoxBikeImage;
        private System.Windows.Forms.Button buttonChooseBikeImage;
    }
}