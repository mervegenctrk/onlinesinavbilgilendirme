
namespace onlinesinavbilgilendirme
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nametext = new System.Windows.Forms.TextBox();
            this.passtext = new System.Windows.Forms.TextBox();
            this.girisBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.kaylabel = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nametext
            // 
            this.nametext.BackColor = System.Drawing.SystemColors.HighlightText;
            this.nametext.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.nametext.Location = new System.Drawing.Point(72, 132);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(264, 27);
            this.nametext.TabIndex = 2;
            this.nametext.Text = "Username";
            this.nametext.Enter += new System.EventHandler(this.nametext_Enter);
            this.nametext.Leave += new System.EventHandler(this.nametext_Leave);
            // 
            // passtext
            // 
            this.passtext.BackColor = System.Drawing.SystemColors.HighlightText;
            this.passtext.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.passtext.Location = new System.Drawing.Point(72, 176);
            this.passtext.Name = "passtext";
            this.passtext.Size = new System.Drawing.Size(264, 27);
            this.passtext.TabIndex = 3;
            this.passtext.Text = "Password";
            this.passtext.Enter += new System.EventHandler(this.passtext_Enter);
            this.passtext.Leave += new System.EventHandler(this.passtext_Leave);
            // 
            // girisBut
            // 
            this.girisBut.BackColor = System.Drawing.SystemColors.ControlLight;
            this.girisBut.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.girisBut.Location = new System.Drawing.Point(283, 295);
            this.girisBut.Name = "girisBut";
            this.girisBut.Size = new System.Drawing.Size(93, 35);
            this.girisBut.TabIndex = 6;
            this.girisBut.Text = "Giriş";
            this.girisBut.UseVisualStyleBackColor = false;
            this.girisBut.Click += new System.EventHandler(this.girisBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(38, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Online Sınav Bilgilendirme Sistemi";
            // 
            // kaylabel
            // 
            this.kaylabel.AutoSize = true;
            this.kaylabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.kaylabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kaylabel.Location = new System.Drawing.Point(296, 253);
            this.kaylabel.Name = "kaylabel";
            this.kaylabel.Size = new System.Drawing.Size(64, 20);
            this.kaylabel.TabIndex = 9;
            this.kaylabel.TabStop = true;
            this.kaylabel.Text = "Kayıt Ol";
            this.kaylabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.kaylabel_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::onlinesinavbilgilendirme.Properties.Resources.carpi_isareti_kopyala;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(391, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 34);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::onlinesinavbilgilendirme.Properties.Resources._360_F_292905667_yFUJNJPngYeRNlrRL4hApHWxuYyRY4kN;
            this.ClientSize = new System.Drawing.Size(425, 356);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kaylabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.girisBut);
            this.Controls.Add(this.passtext);
            this.Controls.Add(this.nametext);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.TextBox passtext;
        private System.Windows.Forms.Button girisBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel kaylabel;
        private System.Windows.Forms.Button button1;
    }
}

