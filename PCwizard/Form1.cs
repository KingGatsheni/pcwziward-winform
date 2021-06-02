using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCwizard
{
    public partial class LoginForm : Form
    {
        string manager;
        string password;
        String admin;
        string passwordAdmin;
        string temp;
        string stars;
        Manager mngPanel = new Manager();
        Administrator adminForm = new Administrator();
        
        public LoginForm()
        {
            InitializeComponent();
            manager = "Lindokuhle Msomi";
            password = "1234";
            admin = "Simethembile Hlatshwayo";
            passwordAdmin = "5678";
            temp = "";
            stars = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
       
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Equals(manager) && textBox2.Text.Trim().Equals(password))
            {
                
                mngPanel.Show();
                //Form1.Close();
            }
            else if (textBox1.Text.Trim().Equals(admin) && textBox2.Text.Trim().Equals(passwordAdmin))
            {
                adminForm.Show();
            }
            else
            {
                MessageBox.Show("incorrect username or password, try again");
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
          
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
