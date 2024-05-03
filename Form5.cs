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
using MySql.Data;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace stms
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;port=3306;database=sms;user=root;password=";
           
            string query = "INSERT INTO signup (name, email, address) VALUES (@name, @email, @address)";

            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", textBox1.Text);
                cmd.Parameters.AddWithValue("@email", textBox2.Text);
                cmd.Parameters.AddWithValue("@address", textBox3.Text);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record has been successfully saved!");
                }
                else
                {
                    MessageBox.Show("Failed to save the record.");
                }
                conn.Close();
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;port=3306;database=sms;user=root;password=";
           
            string query = "UPDATE signup SET Name = @newName, Email = @email, Address = @address WHERE Name = @oldName";

            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@newName", textBox1.Text); // New name value
                cmd.Parameters.AddWithValue("@email", textBox2.Text);
                cmd.Parameters.AddWithValue("@address", textBox3.Text);
                cmd.Parameters.AddWithValue("@oldName", textBox1.Text); // Old name value

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record has been updated successfully");
                }
                else
                {
                    MessageBox.Show("No records were updated");
                }
                conn.Close();
            }
        }

            private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connection = "server = localhost; port = 3306; database = sms; user = root; password = ";
         
            string query = "DELETE FROM signup WHERE Name = @name";

            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", textBox1.Text);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data has been successfully deleted!");
                }
                else
                {
                    MessageBox.Show("No records were deleted.");
                }
                conn.Close();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connection = "server = localhost; port = 3306; database = sms; user = root; password = ";
        
            string query = "INSERT INTO grade (name, email, mark) VALUES (@name, @email, @mark)";

            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", textBox1.Text);
                cmd.Parameters.AddWithValue("@email", textBox2.Text);
                cmd.Parameters.AddWithValue("@mark", textBox4.Text);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Grade set to student!");
                }
                else
                {
                    MessageBox.Show("Failed to set the grade.");
                }

                conn.Close(); 
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

           
            string connection = "server=localhost;port=3306;database=sms;user=root;password=";
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                MySqlCommand cmd = new MySqlCommand("SELECT grade.mark, signup.name, signup.email, signup.address FROM grade INNER JOIN signup ON grade.email = signup.email", conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }

        }
    }
}
    

  