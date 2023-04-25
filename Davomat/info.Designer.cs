namespace Davomat
{
    partial class info
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
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Menu;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(547, 400);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(221, 344);
            button1.Name = "button1";
            button1.Size = new Size(94, 33);
            button1.TabIndex = 2;
            button1.Text = "Chiqish";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 272);
            label1.Name = "label1";
            label1.Size = new Size(517, 46);
            label1.TabIndex = 1;
            label1.Text = "Ta’lim muassasasida talabalar davomatini monitoring qilish tizimi.\r\nUrganch davlat universiteti 211-212 KIDT guruxi talabalari misolida.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.UrSU;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(168, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 200);
            panel2.TabIndex = 0;
            // 
            // info
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 400);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "info";
            StartPosition = FormStartPosition.CenterParent;
            Text = "info";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button button1;
    }
}