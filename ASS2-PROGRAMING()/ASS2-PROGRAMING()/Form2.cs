using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASS2_PROGRAMING__
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Kiểm tra thông tin đăng nhập
            if (User.ValidateUser(username, password))
            {
                Form1 x = new Form1();
                x.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Username or password is incorrect.");
            }

        }
    }
}
