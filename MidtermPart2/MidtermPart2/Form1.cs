using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace MidtermPart2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=hri";
            string query = "INSERT INTO employee(EmpID,Fname,Lname,Position)VALUES('" + this.EmpId.Text + "','" + this.Fname.Text + "','" + this.Lname.Text + "','" + this.Pos.Text + "')";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Successfully saved");
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=hri";
            string query = "UPDATE employee SET Fname='" + this.Fname.Text + "',Lname='" + this.Lname.Text + "',Position='" + this.Pos.Text + "' WHERE EMPID='" + this.EmpId.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            MessageBoxButtons a = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("do you want to update?", connection, a);
            if (result == DialogResult.Yes)
            {
                dr = cmd.ExecuteReader();
            }
            else
                conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=hri";
            string query = "DELETE FROM employee WHERE EmpId='" + this.EmpId.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            MessageBoxButtons a = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("do you want to delete?", connection, a);
            if (result == DialogResult.Yes)
            {
                dr = cmd.ExecuteReader();
            }
            else
                conn.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=hri";
            string query = "SELECT * FROM employee";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dats.DataSource = dt;



        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}