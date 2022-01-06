using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using onlinesinavbilgilendirme.core.Model;

namespace onlinesinavbilgilendirme
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();

            this.AcceptButton = kayitbutton;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void nametext_MouseEnter(object sender, EventArgs e)
        {
            if (username.Text == "Username")
            {
                username.Text = "";
                username.ForeColor = Color.Black;
            }
        }

        private void nametext_MouseLeave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "Username";
                username.ForeColor = Color.Silver;
            }
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            
            if (password.Text == "Password")
            {
                password.Text = "";
                password.ForeColor = Color.Black;
                password.PasswordChar = '*';
            }
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            char? none = null;
            if (password.Text == "")
            {
                password.Text = "Password";
                password.ForeColor = Color.Silver;
                password.PasswordChar = Convert.ToChar(none);
            }
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            if (rePassword.Text == "Re_Password")
            {
                rePassword.Text = "";
                rePassword.ForeColor = Color.Black;
                rePassword.PasswordChar = '*';
            }
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            char? none = null;
            if (rePassword.Text == "")
            {
                rePassword.Text = "Re_Password";
                rePassword.ForeColor = Color.Silver;
                rePassword.PasswordChar = Convert.ToChar(none);
            }
        }

        private void textBox3_MouseEnter(object sender, EventArgs e)
        {
            if (email.Text == "Email")
            {
                email.Text = "";
                email.ForeColor = Color.Black;
            }
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            if (email.Text == "")
            {
                email.Text = "Email";
                email.ForeColor = Color.Silver;
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
            if(password.Text == rePassword.Text)
            {
                try
                {
                    ContextDb contextDb = new ContextDb();

                    contextDb.Add(new User()
                    {
                        Email = email.Text,
                        MailDurum = mailDurum.Checked,
                        Password = password.Text,
                        Username = username.Text
                    });
                    contextDb.SaveChanges();
                    MessageBox.Show("Kayıt Başarılı ", "Program");
                    this.Hide();
                    Form1 form1 = new Form1();
                    form1.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Program");
                }              
            }
            else
            {
                MessageBox.Show("Şifreler eşleşmiyor ", "Program");
            }

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
