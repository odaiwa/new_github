namespace group28
{
    partial class manager_send_message
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manager_send_message));
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextB_text = new System.Windows.Forms.RichTextBox();
            this.textB_toid = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Text", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(69, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 35);
            this.label8.TabIndex = 20;
            this.label8.Text = "Text:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "To_id:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // richTextB_text
            // 
            this.richTextB_text.Location = new System.Drawing.Point(172, 157);
            this.richTextB_text.Name = "richTextB_text";
            this.richTextB_text.Size = new System.Drawing.Size(349, 124);
            this.richTextB_text.TabIndex = 24;
            this.richTextB_text.Text = "";
            // 
            // textB_toid
            // 
            this.textB_toid.Location = new System.Drawing.Point(172, 105);
            this.textB_toid.Name = "textB_toid";
            this.textB_toid.Size = new System.Drawing.Size(202, 22);
            this.textB_toid.TabIndex = 25;
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.Azure;
            this.btn_send.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_send.Location = new System.Drawing.Point(401, 305);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(120, 46);
            this.btn_send.TabIndex = 26;
            this.btn_send.Text = "send";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.label_title);
            this.groupBox1.Controls.Add(this.richTextB_text);
            this.groupBox1.Controls.Add(this.btn_send);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textB_toid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(111, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 361);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "send";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label_title.Font = new System.Drawing.Font("Castellar", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label_title.Location = new System.Drawing.Point(166, 39);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(248, 34);
            this.label_title.TabIndex = 28;
            this.label_title.Text = "Send Message";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // manager_send_message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(775, 540);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "manager_send_message";
            this.Text = "send_message";
            this.Load += new System.EventHandler(this.manager_send_message_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextB_text;
        private System.Windows.Forms.TextBox textB_toid;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}