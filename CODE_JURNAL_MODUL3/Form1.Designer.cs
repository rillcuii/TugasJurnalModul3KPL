namespace CODE_JURNAL_MODUL3
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
            lblSoal = new Label();
            btnA = new Button();
            btnB = new Button();
            btnC = new Button();
            btnD = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblOutput = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblSoal
            // 
            lblSoal.AutoSize = true;
            lblSoal.Location = new Point(245, 63);
            lblSoal.Name = "lblSoal";
            lblSoal.Size = new Size(242, 20);
            lblSoal.TabIndex = 0;
            lblSoal.Text = "Apa fungsi utama dari GUI Builder?";
            lblSoal.Click += lblSoal_Click;
            // 
            // btnA
            // 
            btnA.Location = new Point(3, 3);
            btnA.Name = "btnA";
            btnA.Size = new Size(197, 108);
            btnA.TabIndex = 1;
            btnA.Text = "A.Membuat tampilan aplikasi secara visual";
            btnA.UseVisualStyleBackColor = true;
            btnA.Click += btnA_Click;
            // 
            // btnB
            // 
            btnB.Location = new Point(3, 117);
            btnB.Name = "btnB";
            btnB.Size = new Size(197, 108);
            btnB.TabIndex = 2;
            btnB.Text = "B.Mengelola database";
            btnB.UseVisualStyleBackColor = true;
            btnB.Click += btnB_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(206, 3);
            btnC.Name = "btnC";
            btnC.Size = new Size(197, 108);
            btnC.TabIndex = 3;
            btnC.Text = "C.Menghapus file sistem";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnD
            // 
            btnD.Location = new Point(206, 117);
            btnD.Name = "btnD";
            btnD.Size = new Size(197, 108);
            btnD.TabIndex = 4;
            btnD.Text = "D.Membuat server jaringan";
            btnD.UseVisualStyleBackColor = true;
            btnD.Click += btnD_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnA, 0, 0);
            tableLayoutPanel1.Controls.Add(btnB, 0, 1);
            tableLayoutPanel1.Controls.Add(btnD, 1, 1);
            tableLayoutPanel1.Controls.Add(btnC, 1, 0);
            tableLayoutPanel1.Location = new Point(145, 127);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(406, 228);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(327, 378);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(53, 20);
            lblOutput.TabIndex = 7;
            lblOutput.Text = "output";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblOutput);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lblSoal);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSoal;
        private Button btnA;
        private Button btnB;
        private Button btnC;
        private Button btnD;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblOutput;
    }
}
