﻿using PBL3_NetManagement.BLL;
using PBL3_NetManagement.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_NetManagement.GUI
{
    public partial class FormAddEditComputer : Form
    {
        public delegate void del1();
        public del1 ReEnable;
        Computer computertemp;
        public FormAddEditComputer()
        {
            InitializeComponent();
        }
        public FormAddEditComputer(Computer computer)
        {
            this.Text = "Edit Computer";
            InitializeComponent();
            computertemp = computer;
            textBoxIP.Text = computertemp.idComputer;
            textBoxName.Text = computertemp.ComputerName;
            textBoxPrice.Text = computertemp.ComputerPrice.ToString();
            textBoxIP.Enabled = false;
        }
        private void Add_Computer()
        {
            Computer cpt = new Computer();
            cpt.idComputer = textBoxIP.Text;
            cpt.ComputerName = textBoxName.Text;
            cpt.ComputerPrice = Convert.ToDouble(textBoxPrice.Text);
            BLL_NM.Instance.Add_Computer(cpt);
        }
        private void Edit_Computer()
        {
            Computer cpt = new Computer();
            cpt.idComputer = textBoxIP.Text;
            cpt.ComputerName = textBoxName.Text;
            cpt.ComputerPrice = Convert.ToDouble(textBoxPrice.Text);
            BLL_NM.Instance.Edit_Computer(cpt);
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (BLL_NM.Instance.ComputerCheck(textBoxIP.Text))
            {
                MessageBox.Show("This IP is already existed!");
                return;
            }
            if (textBoxIP.Text == "")
            {
                MessageBox.Show("IP can not be blank!");
                return;
            }
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Computer's name can not be blank!");
                return;
            }
            if (textBoxPrice.Text == "")
            {
                MessageBox.Show("Computer price can not be blank!");
                return;
            }
            string temp = textBoxPrice.Text;
            if (temp[0] == '.')
            {
                MessageBox.Show("Invalid price!");
                return;
            }
            for (int i = 0; i < textBoxPrice.Text.Length; i++)
            {
                if (!((temp[i] <= '9' && temp[i] >= '0') || temp[i] == '.'))
                {
                    MessageBox.Show("Invalid price!");
                    return;
                }

            }
            if (textBoxIP.Text.Length > 50)
            {
                MessageBox.Show("Ip is too long!");
                return;
            }
            if (textBoxName.Text.Length > 50)
            {
                MessageBox.Show("Computer's name is too long!");
                return;
            }
            if (textBoxPrice.Text.Length > 20)
            {
                MessageBox.Show("Price is invalid!");
                return;
            }
            if (textBoxIP.Enabled==true)
            {
                Add_Computer();
            }
            else
            {
                Edit_Computer();
            }
            ReEnable();
            Dispose();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }
        private void Cancel()
        {
            ReEnable();
            this.Dispose();
        }

        private void FormAddEditComputer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cancel();
        }
    }
}
