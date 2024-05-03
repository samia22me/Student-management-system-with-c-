using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace stms
{
    public partial class Form4 : Form
    {

        public static Form4 instance;
        public static string name, email, address, grade;
      
        //string connString = "server=localhost;port=3306;database=sms;user=root;password=";

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            string connection = "server=localhost;port=3306;database=sms;user=root;password=";
            var con = new MySqlConnection(connection);
            
            try
            {
                con.Open();
                string stm = "select grade.mark from grade where name= @name ";

                var cmd = new MySqlCommand(stm, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("You have got"+ stm);


            }
            catch
            {
                MessageBox.Show("Invalid Credentials!");
            }*/
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public Form4(string name, string email, string address,string mark)
        {
   
            InitializeComponent();
            instance = this;
            label2.Text = name;
            label3.Text = email;
            label4.Text = address;
            label5.Text=mark;
            

        }
        
        
            private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
