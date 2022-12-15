
namespace WindowsFormsAppDB
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dRUGBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.myclinicDataSet1 = new WindowsFormsAppDB.myclinicDataSet1();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.myclinicDataSet = new WindowsFormsAppDB.myclinicDataSet();
            this.dRUGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dRUGTableAdapter = new WindowsFormsAppDB.myclinicDataSetTableAdapters.DRUGTableAdapter();
            this.dRUGTableAdapter1 = new WindowsFormsAppDB.myclinicDataSet1TableAdapters.DRUGTableAdapter();
            this.myclinicDataSet2 = new WindowsFormsAppDB.myclinicDataSet();
            this.drugTableAdapter2 = new WindowsFormsAppDB.myclinicDataSet1TableAdapters.DRUGTableAdapter();
            this.drugTableAdapter3 = new WindowsFormsAppDB.myclinicDataSet1TableAdapters.DRUGTableAdapter();
            this.Lbl_IDError = new System.Windows.Forms.Label();
            this.Lbl_FNameError = new System.Windows.Forms.Label();
            this.Lbl_LNameError = new System.Windows.Forms.Label();
            this.Lbl_NIDError = new System.Windows.Forms.Label();
            this.Lbl_DoBError = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dRUGBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myclinicDataSet1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myclinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dRUGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myclinicDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(24, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(817, 396);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(809, 367);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Doctor";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(720, 244);
            this.dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "show doctors";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Lbl_DoBError);
            this.tabPage2.Controls.Add(this.Lbl_NIDError);
            this.tabPage2.Controls.Add(this.Lbl_LNameError);
            this.tabPage2.Controls.Add(this.Lbl_FNameError);
            this.tabPage2.Controls.Add(this.Lbl_IDError);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(809, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Patient";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 42);
            this.button2.TabIndex = 12;
            this.button2.Text = "Add Patient";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(202, 230);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(212, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(202, 187);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(212, 22);
            this.textBox5.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(202, 149);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(212, 22);
            this.textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(202, 110);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(212, 22);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(202, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 22);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(202, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(98, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(98, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(98, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "National ID";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(98, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(98, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(98, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.textBox6);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(809, 367);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Drug";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.dRUGBindingSource1;
            this.comboBox1.DisplayMember = "DRUG_NAME";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(127, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // dRUGBindingSource1
            // 
            this.dRUGBindingSource1.DataMember = "DRUG";
            this.dRUGBindingSource1.DataSource = this.myclinicDataSet1;
            // 
            // myclinicDataSet1
            // 
            this.myclinicDataSet1.DataSetName = "myclinicDataSet1";
            this.myclinicDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(475, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Drug Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(367, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Drug Status";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(197, 209);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(139, 22);
            this.textBox6.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 205);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 31);
            this.button3.TabIndex = 2;
            this.button3.Text = "Find Drug by Code";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(21, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "List of Drugs";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.textBox7);
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(809, 367);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "OCR";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(247, 217);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(254, 38);
            this.button4.TabIndex = 2;
            this.button4.Text = "Convert to Text";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(247, 276);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(254, 75);
            this.textBox7.TabIndex = 1;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(247, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // myclinicDataSet
            // 
            this.myclinicDataSet.DataSetName = "myclinicDataSet";
            this.myclinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dRUGBindingSource
            // 
            this.dRUGBindingSource.DataMember = "DRUG";
            this.dRUGBindingSource.DataSource = this.myclinicDataSet;
            // 
            // dRUGTableAdapter
            // 
            this.dRUGTableAdapter.ClearBeforeFill = true;
            // 
            // dRUGTableAdapter1
            // 
            this.dRUGTableAdapter1.ClearBeforeFill = true;
            // 
            // myclinicDataSet2
            // 
            this.myclinicDataSet2.DataSetName = "myclinicDataSet";
            this.myclinicDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // drugTableAdapter2
            // 
            this.drugTableAdapter2.ClearBeforeFill = true;
            // 
            // drugTableAdapter3
            // 
            this.drugTableAdapter3.ClearBeforeFill = true;
            // 
            // Lbl_IDError
            // 
            this.Lbl_IDError.AutoSize = true;
            this.Lbl_IDError.Location = new System.Drawing.Point(457, 42);
            this.Lbl_IDError.Name = "Lbl_IDError";
            this.Lbl_IDError.Size = new System.Drawing.Size(0, 17);
            this.Lbl_IDError.TabIndex = 13;
            // 
            // Lbl_FNameError
            // 
            this.Lbl_FNameError.AutoSize = true;
            this.Lbl_FNameError.Location = new System.Drawing.Point(457, 75);
            this.Lbl_FNameError.Name = "Lbl_FNameError";
            this.Lbl_FNameError.Size = new System.Drawing.Size(0, 17);
            this.Lbl_FNameError.TabIndex = 14;
            // 
            // Lbl_LNameError
            // 
            this.Lbl_LNameError.AutoSize = true;
            this.Lbl_LNameError.Location = new System.Drawing.Point(457, 115);
            this.Lbl_LNameError.Name = "Lbl_LNameError";
            this.Lbl_LNameError.Size = new System.Drawing.Size(0, 17);
            this.Lbl_LNameError.TabIndex = 15;
            // 
            // Lbl_NIDError
            // 
            this.Lbl_NIDError.AutoSize = true;
            this.Lbl_NIDError.Location = new System.Drawing.Point(457, 154);
            this.Lbl_NIDError.Name = "Lbl_NIDError";
            this.Lbl_NIDError.Size = new System.Drawing.Size(0, 17);
            this.Lbl_NIDError.TabIndex = 16;
            // 
            // Lbl_DoBError
            // 
            this.Lbl_DoBError.AutoSize = true;
            this.Lbl_DoBError.Location = new System.Drawing.Point(457, 190);
            this.Lbl_DoBError.Name = "Lbl_DoBError";
            this.Lbl_DoBError.Size = new System.Drawing.Size(0, 17);
            this.Lbl_DoBError.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 456);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dRUGBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myclinicDataSet1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myclinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dRUGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myclinicDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private myclinicDataSet myclinicDataSet;
        private System.Windows.Forms.BindingSource dRUGBindingSource;
        private myclinicDataSetTableAdapters.DRUGTableAdapter dRUGTableAdapter;
        private myclinicDataSet1 myclinicDataSet1;
        private System.Windows.Forms.BindingSource dRUGBindingSource1;
        private myclinicDataSet1TableAdapters.DRUGTableAdapter dRUGTableAdapter1;
        private myclinicDataSet myclinicDataSet2;
        private myclinicDataSet1TableAdapters.DRUGTableAdapter drugTableAdapter2;
        private myclinicDataSet1TableAdapters.DRUGTableAdapter drugTableAdapter3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label Lbl_DoBError;
        private System.Windows.Forms.Label Lbl_NIDError;
        private System.Windows.Forms.Label Lbl_LNameError;
        private System.Windows.Forms.Label Lbl_FNameError;
        private System.Windows.Forms.Label Lbl_IDError;
    }
}

