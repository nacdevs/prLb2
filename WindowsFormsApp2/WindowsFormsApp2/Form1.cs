using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        List<String> list = new List<string>();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textFirst_TextChanged(object sender, EventArgs e)
        {
            this.textFirst.ForeColor = Color.Black;
        }


       
        private void Form1_Load(object sender, EventArgs e)
        {

            this.textFirst.ForeColor = Color.LightGray;
            this.textLast.ForeColor = Color.LightGray;
            this.textEmail.ForeColor = Color.LightGray;
            this.textPassword.ForeColor = Color.LightGray;
            this.textPhone.ForeColor = Color.LightGray;

            for (int i = 0; i < 120; i++)
            {
                list.Add("+" + i);
            }
            comboAreaCode.DataSource = list;
        }

        private void textLast_TextChanged(object sender, EventArgs e)
        {   
            
            this.textLast.ForeColor = Color.Black;
        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {
            this.textEmail.ForeColor = Color.Black;
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {
            this.textPassword.ForeColor = Color.Black;
        }

        private void textPhone_TextChanged(object sender, EventArgs e)
        {
            this.textPhone.ForeColor = Color.Black;
        }





        private void button1_Click(object sender, EventArgs e)
        {
            string first = this.textFirst.Text.ToString();
            string last = this.textLast.Text.ToString();
            string email = this.textEmail.Text.ToString();
            string password = this.textPassword.Text.ToString();
            string phone = this.textPhone.Text.ToString();

            Form2 form2 = new Form2(first, last, email, password, phone, "333", "e.e");
            form2.Show();
            
        }

    }
}
