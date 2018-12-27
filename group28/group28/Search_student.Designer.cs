namespace group28
{
    partial class Search_student
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
            this.components = new System.ComponentModel.Container();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database23DataSet = new group28.Database23DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.textB_id = new System.Windows.Forms.TextBox();
            this.btn_search_lec = new System.Windows.Forms.Button();
            this.studentTableAdapter = new group28.Database23DataSetTableAdapters.studentTableAdapter();
            this.tableAdapterManager = new group28.Database23DataSetTableAdapters.TableAdapterManager();
            this.studentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database23DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.database23DataSet;
            // 
            // database23DataSet
            // 
            this.database23DataSet.DataSetName = "Database23DataSet";
            this.database23DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID:";
            // 
            // textB_id
            // 
            this.textB_id.Location = new System.Drawing.Point(286, 94);
            this.textB_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textB_id.Name = "textB_id";
            this.textB_id.Size = new System.Drawing.Size(191, 22);
            this.textB_id.TabIndex = 12;
            // 
            // btn_search_lec
            // 
            this.btn_search_lec.Location = new System.Drawing.Point(482, 88);
            this.btn_search_lec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search_lec.Name = "btn_search_lec";
            this.btn_search_lec.Size = new System.Drawing.Size(107, 34);
            this.btn_search_lec.TabIndex = 11;
            this.btn_search_lec.Text = "Search";
            this.btn_search_lec.UseVisualStyleBackColor = true;
            this.btn_search_lec.Click += new System.EventHandler(this.btn_search_lec_Click);
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CourseTableAdapter = null;
            this.tableAdapterManager.DepartmentTableAdapter = null;
            this.tableAdapterManager.lecturer_courseTableAdapter = null;
            this.tableAdapterManager.lecturerTableAdapter = null;
            this.tableAdapterManager.ManagerTableAdapter = null;
            this.tableAdapterManager.messagesTableAdapter = null;
            this.tableAdapterManager.student_courseTableAdapter = null;
            this.tableAdapterManager.StudentInCourseTableAdapter = null;
            this.tableAdapterManager.studentTableAdapter = this.studentTableAdapter;
            this.tableAdapterManager.UpdateOrder = group28.Database23DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentDataGridView
            // 
            this.studentDataGridView.AutoGenerateColumns = false;
            this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.studentDataGridView.DataSource = this.studentBindingSource;
            this.studentDataGridView.Location = new System.Drawing.Point(145, 154);
            this.studentDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.RowTemplate.Height = 24;
            this.studentDataGridView.Size = new System.Drawing.Size(543, 338);
            this.studentDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "firstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "lastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "username";
            this.dataGridViewTextBoxColumn4.HeaderText = "username";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn5.HeaderText = "password";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn6.HeaderText = "Email";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "BirthDay";
            this.dataGridViewTextBoxColumn7.HeaderText = "BirthDay";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "gender";
            this.dataGridViewTextBoxColumn8.HeaderText = "gender";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "departmentName";
            this.dataGridViewTextBoxColumn9.HeaderText = "departmentName";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label_title.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.Green;
            this.label_title.Location = new System.Drawing.Point(277, 18);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(307, 54);
            this.label_title.TabIndex = 17;
            this.label_title.Text = "Search Student ";
            // 
            // Search_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 513);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.studentDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textB_id);
            this.Controls.Add(this.btn_search_lec);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Search_student";
            this.Text = "Search_student";
            this.Load += new System.EventHandler(this.Search_student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database23DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textB_id;
        private System.Windows.Forms.Button btn_search_lec;
        private Database23DataSet database23DataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private Database23DataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private Database23DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView studentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label label_title;
    }
}