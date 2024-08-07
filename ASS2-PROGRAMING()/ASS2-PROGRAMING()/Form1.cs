using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ASS2_PROGRAMING__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();         
            txtnum.Visible = false;
            txtnumber.Visible = false;

            originalItems = new List<ListViewItem>(); // Khởi tạo danh sách ban đầu
            matchingItems = new List<ListViewItem>(); // Khởi tạo danh sách khớp
        }

        private void txtreset_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtlastmonth.Clear();
            txtthismonth.Clear();
            txtphone.Clear();
            txttype.SelectedIndex = -1;
            txtnum.Value = txtnum.Minimum;

        }
        private void txtdelete_Click(object sender, EventArgs e)
        {
            if (listView2.Items.Count > 0)
                listView2.Items.Remove(listView2.SelectedItems[0]);
        }

        private void txtcalculate_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string phone = txtphone.Text;
            string type = txttype.SelectedItem.ToString();
            string num = txtnum.Text;


            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(type)) 
            {
                MessageBox.Show("Please enter complete customer information and customer type!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }        

            if (!double.TryParse(txtlastmonth.Text, out double lastmonth) || !double.TryParse(txtthismonth.Text, out double thismonth))
            {
                MessageBox.Show("Please enter valid data for the months!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (thismonth <= lastmonth)
            {
                MessageBox.Show("Invalid readings. This month's reading should be greater than or equal to last month's reading.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int familyMembers = 0;
            if (type.Equals("Household"))
            {
                familyMembers = (int)txtnum.Value;
                if (familyMembers < 1)
                {
                    MessageBox.Show("Number of family members cannot be zero. Please increase the number.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            double pice = Price(type, thismonth, lastmonth);
            double totalBill = Bill(name, type, pice, lastmonth, thismonth, familyMembers);

            int stt = listView2.Items.Count + 1;

            ListViewItem item = new ListViewItem(stt.ToString());
            item.SubItems.Add(txtname.Text);
            item.SubItems.Add(txtphone.Text);
            item.SubItems.Add(txttype.Text);
            item.SubItems.Add(totalBill.ToString("F2"));
            listView2.Items.Add(item);
            originalItems.Add((ListViewItem)item.Clone()); // Lưu các mục ban đầu


            txtphone.Clear();
            txtname.Clear();
            txtlastmonth.Clear();
            txtthismonth.Clear();
            txttype.SelectedIndex = -1;
            txtnum.Value = txtnum.Minimum;
        }

        private double Price(string type, double thismonth, double lastmonth)
        {
            double price = 0;
            double total1 = thismonth - lastmonth;

            switch (type.ToLower())
            {
                case "household":
                    if (total1 <= 10)
                        price = 5.973;
                    else if (total1 <= 20)
                        price = 7.052;
                    else if (total1 <= 30)
                        price = 8.699;
                    else
                        price = 15.929;
                    break;
                case "administrative agency":
                    price = 9.955;
                    break;
                case "public services":
                    price = 9.955;
                    break;
                case "production units":
                    price = 11.615;
                    break;
                case "business services":
                    price = 22.068;
                    break;
                default:
                    MessageBox.Show("Invalid customer type.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            return price;
        }
        private double Bill(string name, string type, double price, double lastmonth, double thismonth, int familyMembers)
        {
            double totalConsumption = thismonth - lastmonth;
            double specialCharge = type.Equals("Household", StringComparison.OrdinalIgnoreCase) ? (totalConsumption / familyMembers) * price : totalConsumption * price;

            double environmentFee = specialCharge * 0.1;
            double vat = specialCharge * 0.1;
            double totalBill = specialCharge + environmentFee + vat;

            txtbill.Text =
                $"Water consumed: {totalConsumption} m³\r\n" +
                $"Water Bill: {specialCharge} VND\r\n" +
                $"Environment fees: {environmentFee} VND\r\n" +
                $"VAT(10%): {vat} VND\r\n" +
                $"Total bill: {totalBill} VND\r\n";
            return totalBill;
        }
        // Hiện NOP khi chọn loại khách hàng
        private void txttype_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (txttype.SelectedItem != null && txttype.SelectedItem.ToString().Equals("Household", StringComparison.OrdinalIgnoreCase))
            {
                txtnum.Visible = true;
                txtnumber.Visible = true;
            }
            else
            {
                txtnum.Visible = false;
                txtnumber.Visible = false;
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtSearchName.Text.Trim().ToLower();
            string searchPhone = txtSearchPhone.Text.Trim().ToLower();


            // Tạo danh sách các mục khớp và không khớp
            List<ListViewItem> matchingItems = new List<ListViewItem>();
            List<ListViewItem> nonMatchingItems = new List<ListViewItem>();

            foreach (ListViewItem item in listView2.Items)
            {
                bool nameMatch = string.IsNullOrWhiteSpace(searchName) || item.SubItems[1].Text.ToLower().Contains(searchName);
                bool phoneMatch = string.IsNullOrWhiteSpace(searchPhone) || item.SubItems[2].Text.ToLower().Contains(searchPhone);

                if (nameMatch && phoneMatch)
                {                   
                    
                    matchingItems.Add(item);
                }
              
            }

            // Xóa tất cả các mục hiện có
            listView2.Items.Clear();

            // Thêm các mục khớp lên đầu
            listView2.Items.AddRange(matchingItems.ToArray());

            // Thêm các mục không khớp xuống dưới
            listView2.Items.AddRange(nonMatchingItems.ToArray());
        }

        private void btSort_Click(object sender, EventArgs e)
        {

            List<ListViewItem> itemsToSort = listView2.Items.Cast<ListViewItem>().ToList();

            // Sắp xếp các mục theo STT
            itemsToSort = itemsToSort.OrderBy(item => int.Parse(item.SubItems[0].Text)).ToList();

            // Xóa tất cả các mục hiện có
            listView2.Items.Clear();

            // Thêm các mục đã sắp xếp lại vào ListView
            listView2.Items.AddRange(itemsToSort.ToArray());
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtSearchPhone_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtnumber_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       
    }

}
