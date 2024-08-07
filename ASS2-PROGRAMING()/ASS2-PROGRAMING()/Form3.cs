using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ASS2_PROGRAMING__
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtname.Text;
            string password = txtpass.Text;

            // Thêm thông tin người dùng vào mảng
            User.AddUser(username, password);

            MessageBox.Show("Sign Up Success!");

            this.Close();
        }
    }
}
