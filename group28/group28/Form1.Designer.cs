namespace group28
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Login_button = new System.Windows.Forms.Button();
            this.username_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.password_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stuzone = new System.Windows.Forms.Button();
            this.manzone = new System.Windows.Forms.Button();
            this.leczone = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Login_button);
            this.groupBox1.Controls.Add(this.username_text);
            this.groupBox1.Controls.Add(this.password_text);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(293, 95);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(395, 198);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password:";
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.Color.FloralWhite;
            this.Login_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Login_button.BackgroundImage")));
            this.Login_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_button.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Login_button.Location = new System.Drawing.Point(237, 132);
            this.Login_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(123, 49);
            this.Login_button.TabIndex = 12;
            this.Login_button.Text = "LOGIN";
            this.Login_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // username_text
            // 
            this.username_text.Location = new System.Drawing.Point(133, 39);
            this.username_text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(227, 22);
            this.username_text.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(642, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // password_text
            // 
            this.password_text.Location = new System.Drawing.Point(133, 74);
            this.password_text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.password_text.Name = "password_text";
            this.password_text.PasswordChar = '•';
            this.password_text.Size = new System.Drawing.Size(227, 22);
            this.password_text.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Beige;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Username:";
            // 
            // stuzone
            // 
            this.stuzone.BackColor = System.Drawing.Color.Ivory;
            this.stuzone.Font = new System.Drawing.Font("Baskerville Old Face", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuzone.ForeColor = System.Drawing.Color.Green;
            this.stuzone.ImageKey = "(none)";
            this.stuzone.Location = new System.Drawing.Point(24, 327);
            this.stuzone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stuzone.Name = "stuzone";
            this.stuzone.Size = new System.Drawing.Size(137, 37);
            this.stuzone.TabIndex = 17;
            this.stuzone.Text = "Student Zone";
            this.stuzone.UseVisualStyleBackColor = false;
            this.stuzone.Click += new System.EventHandler(this.stuzone_Click);
            // 
            // manzone
            // 
            this.manzone.BackColor = System.Drawing.Color.Ivory;
            this.manzone.Font = new System.Drawing.Font("Baskerville Old Face", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manzone.ForeColor = System.Drawing.Color.Green;
            this.manzone.ImageKey = "(none)";
            this.manzone.Location = new System.Drawing.Point(309, 327);
            this.manzone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manzone.Name = "manzone";
            this.manzone.Size = new System.Drawing.Size(137, 37);
            this.manzone.TabIndex = 16;
            this.manzone.Text = "Manager Zone";
            this.manzone.UseVisualStyleBackColor = false;
            this.manzone.Click += new System.EventHandler(this.manzone_Click);
            // 
            // leczone
            // 
            this.leczone.BackColor = System.Drawing.Color.Ivory;
            this.leczone.Font = new System.Drawing.Font("Baskerville Old Face", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leczone.ForeColor = System.Drawing.Color.Green;
            this.leczone.ImageKey = "(none)";
            this.leczone.Location = new System.Drawing.Point(166, 327);
            this.leczone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leczone.Name = "leczone";
            this.leczone.Size = new System.Drawing.Size(137, 37);
            this.leczone.TabIndex = 15;
            this.leczone.Text = "Lecturer Zone";
            this.leczone.UseVisualStyleBackColor = false;
            this.leczone.Click += new System.EventHandler(this.leczone_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.Khaki;
            this.label_title.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.Green;
            this.label_title.Location = new System.Drawing.Point(300, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(188, 54);
            this.label_title.TabIndex = 18;
            this.label_title.Text = "SUCCESS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(493, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(235, 9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(75, 95);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(192, 198);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Ivory;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(548, 318);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 46);
            this.button1.TabIndex = 23;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(742, 423);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.stuzone);
            this.Controls.Add(this.manzone);
            this.Controls.Add(this.leczone);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Success";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.TextBox username_text;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button stuzone;
        private System.Windows.Forms.Button manzone;
        private System.Windows.Forms.Button leczone;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

