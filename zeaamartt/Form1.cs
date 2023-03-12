using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace zeaamartt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=zeamartt";
            string query = "INSERT INTO tbl_produkk(KodeBarang,NamaBarang,StokBarang,HargaBarang)VALUES('" + this.txtKode.Text + "','" + this.txtNama.Text + "','" + this.txtStok.Text + "','" + this.txtHarga.Text + "')";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Successfully saved");
            conn.Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=zeamartt";
            string query = "UPDATE tbl_produkk SET KodeBarang='" + this.txtKode.Text + "',NamaBarang='" + this.txtNama.Text + "',StokBarang='" + this.txtStok.Text + "',HargaBarang='" + this.txtHarga.Text + "' WHERE KodeBarang='" + this.txtKode.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Record has been updated successfully");
            conn.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=zeamartt";
            string query = "DELETE FROM tbl_produkk WHERE KodeBarang='" + this.txtKode.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Data has been succesfully deleted!");
            conn.Close();

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;password=;database=zeamartt";
            string query = "SELECT * FROM tbl_produkk";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
