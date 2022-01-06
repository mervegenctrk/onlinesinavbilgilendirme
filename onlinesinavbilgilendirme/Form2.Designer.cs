
namespace onlinesinavbilgilendirme
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.kayitbutton = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.rePassword = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mailDurum = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(57, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kayıt olmak için aşağıdaki bilgileri doldurunuz!";
            // 
            // kayitbutton
            // 
            this.kayitbutton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kayitbutton.Location = new System.Drawing.Point(405, 411);
            this.kayitbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kayitbutton.Name = "kayitbutton";
            this.kayitbutton.Size = new System.Drawing.Size(95, 44);
            this.kayitbutton.TabIndex = 1;
            this.kayitbutton.Text = "Kayıt Ol";
            this.kayitbutton.UseVisualStyleBackColor = true;
            this.kayitbutton.Click += new System.EventHandler(this.kayitbutton_Click);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.SystemColors.ControlLight;
            this.username.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.username.Location = new System.Drawing.Point(143, 120);
            this.username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(241, 32);
            this.username.TabIndex = 3;
            this.username.Text = "Username";
            this.username.MouseEnter += new System.EventHandler(this.nametext_MouseEnter);
            this.username.MouseLeave += new System.EventHandler(this.nametext_MouseLeave);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.ControlLight;
            this.password.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(143, 164);
            this.password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(241, 32);
            this.password.TabIndex = 4;
            this.password.Text = "Password";
            this.password.MouseEnter += new System.EventHandler(this.textBox1_MouseEnter);
            this.password.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            // 
            // rePassword
            // 
            this.rePassword.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rePassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.rePassword.Location = new System.Drawing.Point(143, 208);
            this.rePassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rePassword.Name = "rePassword";
            this.rePassword.Size = new System.Drawing.Size(241, 32);
            this.rePassword.TabIndex = 5;
            this.rePassword.Text = "Re_Password";
            this.rePassword.MouseEnter += new System.EventHandler(this.textBox2_MouseEnter);
            this.rePassword.MouseLeave += new System.EventHandler(this.textBox2_MouseLeave);
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.SystemColors.ControlLight;
            this.email.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.email.Location = new System.Drawing.Point(143, 252);
            this.email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(241, 32);
            this.email.TabIndex = 6;
            this.email.Text = "Email";
            this.email.MouseEnter += new System.EventHandler(this.textBox3_MouseEnter);
            this.email.MouseLeave += new System.EventHandler(this.textBox3_MouseLeave);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(250, 411);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::onlinesinavbilgilendirme.Properties.Resources.carpi_isareti_kopyala;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(495, 3);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 45);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mailDurum
            // 
            this.mailDurum.AutoSize = true;
            this.mailDurum.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mailDurum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.mailDurum.Location = new System.Drawing.Point(12, 312);
            this.mailDurum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mailDurum.Name = "mailDurum";
            this.mailDurum.Size = new System.Drawing.Size(542, 27);
            this.mailDurum.TabIndex = 12;
            this.mailDurum.Text = "Yeni sınav duyurularının mailinize gelmesini istiyosanız, lütfen seçiniz.";
            this.mailDurum.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::onlinesinavbilgilendirme.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(580, 495);
            this.Controls.Add(this.mailDurum);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.rePassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.kayitbutton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kayitbutton;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox rePassword;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox mailDurum;
    }
}