using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employee.WinClient.EmployeeServiceReference;


namespace Employee.WinClient
{
    public partial class Form1 : Form
    {
        private EmployeesServiceClient client;
        public Form1()
        {
            client = new EmployeesServiceClient();
            InitializeComponent();
        }

        private void ButtonGetById(object sender, EventArgs e)
        {           
            textBox2.Text = client.GetEmployeeById(Convert.ToInt32(textBox1.Text)).Id.ToString();
            textBox3.Text = client.GetEmployeeById(Convert.ToInt32(textBox1.Text)).FirstName;
            textBox4.Text = client.GetEmployeeById(Convert.ToInt32(textBox1.Text)).LastName;
            textBox5.Text = client.GetEmployeeById(Convert.ToInt32(textBox1.Text)).Title;
            textBox6.Text = client.GetEmployeeById(Convert.ToInt32(textBox1.Text)).Address;
            textBox7.Text = client.GetEmployeeById(Convert.ToInt32(textBox1.Text)).City;
            textBox8.Text = client.GetEmployeeById(Convert.ToInt32(textBox1.Text)).Country;
            textBox9.Text = client.GetEmployeeById(Convert.ToInt32(textBox1.Text)).Notes;
        }

        private void ButtonSave(object sender, EventArgs e)
        {
            client.UpdateEmployee(Convert.ToInt32(textBox2.Text), textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text)
        }
    }
}
