﻿
namespace PBL3_NetManagement
{
    partial class FormAdmin
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Computers = new System.Windows.Forms.TabPage();
            this.Accouts = new System.Windows.Forms.TabPage();
            this.buttonAddbill = new System.Windows.Forms.Button();
            this.buttonSearch_Account = new System.Windows.Forms.Button();
            this.textBox_Account = new System.Windows.Forms.TextBox();
            this.dataGridView_Account = new System.Windows.Forms.DataGridView();
            this.buttonDel_Account = new System.Windows.Forms.Button();
            this.buttonEdit_Account = new System.Windows.Forms.Button();
            this.buttonAdd_Accout = new System.Windows.Forms.Button();
            this.Goods = new System.Windows.Forms.TabPage();
            this.buttonSearch_Goods = new System.Windows.Forms.Button();
            this.textBox_Goods = new System.Windows.Forms.TextBox();
            this.buttonDel_Goods = new System.Windows.Forms.Button();
            this.buttonEdit_Goods = new System.Windows.Forms.Button();
            this.buttonAdd_Goods = new System.Windows.Forms.Button();
            this.dataGridView_Goods = new System.Windows.Forms.DataGridView();
            this.SystemLog = new System.Windows.Forms.TabPage();
            this.listView_SystemLog = new System.Windows.Forms.ListView();
            this.buttonSearch_SystemLog = new System.Windows.Forms.Button();
            this.textBox_SystemLog = new System.Windows.Forms.TextBox();
            this.Bills = new System.Windows.Forms.TabPage();
            this.buttonSearch_Bills = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.buttonEditComputer = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxStatusComputer = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPriceComputer = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNameComputer = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIDComputer = new System.Windows.Forms.TextBox();
            this.buttonDeleteComputer = new System.Windows.Forms.Button();
            this.flowLayoutComputer = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddComputer = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Computers.SuspendLayout();
            this.Accouts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Account)).BeginInit();
            this.Goods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Goods)).BeginInit();
            this.SystemLog.SuspendLayout();
            this.Bills.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Computers);
            this.tabControl1.Controls.Add(this.Accouts);
            this.tabControl1.Controls.Add(this.Goods);
            this.tabControl1.Controls.Add(this.SystemLog);
            this.tabControl1.Controls.Add(this.Bills);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(981, 659);
            this.tabControl1.TabIndex = 0;
            // 
            // Computers
            // 
            this.Computers.BackgroundImage = global::PBL3_NetManagement.Properties.Resources.Backgroud;
            this.Computers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Computers.Controls.Add(this.buttonEditComputer);
            this.Computers.Controls.Add(this.panel4);
            this.Computers.Controls.Add(this.panel3);
            this.Computers.Controls.Add(this.panel2);
            this.Computers.Controls.Add(this.panel1);
            this.Computers.Controls.Add(this.buttonAddComputer);
            this.Computers.Controls.Add(this.buttonDeleteComputer);
            this.Computers.Controls.Add(this.flowLayoutComputer);
            this.Computers.Font = new System.Drawing.Font("MTO Chaney", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Computers.Location = new System.Drawing.Point(4, 25);
            this.Computers.Name = "Computers";
            this.Computers.Padding = new System.Windows.Forms.Padding(3);
            this.Computers.Size = new System.Drawing.Size(973, 630);
            this.Computers.TabIndex = 0;
            this.Computers.Text = "Computers";
            this.Computers.UseVisualStyleBackColor = true;
            // 
            // Accouts
            // 
            this.Accouts.BackgroundImage = global::PBL3_NetManagement.Properties.Resources.Backgroud;
            this.Accouts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Accouts.Controls.Add(this.buttonAddbill);
            this.Accouts.Controls.Add(this.buttonSearch_Account);
            this.Accouts.Controls.Add(this.textBox_Account);
            this.Accouts.Controls.Add(this.dataGridView_Account);
            this.Accouts.Controls.Add(this.buttonDel_Account);
            this.Accouts.Controls.Add(this.buttonEdit_Account);
            this.Accouts.Controls.Add(this.buttonAdd_Accout);
            this.Accouts.Location = new System.Drawing.Point(4, 25);
            this.Accouts.Name = "Accouts";
            this.Accouts.Padding = new System.Windows.Forms.Padding(3);
            this.Accouts.Size = new System.Drawing.Size(973, 630);
            this.Accouts.TabIndex = 1;
            this.Accouts.Text = "Account";
            this.Accouts.UseVisualStyleBackColor = true;
            // 
            // buttonAddbill
            // 
            this.buttonAddbill.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAddbill.Font = new System.Drawing.Font("MTO Chaney", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddbill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddbill.Location = new System.Drawing.Point(427, 33);
            this.buttonAddbill.Name = "buttonAddbill";
            this.buttonAddbill.Size = new System.Drawing.Size(100, 44);
            this.buttonAddbill.TabIndex = 7;
            this.buttonAddbill.Text = "Add Bill";
            this.buttonAddbill.UseVisualStyleBackColor = false;
            // 
            // buttonSearch_Account
            // 
            this.buttonSearch_Account.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSearch_Account.Font = new System.Drawing.Font("MTO Chaney", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch_Account.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSearch_Account.Location = new System.Drawing.Point(833, 32);
            this.buttonSearch_Account.Name = "buttonSearch_Account";
            this.buttonSearch_Account.Size = new System.Drawing.Size(100, 45);
            this.buttonSearch_Account.TabIndex = 6;
            this.buttonSearch_Account.Text = "Search";
            this.buttonSearch_Account.UseVisualStyleBackColor = false;
            // 
            // textBox_Account
            // 
            this.textBox_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Account.Location = new System.Drawing.Point(566, 40);
            this.textBox_Account.Name = "textBox_Account";
            this.textBox_Account.Size = new System.Drawing.Size(241, 30);
            this.textBox_Account.TabIndex = 5;
            // 
            // dataGridView_Account
            // 
            this.dataGridView_Account.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView_Account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Account.Location = new System.Drawing.Point(45, 121);
            this.dataGridView_Account.Name = "dataGridView_Account";
            this.dataGridView_Account.RowHeadersWidth = 51;
            this.dataGridView_Account.RowTemplate.Height = 24;
            this.dataGridView_Account.Size = new System.Drawing.Size(888, 471);
            this.dataGridView_Account.TabIndex = 4;
            // 
            // buttonDel_Account
            // 
            this.buttonDel_Account.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDel_Account.Font = new System.Drawing.Font("MTO Chaney", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDel_Account.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDel_Account.Location = new System.Drawing.Point(300, 33);
            this.buttonDel_Account.Name = "buttonDel_Account";
            this.buttonDel_Account.Size = new System.Drawing.Size(100, 44);
            this.buttonDel_Account.TabIndex = 3;
            this.buttonDel_Account.Text = "Delete";
            this.buttonDel_Account.UseVisualStyleBackColor = false;
            // 
            // buttonEdit_Account
            // 
            this.buttonEdit_Account.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEdit_Account.Font = new System.Drawing.Font("MTO Chaney", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit_Account.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEdit_Account.Location = new System.Drawing.Point(172, 33);
            this.buttonEdit_Account.Name = "buttonEdit_Account";
            this.buttonEdit_Account.Size = new System.Drawing.Size(100, 44);
            this.buttonEdit_Account.TabIndex = 2;
            this.buttonEdit_Account.Text = "Edit";
            this.buttonEdit_Account.UseVisualStyleBackColor = false;
            // 
            // buttonAdd_Accout
            // 
            this.buttonAdd_Accout.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAdd_Accout.Font = new System.Drawing.Font("MTO Chaney", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd_Accout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd_Accout.Location = new System.Drawing.Point(45, 33);
            this.buttonAdd_Accout.Name = "buttonAdd_Accout";
            this.buttonAdd_Accout.Size = new System.Drawing.Size(100, 44);
            this.buttonAdd_Accout.TabIndex = 1;
            this.buttonAdd_Accout.Text = "Add";
            this.buttonAdd_Accout.UseVisualStyleBackColor = false;
            // 
            // Goods
            // 
            this.Goods.BackgroundImage = global::PBL3_NetManagement.Properties.Resources.Backgroud;
            this.Goods.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Goods.Controls.Add(this.buttonSearch_Goods);
            this.Goods.Controls.Add(this.textBox_Goods);
            this.Goods.Controls.Add(this.buttonDel_Goods);
            this.Goods.Controls.Add(this.buttonEdit_Goods);
            this.Goods.Controls.Add(this.buttonAdd_Goods);
            this.Goods.Controls.Add(this.dataGridView_Goods);
            this.Goods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Goods.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Goods.Location = new System.Drawing.Point(4, 25);
            this.Goods.Name = "Goods";
            this.Goods.Size = new System.Drawing.Size(973, 630);
            this.Goods.TabIndex = 3;
            this.Goods.Text = "Goods";
            this.Goods.UseVisualStyleBackColor = true;
            // 
            // buttonSearch_Goods
            // 
            this.buttonSearch_Goods.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSearch_Goods.Font = new System.Drawing.Font("MTO Chaney", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch_Goods.Location = new System.Drawing.Point(827, 35);
            this.buttonSearch_Goods.Name = "buttonSearch_Goods";
            this.buttonSearch_Goods.Size = new System.Drawing.Size(100, 44);
            this.buttonSearch_Goods.TabIndex = 5;
            this.buttonSearch_Goods.Text = "Search";
            this.buttonSearch_Goods.UseVisualStyleBackColor = false;
            // 
            // textBox_Goods
            // 
            this.textBox_Goods.Location = new System.Drawing.Point(459, 41);
            this.textBox_Goods.Name = "textBox_Goods";
            this.textBox_Goods.Size = new System.Drawing.Size(353, 30);
            this.textBox_Goods.TabIndex = 4;
            // 
            // buttonDel_Goods
            // 
            this.buttonDel_Goods.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDel_Goods.Font = new System.Drawing.Font("MTO Chaney", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDel_Goods.Location = new System.Drawing.Point(308, 35);
            this.buttonDel_Goods.Name = "buttonDel_Goods";
            this.buttonDel_Goods.Size = new System.Drawing.Size(100, 44);
            this.buttonDel_Goods.TabIndex = 3;
            this.buttonDel_Goods.Text = "Delete";
            this.buttonDel_Goods.UseVisualStyleBackColor = false;
            // 
            // buttonEdit_Goods
            // 
            this.buttonEdit_Goods.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEdit_Goods.Font = new System.Drawing.Font("MTO Chaney", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit_Goods.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEdit_Goods.Location = new System.Drawing.Point(173, 35);
            this.buttonEdit_Goods.Name = "buttonEdit_Goods";
            this.buttonEdit_Goods.Size = new System.Drawing.Size(100, 44);
            this.buttonEdit_Goods.TabIndex = 2;
            this.buttonEdit_Goods.Text = "Edit";
            this.buttonEdit_Goods.UseVisualStyleBackColor = false;
            // 
            // buttonAdd_Goods
            // 
            this.buttonAdd_Goods.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAdd_Goods.Font = new System.Drawing.Font("MTO Chaney", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd_Goods.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd_Goods.Location = new System.Drawing.Point(41, 35);
            this.buttonAdd_Goods.Name = "buttonAdd_Goods";
            this.buttonAdd_Goods.Size = new System.Drawing.Size(100, 44);
            this.buttonAdd_Goods.TabIndex = 1;
            this.buttonAdd_Goods.Text = "Add";
            this.buttonAdd_Goods.UseVisualStyleBackColor = false;
            // 
            // dataGridView_Goods
            // 
            this.dataGridView_Goods.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_Goods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Goods.Location = new System.Drawing.Point(41, 114);
            this.dataGridView_Goods.Name = "dataGridView_Goods";
            this.dataGridView_Goods.RowHeadersWidth = 51;
            this.dataGridView_Goods.RowTemplate.Height = 24;
            this.dataGridView_Goods.Size = new System.Drawing.Size(886, 480);
            this.dataGridView_Goods.TabIndex = 0;
            // 
            // SystemLog
            // 
            this.SystemLog.BackgroundImage = global::PBL3_NetManagement.Properties.Resources.Backgroud;
            this.SystemLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SystemLog.Controls.Add(this.listView_SystemLog);
            this.SystemLog.Controls.Add(this.buttonSearch_SystemLog);
            this.SystemLog.Controls.Add(this.textBox_SystemLog);
            this.SystemLog.Location = new System.Drawing.Point(4, 25);
            this.SystemLog.Name = "SystemLog";
            this.SystemLog.Size = new System.Drawing.Size(973, 630);
            this.SystemLog.TabIndex = 2;
            this.SystemLog.Text = "System Log";
            this.SystemLog.UseVisualStyleBackColor = true;
            // 
            // listView_SystemLog
            // 
            this.listView_SystemLog.HideSelection = false;
            this.listView_SystemLog.Location = new System.Drawing.Point(54, 129);
            this.listView_SystemLog.Name = "listView_SystemLog";
            this.listView_SystemLog.Size = new System.Drawing.Size(869, 475);
            this.listView_SystemLog.TabIndex = 3;
            this.listView_SystemLog.UseCompatibleStateImageBehavior = false;
            // 
            // buttonSearch_SystemLog
            // 
            this.buttonSearch_SystemLog.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSearch_SystemLog.Font = new System.Drawing.Font("MTO Chaney", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch_SystemLog.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSearch_SystemLog.Location = new System.Drawing.Point(445, 29);
            this.buttonSearch_SystemLog.Name = "buttonSearch_SystemLog";
            this.buttonSearch_SystemLog.Size = new System.Drawing.Size(100, 44);
            this.buttonSearch_SystemLog.TabIndex = 2;
            this.buttonSearch_SystemLog.Text = "Search";
            this.buttonSearch_SystemLog.UseVisualStyleBackColor = false;
            // 
            // textBox_SystemLog
            // 
            this.textBox_SystemLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SystemLog.Location = new System.Drawing.Point(54, 35);
            this.textBox_SystemLog.Name = "textBox_SystemLog";
            this.textBox_SystemLog.Size = new System.Drawing.Size(347, 30);
            this.textBox_SystemLog.TabIndex = 1;
            // 
            // Bills
            // 
            this.Bills.BackgroundImage = global::PBL3_NetManagement.Properties.Resources.Backgroud;
            this.Bills.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bills.Controls.Add(this.buttonSearch_Bills);
            this.Bills.Controls.Add(this.textBox1);
            this.Bills.Controls.Add(this.listView1);
            this.Bills.Location = new System.Drawing.Point(4, 25);
            this.Bills.Name = "Bills";
            this.Bills.Size = new System.Drawing.Size(973, 630);
            this.Bills.TabIndex = 4;
            this.Bills.Text = "Bills";
            this.Bills.UseVisualStyleBackColor = true;
            // 
            // buttonSearch_Bills
            // 
            this.buttonSearch_Bills.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSearch_Bills.Font = new System.Drawing.Font("MTO Chaney", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch_Bills.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSearch_Bills.Location = new System.Drawing.Point(431, 32);
            this.buttonSearch_Bills.Name = "buttonSearch_Bills";
            this.buttonSearch_Bills.Size = new System.Drawing.Size(100, 44);
            this.buttonSearch_Bills.TabIndex = 2;
            this.buttonSearch_Bills.Text = "Search";
            this.buttonSearch_Bills.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(53, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 30);
            this.textBox1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(53, 107);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(870, 490);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // buttonEditComputer
            // 
            this.buttonEditComputer.AutoSize = true;
            this.buttonEditComputer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEditComputer.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonEditComputer.Location = new System.Drawing.Point(835, 268);
            this.buttonEditComputer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditComputer.Name = "buttonEditComputer";
            this.buttonEditComputer.Size = new System.Drawing.Size(97, 37);
            this.buttonEditComputer.TabIndex = 15;
            this.buttonEditComputer.Text = "EDIT";
            this.buttonEditComputer.UseVisualStyleBackColor = false;
            this.buttonEditComputer.Click += new System.EventHandler(this.buttonEditComputer_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelStatus);
            this.panel4.Controls.Add(this.textBoxStatusComputer);
            this.panel4.Location = new System.Drawing.Point(594, 188);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(339, 46);
            this.panel4.TabIndex = 12;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(12, 10);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(67, 27);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "Status";
            // 
            // textBoxStatusComputer
            // 
            this.textBoxStatusComputer.Enabled = false;
            this.textBoxStatusComputer.Location = new System.Drawing.Point(93, 8);
            this.textBoxStatusComputer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxStatusComputer.Name = "textBoxStatusComputer";
            this.textBoxStatusComputer.Size = new System.Drawing.Size(227, 34);
            this.textBoxStatusComputer.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBoxPriceComputer);
            this.panel3.Location = new System.Drawing.Point(594, 137);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(339, 46);
            this.panel3.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 27);
            this.label3.TabIndex = 4;
            // 
            // textBoxPriceComputer
            // 
            this.textBoxPriceComputer.Enabled = false;
            this.textBoxPriceComputer.Location = new System.Drawing.Point(93, 8);
            this.textBoxPriceComputer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPriceComputer.Name = "textBoxPriceComputer";
            this.textBoxPriceComputer.Size = new System.Drawing.Size(227, 34);
            this.textBoxPriceComputer.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxNameComputer);
            this.panel2.Location = new System.Drawing.Point(594, 85);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 46);
            this.panel2.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // textBoxNameComputer
            // 
            this.textBoxNameComputer.Enabled = false;
            this.textBoxNameComputer.Location = new System.Drawing.Point(93, 8);
            this.textBoxNameComputer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNameComputer.Name = "textBoxNameComputer";
            this.textBoxNameComputer.Size = new System.Drawing.Size(227, 34);
            this.textBoxNameComputer.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxIDComputer);
            this.panel1.Location = new System.Drawing.Point(594, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 46);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // textBoxIDComputer
            // 
            this.textBoxIDComputer.Enabled = false;
            this.textBoxIDComputer.Location = new System.Drawing.Point(93, 8);
            this.textBoxIDComputer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIDComputer.Name = "textBoxIDComputer";
            this.textBoxIDComputer.Size = new System.Drawing.Size(227, 34);
            this.textBoxIDComputer.TabIndex = 3;
            // 
            // buttonDeleteComputer
            // 
            this.buttonDeleteComputer.AutoSize = true;
            this.buttonDeleteComputer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonDeleteComputer.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonDeleteComputer.Location = new System.Drawing.Point(713, 268);
            this.buttonDeleteComputer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteComputer.Name = "buttonDeleteComputer";
            this.buttonDeleteComputer.Size = new System.Drawing.Size(97, 37);
            this.buttonDeleteComputer.TabIndex = 10;
            this.buttonDeleteComputer.Text = "DEL";
            this.buttonDeleteComputer.UseVisualStyleBackColor = false;
            this.buttonDeleteComputer.Click += new System.EventHandler(this.buttonDeleteComputer_Click);
            // 
            // flowLayoutComputer
            // 
            this.flowLayoutComputer.BackColor = System.Drawing.Color.White;
            this.flowLayoutComputer.Location = new System.Drawing.Point(39, 34);
            this.flowLayoutComputer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutComputer.Name = "flowLayoutComputer";
            this.flowLayoutComputer.Size = new System.Drawing.Size(515, 562);
            this.flowLayoutComputer.TabIndex = 8;
            // 
            // buttonAddComputer
            // 
            this.buttonAddComputer.AutoSize = true;
            this.buttonAddComputer.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAddComputer.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonAddComputer.Location = new System.Drawing.Point(594, 268);
            this.buttonAddComputer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddComputer.Name = "buttonAddComputer";
            this.buttonAddComputer.Size = new System.Drawing.Size(97, 37);
            this.buttonAddComputer.TabIndex = 10;
            this.buttonAddComputer.Text = "ADD";
            this.buttonAddComputer.UseVisualStyleBackColor = false;
            this.buttonAddComputer.Click += new System.EventHandler(this.buttonAddComputer_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PBL3_NetManagement.Properties.Resources.Backgroud;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(993, 655);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAdmin";
            this.Text = "NetManagement";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdmin_FormClosed);
            this.Shown += new System.EventHandler(this.FormAdmin_Shown);
            this.tabControl1.ResumeLayout(false);
            this.Computers.ResumeLayout(false);
            this.Computers.PerformLayout();
            this.Accouts.ResumeLayout(false);
            this.Accouts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Account)).EndInit();
            this.Goods.ResumeLayout(false);
            this.Goods.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Goods)).EndInit();
            this.SystemLog.ResumeLayout(false);
            this.SystemLog.PerformLayout();
            this.Bills.ResumeLayout(false);
            this.Bills.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Computers;
        private System.Windows.Forms.TabPage Accouts;
        private System.Windows.Forms.TabPage Goods;
        private System.Windows.Forms.TabPage SystemLog;
        private System.Windows.Forms.Button buttonSearch_Account;
        private System.Windows.Forms.TextBox textBox_Account;
        private System.Windows.Forms.DataGridView dataGridView_Account;
        private System.Windows.Forms.Button buttonDel_Account;
        private System.Windows.Forms.Button buttonEdit_Account;
        private System.Windows.Forms.Button buttonAdd_Accout;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button buttonDel_Goods;
        private System.Windows.Forms.Button buttonEdit_Goods;
        private System.Windows.Forms.Button buttonAdd_Goods;
        private System.Windows.Forms.DataGridView dataGridView_Goods;
        private System.Windows.Forms.Button buttonSearch_Goods;
        private System.Windows.Forms.TextBox textBox_Goods;
        private System.Windows.Forms.Button buttonSearch_SystemLog;
        private System.Windows.Forms.TextBox textBox_SystemLog;
        private System.Windows.Forms.Button buttonAddbill;
        private System.Windows.Forms.ListView listView_SystemLog;
        private System.Windows.Forms.TabPage Bills;
        private System.Windows.Forms.Button buttonSearch_Bills;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonEditComputer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxStatusComputer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPriceComputer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNameComputer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIDComputer;
        private System.Windows.Forms.Button buttonAddComputer;
        private System.Windows.Forms.Button buttonDeleteComputer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutComputer;
    }
}