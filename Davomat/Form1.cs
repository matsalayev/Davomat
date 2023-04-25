using Npgsql;
using System.Data;

using Microsoft.Win32.SafeHandles;
using System.Data.Common;

namespace Davomat
{
    public partial class Form1 : Form
    {
        private NpgsqlConnection conn = new NpgsqlConnection(
            "Server = localhost; Port=5432; User Id = postgres; Password = matsalayev; Database = kidt;");
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable data;
        CheckBox[] davomat;
        List<string> students = new List<string>();
        public Form1()
        {
            InitializeComponent();
            showStudents();
        }
        private void btnInfo_Click(object sender, EventArgs e)
        {
            info info = new info();
            info.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                sql = @"select nomi from fanlar";
                cmd = new NpgsqlCommand(sql, conn);
                data = new DataTable();
                data.Load(cmd.ExecuteReader());
                conn.Close();
                comboBox2.Items.Clear();
                foreach (DataRow row in data.Rows)
                {
                    comboBox2.Items.Add(row[0].ToString());
                }
                conn.Open();
                sql = @"select fio from talabalar where guruh = " + int.Parse(comboBox1.SelectedItem.ToString().Split("-")[0]);
                cmd = new NpgsqlCommand(sql, conn);
                data = new DataTable();
                data.Load(cmd.ExecuteReader());
                conn.Close();
                students.Clear();
                foreach (DataRow row in data.Rows)
                {
                    students.Add(row[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void showStudents()
        {

            pnlStudents.Controls.Clear();
            int soni = 0;
            for (int i = 0; i < students.Count; i++)
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
                label.Text = (i + 1) + ". " + students[i];
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            davomat = new CheckBox[students.Count];
            lblSon.Text = students.Count.ToString() + " ta";
            showStudents();
        }
    }
}