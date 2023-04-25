namespace Davomat
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            btnInfo = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            panel2 = new Panel();
            pnlStudents = new Panel();
            panel3 = new Panel();
            label4 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnInfo);
            panel1.Location = new Point(31, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(1153, 45);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(65, 65, 65);
            label2.Location = new Point(1050, 10);
            label2.Name = "label2";
            label2.Size = new Size(95, 23);
            label2.TabIndex = 2;
            label2.Text = "4-semester";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(67, 11);
            label1.Name = "label1";
            label1.Size = new Size(421, 22);
            label1.TabIndex = 1;
            label1.Text = "Talabalar davomatini manitoring qilish bo'limi";
            // 
            // btnInfo
            // 
            btnInfo.BackColor = Color.Green;
            btnInfo.Dock = DockStyle.Left;
            btnInfo.FlatAppearance.BorderSize = 0;
            btnInfo.FlatAppearance.MouseDownBackColor = Color.Green;
            btnInfo.FlatAppearance.MouseOverBackColor = Color.Green;
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnInfo.ForeColor = Color.White;
            btnInfo.Location = new Point(0, 0);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(54, 43);
            btnInfo.TabIndex = 0;
            btnInfo.Text = "≡";
            btnInfo.UseVisualStyleBackColor = false;
            btnInfo.Click += btnInfo_Click;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.FlatStyle = FlatStyle.System;
            comboBox1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "211-KIDT", "212-KIDT" });
            comboBox1.Location = new Point(31, 98);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(859, 33);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "  Guruxni tanlang";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBox2.FlatStyle = FlatStyle.System;
            comboBox2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(31, 141);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(1153, 33);
            comboBox2.TabIndex = 2;
            comboBox2.Text = "  Fanni tanlang";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoSize = true;
            panel2.Controls.Add(pnlStudents);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(31, 190);
            panel2.Name = "panel2";
            panel2.Size = new Size(1153, 547);
            panel2.TabIndex = 3;
            // 
            // pnlStudents
            // 
            pnlStudents.AutoScroll = true;
            pnlStudents.Dock = DockStyle.Fill;
            pnlStudents.Location = new Point(0, 39);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new Size(1153, 508);
            pnlStudents.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1153, 39);
            panel3.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(890, 6);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 1;
            label4.Text = "Davomat";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(158, 6);
            label3.Name = "label3";
            label3.Size = new Size(261, 25);
            label3.TabIndex = 0;
            label3.Text = "Talabanning familyasi va ismi";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker1.CalendarFont = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(896, 99);
            dateTimePicker1.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(288, 31);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.Value = new DateTime(2023, 4, 25, 0, 0, 0, 0);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 762);
            Controls.Add(dateTimePicker1);
            Controls.Add(panel2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Davomat";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnInfo;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Panel panel2;
        private Panel panel3;
        private Label label4;
        private Label label3;
        private Panel pnlStudents;
        private DateTimePicker dateTimePicker1;
    }
}