using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace stms
{
    public partial class Form1 : Form
    {
        public Form1()
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // this.Hide();
            Form3 form = new Form3();
            form.Show();

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string connection = "server=localhost;port=3306;database=sms;user=root;password=";
            var con = new MySqlConnection(connection);
           

            try
            {
                con.Open();
                
                var cmd = new MySqlCommand("SELECT grade.mark, signup.name, signup.email, signup.address FROM grade INNER JOIN signup ON grade.name = signup.name WHERE signup.name = @name AND signup.password = @password", con);

                cmd.Parameters.AddWithValue("@name", textBox1.Text);
                cmd.Parameters.AddWithValue( "@password", textBox2.Text);
                MySqlDataReader reader = cmd.ExecuteReader();
                
                string name, email, address,mark;
                if (reader.Read() )
                {
                    
                    name = reader["name"].ToString();
                    email = reader["email"].ToString();
                    address = reader["address"].ToString();
                   mark = reader["mark"].ToString();
                    

                    Form4 form = new Form4( name, email, address, mark);
                
                    form.Show();
                }
            }
            catch
            {
                MessageBox.Show("Invalid Credentials!");
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
