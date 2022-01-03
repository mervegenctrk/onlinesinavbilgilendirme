using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace onlinesinavbilgilendirme
{
    
    public partial class Form1 : Form
    {

        public static SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-O7FCNJ8; Initial Catalog=onlinesinav; Integrated Security=TRUE ");

        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = girisBut;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        bool move;
        int mouse_x;
        int mouse_y;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }
       
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move) 
            { 
            this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void nametext_Enter(object sender, EventArgs e)
        {
            if(nametext.Text=="Username")
            {
                nametext.Text = "";
                nametext.ForeColor = Color.Black;
            }
        }

        private void nametext_Leave(object sender, EventArgs e)
        {
            if(nametext.Text=="")
            {
                nametext.Text = "Username";
                nametext.ForeColor = Color.Silver;
            }
        }

        private void passtext_Enter(object sender, EventArgs e)
        {
            if (passtext.Text=="Password")
            {
                passtext.Text = "";
                passtext.ForeColor = Color.Black;
                passtext.PasswordChar = '*';
            }
        }
        char? none = null;
        private void passtext_Leave(object sender, EventArgs e)
        {
            if(passtext.Text=="")
            {
                passtext.Text = "Password";
                passtext.ForeColor = Color.Silver;
                passtext.PasswordChar = Convert.ToChar(none);
            }
        }
        bool isThere;
        private void girisBut_Click(object sender, EventArgs e)
        {
            string username = nametext.Text;
            string passwrd = passtext.Text;
           

            connection.Open();
            SqlCommand command = new SqlCommand("Select *from onlusername",connection);
            SqlDataReader reader = command.ExecuteReader();
            

            while(reader.Read())
            {
                
                    if (username == cryptology.Decryption(reader["username"].ToString().TrimEnd(), 2) && passwrd == cryptology.Decryption(reader["pass"].ToString().TrimEnd(), 2))
                    {
                        isThere = true;
                        this.Hide();
                        reader.Close();
                        Form3 frm3 = new Form3();
                        frm3.Show();
                        
                        break;
                    }
                    else
                    {
                        isThere = false;
                    }

               

                    /*if (username == cryptology.Decryption(reader["username"].ToString().TrimEnd(), 2) && passwrd == cryptology.Decryption(reader["pass"].ToString().TrimEnd(), 2))
                    {
                        isThere = true;
                        this.Hide();
                        Form3 frm3 = new Form3();
                        frm3.Show();
                        break;
                    }
                    else
                    {
                        isThere = false;
                    }*/
                if(nametext.Text=="admin" && passtext.Text=="admin")
                {
                    isThere = true;
                    Form6 frm6 = new Form6();
                    this.Hide();
                    frm6.Show();
                   
                    break;
                }
            }
            connection.Close();

            if(isThere)
            {
                MessageBox.Show("Giriş Başarılı!", "Program");
            }
            else
            {
                MessageBox.Show("Giriş bilgileri hatalı, bilgilerinizi kontrol ediniz.", "Program");
            }
        }

        private void kaylabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
