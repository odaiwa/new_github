namespace group28
{
    partial class Search_course
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
            this.label1 = new System.Windows.Forms.Label();
            this.textB_id_crs = new System.Windows.Forms.TextBox();
            this.btn_search_crs = new System.Windows.Forms.Button();
            this.database23DataSet = new group28.Database23DataSet();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new group28.Database23DataSetTableAdapters.CourseTableAdapter();
            this.tableAdapterManager = new group28.Database23DataSetTableAdapters.TableAdapterManager();
            this.courseDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database23DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Number:";
            // 
            // textB_id_crs
            // 
            this.textB_id_crs.Location = new System.Drawing.Point(377, 105);
            this.textB_id_crs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textB_id_crs.Name = "textB_id_crs";
            this.textB_id_crs.Size = new System.Drawing.Size(191, 22);
            this.textB_id_crs.TabIndex = 15;
            // 
            // btn_search_crs
            // 
            this.btn_search_crs.Location = new System.Drawing.Point(573, 99);
            this.btn_search_crs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search_crs.Name = "btn_search_crs";
            this.btn_search_crs.Size = new System.Drawing.Size(107, 34);
            this.btn_search_crs.TabIndex = 14;
            this.btn_search_crs.Text = "Search";
            this.btn_search_crs.UseVisualStyleBackColor = true;
            this.btn_search_crs.Click += new System.EventHandler(this.btn_search_crs_Click);
            // 
            // database23DataSet
            // 
            this.database23DataSet.DataSetName = "Database23DataSet";
            this.database23DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.database23DataSet;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CourseTableAdapter = this.courseTableAdapter;
            this.tableAdapterManager.DepartmentTableAdapter = null;
            this.tableAdapterManager.lecturer_courseTableAdapter = null;
            this.tableAdapterManager.lecturerTableAdapter = null;
            this.tableAdapterManager.ManagerTableAdapter = null;
            this.tableAdapterManager.messagesTableAdapter = null;
            this.tableAdapterManager.student_courseTableAdapter = null;
            this.tableAdapterManager.StudentInCourseTableAdapter = null;
            this.tableAdapterManager.studentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = group28.Database23DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // courseDataGridView
            // 
            this.courseDataGridView.AutoGenerateColumns = false;
            this.courseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.courseDataGridView.DataSource = this.courseBindingSource;
            this.courseDataGridView.Location = new System.Drawing.Point(103, 163);
            this.courseDataGridView.Name = "courseDataGridView";
            this.courseDataGridView.RowTemplate.Height = 24;
            this.courseDataGridView.Size = new System.Drawing.Size(744, 319);
            this.courseDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Number";
            this.dataGridViewTextBoxColumn1.HeaderText = "Number";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "lec_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "lec_id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "lecturerName";
            this.dataGridViewTextBoxColumn4.HeaderText = "lecturerName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "day";
            this.dataGridViewTextBoxColumn5.HeaderText = "day";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Hour";
            this.dataGridViewTextBoxColumn6.HeaderText = "Hour";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "points";
            this.dataGridViewTextBoxColumn7.HeaderText = "points";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label_title.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.Green;
            this.label_title.Location = new System.Drawing.Point(344, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(280, 54);
            this.label_title.TabIndex = 20;
            this.label_title.Text = "Search Course";
            // 
            // Search_course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 494);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.courseDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textB_id_crs);
            this.Controls.Add(this.btn_search_crs);
            this.Name = "Search_course";
            this.Text = "Search_course";
            this.Load += new System.EventHandler(this.Search_course_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database23DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textB_id_crs;
        private System.Windows.Forms.Button btn_search_crs;
        private Database23DataSet database23DataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private Database23DataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private Database23DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView courseDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label_title;
    }
}