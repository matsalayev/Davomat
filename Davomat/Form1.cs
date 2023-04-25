//using Npgsql;
//using System.Data;

using Microsoft.Win32.SafeHandles;

namespace Davomat
{
    public partial class Form1 : Form
    {
        //private string connectionString = String.Format("Server = localhost; Port=5432; User Id = postgres; Password = matsalayev; Database = kidt;");
        //private NpgsqlConnection conn;
        //private string sql;
        //private NpgsqlCommand cmd;
        //private DataTable data;
        CheckBox[] davomat;
        public Form1()
        {
            InitializeComponent();
            davomat = new CheckBox[25];
            showStudents();

        }
        private void btnInfo_Click(object sender, EventArgs e)
        {
            info info = new info();
            info.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void showStudents()
        {
            pnlStudents.Controls.Clear();
            int soni = 0;
            for (int i = 0; i < 25; i++)
            {
                Panel panel = new Panel();
                panel.Size = new Size(1156, 35);
                panel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                panel.BorderStyle = BorderStyle.None;
                panel.Location = new Point(0, 0 + 35 * i);
                if (i % 2 == 0) panel.BackColor = Color.FromArgb(222, 222, 222);
                else panel.BackColor = Color.FromArgb(240, 240, 240);
                Label label = new Label();
                label.Anchor = AnchorStyles.Left;
                label.Font = new Font("Segoe UI", 10.8F);
                label.Location = new Point(10, 6);
                label.Size = new Size(261, 25);
                label.Text = (i + 1) + ". Polonkasov polonkas";
                panel.Controls.Add(label);
                davomat[i] = new CheckBox();
                davomat[i].Anchor = AnchorStyles.Right;
                davomat[i].CheckedChanged += new EventHandler(checkBox_CheckedChanged);
                davomat[i].Checked = false;
                davomat[i].Location = new Point(915, 6);
                panel.Controls.Add(davomat[i]);
                pnlStudents.Controls.Add(panel);
                soni++;
            }
            lblSon.Text = soni.ToString() + " ta";
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            int raqam = 0;
            foreach (var temp in davomat)
            {
                if (!temp.Checked) raqam++;
            }
            lblSon.Text = raqam + " ta";
        }
    }
}