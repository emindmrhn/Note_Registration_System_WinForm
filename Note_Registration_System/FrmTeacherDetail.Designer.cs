
namespace Note_Registration_System
{
    partial class FrmTeacherDetail
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mskSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskName = new System.Windows.Forms.TextBox();
            this.mskNumber = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtE3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtE2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtE1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblRema = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblLessonBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tblLessonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblLessonBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbNoteRegDataSet3 = new Note_Registration_System.DbNoteRegDataSet3();
            this.tblLessonBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_LessonTableAdapter2 = new Note_Registration_System.DbNoteRegDataSet3TableAdapters.Tbl_LessonTableAdapter();
            this.dbNoteRegDataSet = new Note_Registration_System.DbNoteRegDataSet();
            this.tblLessonBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_LessonTableAdapter = new Note_Registration_System.DbNoteRegDataSetTableAdapters.Tbl_LessonTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLessonBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLessonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLessonBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNoteRegDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLessonBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNoteRegDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLessonBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mskSurname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mskName);
            this.groupBox1.Controls.Add(this.mskNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Student";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Surname:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // mskSurname
            // 
            this.mskSurname.Location = new System.Drawing.Point(92, 132);
            this.mskSurname.Name = "mskSurname";
            this.mskSurname.Size = new System.Drawing.Size(100, 26);
            this.mskSurname.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // mskName
            // 
            this.mskName.Location = new System.Drawing.Point(92, 90);
            this.mskName.Name = "mskName";
            this.mskName.Size = new System.Drawing.Size(100, 26);
            this.mskName.TabIndex = 2;
            // 
            // mskNumber
            // 
            this.mskNumber.Location = new System.Drawing.Point(92, 53);
            this.mskNumber.Mask = "0000";
            this.mskNumber.Name = "mskNumber";
            this.mskNumber.Size = new System.Drawing.Size(100, 26);
            this.mskNumber.TabIndex = 1;
            this.mskNumber.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtE3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtE2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtE1);
            this.groupBox2.Location = new System.Drawing.Point(236, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 249);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exam Notes";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Exam 3:";
            // 
            // txtE3
            // 
            this.txtE3.Location = new System.Drawing.Point(102, 135);
            this.txtE3.Name = "txtE3";
            this.txtE3.Size = new System.Drawing.Size(100, 26);
            this.txtE3.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Exam 2:";
            // 
            // txtE2
            // 
            this.txtE2.Location = new System.Drawing.Point(102, 93);
            this.txtE2.Name = "txtE2";
            this.txtE2.Size = new System.Drawing.Size(100, 26);
            this.txtE2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Exam 1:";
            // 
            // txtE1
            // 
            this.txtE1.Location = new System.Drawing.Point(102, 51);
            this.txtE1.Name = "txtE1";
            this.txtE1.Size = new System.Drawing.Size(100, 26);
            this.txtE1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblRema);
            this.groupBox3.Controls.Add(this.lblPass);
            this.groupBox3.Controls.Add(this.lblAverage);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(469, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(351, 249);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Exam Notes";
            // 
            // lblRema
            // 
            this.lblRema.AutoSize = true;
            this.lblRema.Location = new System.Drawing.Point(176, 138);
            this.lblRema.Name = "lblRema";
            this.lblRema.Size = new System.Drawing.Size(28, 18);
            this.lblRema.TabIndex = 15;
            this.lblRema.Text = "00";
            this.lblRema.Click += new System.EventHandler(this.lblRema_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(212, 96);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(28, 18);
            this.lblPass.TabIndex = 14;
            this.lblPass.Text = "00";
            this.lblPass.Click += new System.EventHandler(this.label10_Click);
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(97, 54);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(28, 18);
            this.lblAverage.TabIndex = 10;
            this.lblAverage.Text = "00";
            this.lblAverage.Click += new System.EventHandler(this.lblAverage_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Remaining Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "Number of Passed Exam:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "Average:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(12, 267);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1139, 431);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Exam Notes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.tblLessonBindingSource3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1133, 406);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tblLessonBindingSource3
            // 
            this.tblLessonBindingSource3.DataMember = "Tbl_Lesson";
            // 
            // tblLessonBindingSource
            // 
            this.tblLessonBindingSource.DataMember = "Tbl_Lesson";
            // 
            // tblLessonBindingSource1
            // 
            this.tblLessonBindingSource1.DataMember = "Tbl_Lesson";
            // 
            // dbNoteRegDataSet3
            // 
            this.dbNoteRegDataSet3.DataSetName = "DbNoteRegDataSet3";
            this.dbNoteRegDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblLessonBindingSource2
            // 
            this.tblLessonBindingSource2.DataMember = "Tbl_Lesson";
            this.tblLessonBindingSource2.DataSource = this.dbNoteRegDataSet3;
            // 
            // tbl_LessonTableAdapter2
            // 
            this.tbl_LessonTableAdapter2.ClearBeforeFill = true;
            // 
            // dbNoteRegDataSet
            // 
            this.dbNoteRegDataSet.DataSetName = "DbNoteRegDataSet";
            this.dbNoteRegDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblLessonBindingSource4
            // 
            this.tblLessonBindingSource4.DataMember = "Tbl_Lesson";
            this.tblLessonBindingSource4.DataSource = this.dbNoteRegDataSet;
            // 
            // tbl_LessonTableAdapter
            // 
            this.tbl_LessonTableAdapter.ClearBeforeFill = true;
            // 
            // FrmTeacherDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1290, 710);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTeacherDetail";
            this.Text = "FrmTeacherDetail";
            this.Load += new System.EventHandler(this.FrmTeacherDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLessonBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLessonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLessonBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNoteRegDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLessonBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbNoteRegDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLessonBindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mskSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mskName;
        private System.Windows.Forms.MaskedTextBox mskNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtE2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtE1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtE3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.GroupBox groupBox4;
        //   private DbNoteRegDataSet dbNoteRegDataSet;
        private System.Windows.Forms.BindingSource tblLessonBindingSource;
        //  private DbNoteRegDataSetTableAdapters.Tbl_LessonTableAdapter tbl_LessonTableAdapter;
        //  private DbNoteRegDataSet1 dbNoteRegDataSet1;
        private System.Windows.Forms.BindingSource tblLessonBindingSource1;
        //    private DbNoteRegDataSet1TableAdapters.Tbl_LessonTableAdapter tbl_LessonTableAdapter1;
        private DbNoteRegDataSet3 dbNoteRegDataSet3;
        private System.Windows.Forms.BindingSource tblLessonBindingSource2;
        private DbNoteRegDataSet3TableAdapters.Tbl_LessonTableAdapter tbl_LessonTableAdapter2;
        private System.Windows.Forms.DataGridView dataGridView1;
        //  private DbNoteRegDataSet2 dbNoteRegDataSet2;
        private System.Windows.Forms.BindingSource tblLessonBindingSource3;
        //    private DbNoteRegDataSet2TableAdapters.Tbl_LessonTableAdapter tbl_LessonTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDSURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDE1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDE2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDE3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVERAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sITUATIONDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblRema;
        private DbNoteRegDataSet dbNoteRegDataSet;
        private System.Windows.Forms.BindingSource tblLessonBindingSource4;
        private DbNoteRegDataSetTableAdapters.Tbl_LessonTableAdapter tbl_LessonTableAdapter;
    }
}