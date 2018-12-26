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
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textB_toid = new System.Windows.Forms.TextBox();
            this.richTextB_text = new System.Windows.Forms.RichTextBox();
            this.textB_byid = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Text", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(132, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 28);
            this.label8.TabIndex = 20;
            this.label8.Text = "Text:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 28);
            this.label1.TabIndex = 21;
            this.label1.Text = "To_id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "Sender_id:";
            // 
            // textB_toid
            // 
            this.textB_toid.Location = new System.Drawing.Point(224, 46);
            this.textB_toid.Name = "textB_toid";
            this.textB_toid.Size = new System.Drawing.Size(202, 22);
            this.textB_toid.TabIndex = 23;
            // 
            // richTextB_text
            // 
            this.richTextB_text.Location = new System.Drawing.Point(224, 223);
            this.richTextB_text.Name = "richTextB_text";
            this.richTextB_text.Size = new System.Drawing.Size(349, 124);
            this.richTextB_text.TabIndex = 24;
            this.richTextB_text.Text = "";
            // 
            // textB_byid
            // 
            this.textB_byid.Location = new System.Drawing.Point(224, 130);
            this.textB_byid.Name = "textB_byid";
            this.textB_byid.Size = new System.Drawing.Size(202, 22);
            this.textB_byid.TabIndex = 25;
            // 
            // btn_send
            // 
            this.btn_send.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.Location = new System.Drawing.Point(532, 420);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(136, 46);
            this.btn_send.TabIndex = 26;
            this.btn_send.Text = "send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // manager_send_message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 540);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.textB_byid);
            this.Controls.Add(this.richTextB_text);
            this.Controls.Add(this.textB_toid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Name = "manager_send_message";
            this.Text = "manager_send_message";
            this.Load += new System.EventHandler(this.manager_send_message_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textB_toid;
        private System.Windows.Forms.RichTextBox richTextB_text;
        private System.Windows.Forms.TextBox textB_byid;
        private System.Windows.Forms.Button btn_send;
    }
}