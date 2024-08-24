using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblFirstName.Text = txtFirstName.Text;
            lblMiddleName.Text = txtMiddleName.Text;
            lblLastName.Text = txtLastName.Text;
            lblCourse.Text = cbCourse.SelectedItem?.ToString();
            lblContactNumber.Text = txtContactNumber.Text;
            lblEmailAddress.Text = txtEmailAddress.Text;
            lblAddress.Text = txtAddress.Text;
            if (rbMale.Checked)

            lblGender.Text = "Male";
            else if (rbFemale.Checked)
            lblGender.Text = "Female";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem1_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();

            txtMiddleName.Clear();

            txtLastName.Clear();

            txtContactNumber.Clear();

            txtEmailAddress.Clear();

            txtAddress.Clear();

cbCourse.SelectedIndex = -1;

            rbMale.Checked = false;

            rbFemale.Checked = false;

            lblFirstName.Text = "";

            lblMiddleName.Text = "";

            lblLastName.Text = "";

            lblCourse.Text = "";

            lblContactNumber.Text = "";

            lblEmailAddress.Text = "";

            lblAddress.Text = "";

            lblGender.Text = "";
        }
    }
}
