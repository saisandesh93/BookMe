using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.DAO;
using WindowsFormsApp2.Models;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer CustOne = new Customer();
            CustomerDAO MyDAO = new CustomerDAO();

            // string name = txtName.Text;
            // int age = Int16.Parse(txtAge.Text);
            // string gender = null;

            if (String.IsNullOrEmpty(txtName.Text) || txtName.Text.Any(c => Char.IsNumber(c)))
            {
                MessageBox.Show("Please enter Name");
                txtName.Focus();
            }
            else
            {
                CustOne.Name = txtName.Text;
             
            }

            if (String.IsNullOrEmpty(txtAge.Text) || !txtAge.Text.Any(c => Char.IsNumber(c)))
            {
                MessageBox.Show("Please enter valid Age");
                txtAge.Focus();
            }
            else
            {
                CustOne.Age = Int16.Parse(txtAge.Text);

            }
            
            if (radMale.Checked || radFemale.Checked)
            {
                CustOne.Gender = (radMale.Checked) ? radMale.Text.ToString() : radFemale.Text.ToString();
   
            }
            else
            {
                MessageBox.Show("Please select Gender");
            }

            MyDAO.insertCustomer(CustOne);

        }
    }
}
