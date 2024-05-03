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
    public partial class Form3 : Form
    {
        string connString = "server=localhost;port=3306;database=sms;user=root;password=";
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string name= textBox1.Text;
            string email = textBox3.Text;
            string address= textBox4.Text;
            string password = textBox5.Text.Trim();
            string cpassword = textBox6.Text.Trim();

    
            if (password != cpassword) { 
                
                MessageBox.Show("Passwords do not match!");
                return;
            }
            else
            {
                try {
                    MySqlConnection conn = new MySqlConnection(connString);
                    using (conn)
                    {
                        conn.Open();
                        string query = "INSERT INTO signup(name,email,address,password) values(@name,@email,@address,@password)";

                        MySqlCommand cmd= new MySqlCommand(query, conn);


                        cmd.Parameters.AddWithValue("@name" ,name.ToLower());
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@password", password);

                        int status=cmd.ExecuteNonQuery();

                        if (status > 0)
                        {
                            MessageBox.Show("Account Created Successfully!");
                            conn.Close();
                            new Form1().Show();
                            this.Close();
                            return;

                        }

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
