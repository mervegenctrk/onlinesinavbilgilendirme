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
    public partial class Form2 : Form
    {
        SqlConnection connection = Form1.connection;
        
        public Form2()
        {
            InitializeComponent();

            this.AcceptButton = kayitbutton;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void nametext_MouseEnter(object sender, EventArgs e)
        {
            if (nametext.Text == "Username")
            {
                nametext.Text = "";
                nametext.ForeColor = Color.Black;
            }
        }

        private void nametext_MouseLeave(object sender, EventArgs e)
        {
            if (nametext.Text == "")
            {
                nametext.Text = "Username";
                nametext.ForeColor = Color.Silver;
            }
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "Password")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
                textBox1.PasswordChar = '*';
            }
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            char? none = null;
            if (textBox1.Text == "")
            {
                textBox1.Text = "Password";
                textBox1.ForeColor = Color.Silver;
                textBox1.PasswordChar = Convert.ToChar(none);
            }
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Re_Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                textBox2.PasswordChar = '*';
            }
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            char? none = null;
            if (textBox2.Text == "")
            {
                textBox2.Text = "Re_Password";
                textBox2.ForeColor = Color.Silver;
                textBox2.PasswordChar = Convert.ToChar(none);
            }
        }

        private void textBox3_MouseEnter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Email")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Email";
                textBox3.ForeColor = Color.Silver;
            }
        }

        private void textBox4_MouseEnter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Phone Number")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox4_MouseLeave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Phone Number";
                textBox4.ForeColor = Color.Silver;
            }
        }
        bool move;
        int mouse_x;
        int mouse_y;

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void kayitbutton_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Insert into onlusername(username,pass,re_pass,email,phone_number,active) values ('"+cryptology.Encryption(nametext.Text,2)+ "','" +cryptology.Encryption(textBox1.Text,2) + "','" +cryptology.Encryption(textBox2.Text,2) + "','" +cryptology.Encryption(textBox3.Text,2) + "','" +cryptology.Encryption(textBox4.Text,2) + "','"+checkBox1.Checked.ToString()+"')",connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kayıt Başarılı ","Program");

            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void textBox5_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
