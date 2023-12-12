namespace _479314_Ega_Rizky_Setiawan_ResponsiJuniorProject
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
            label1 = new Label();
            label2 = new Label();
            tbNama = new TextBox();
            cbDepartment = new ComboBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 74);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Nama Karyawan :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 101);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 1;
            label2.Text = "Dep. Karyawan :";
            // 
            // tbNama
            // 
            tbNama.Location = new Point(149, 69);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(121, 23);
            tbNama.TabIndex = 2;
            // 
            // cbDepartment
            // 
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(149, 98);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(121, 23);
            cbDepartment.TabIndex = 3;
            cbDepartment.SelectedIndexChanged += cbDepartment_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 33);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 4;
            label3.Text = "logo";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(35, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 50);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(65, 167);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(189, 167);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(310, 167);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 213);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(382, 150);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(533, 33);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 10;
            label4.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(cbDepartment);
            Controls.Add(tbNama);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbNama;
        private ComboBox cbDepartment;
        private Label label3;
        private PictureBox pictureBox1;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dataGridView1;
        private Label label4;
    }
}