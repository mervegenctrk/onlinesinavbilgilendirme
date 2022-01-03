using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace onlinesinavbilgilendirme
{
    public partial class Form3 : Form
    {
        SqlConnection connection = Form1.connection;
        //SqlCommand cmmd;
        SqlDataAdapter ca;
        public Form3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            duyurugetir();
            
        }

        public void duyurugetir()
        {
            
            //connection.Open();
            ca = new SqlDataAdapter("Select *from duyurusinav", connection);
            DataTable tablo = new DataTable();
            ca.Fill(tablo);
            dataGridView1.DataSource = tablo;
            connection.Close();
        }

        public void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("Select *from duyurusinav where sinavadi like '%" + textBox1.Text + "%'", connection);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form5 frm5 = new Form5();
            frm5.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            vericek frm6 = new vericek();
            frm6.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
