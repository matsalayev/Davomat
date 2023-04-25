using Npgsql;
using System.Data;

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
        }
        private void btnInfo_Click(object sender, EventArgs e)
        {
            info info = new info();
            info.ShowDialog();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
                comboBox2.Items.Add(" " + row[0].ToString());
            }
            conn.Open();
            sql = $@"select fio from talabalar where guruh = {int.Parse(comboBox1.SelectedItem.ToString().Replace(" ", "").Split("-")[0])}";
            cmd = new NpgsqlCommand(sql, conn);
            data = new DataTable();
            data.Load(cmd.ExecuteReader());
            conn.Close();
            students.Clear();
            foreach (DataRow row in data.Rows) students.Add(row[0].ToString());
        }

        void showStudents()
        {
            conn.Open();
            sql = $@"select talaba_id from davomat as d inner join talabalar as t on t.id = d.talaba_id where sana = '{dateTimePicker1.Value.Year}-{dateTimePicker1.Value.Month}-{dateTimePicker1.Value.Day}' and fan_id = {comboBox2.SelectedIndex + 1} and t.guruh =" + int.Parse(comboBox1.SelectedItem.ToString().Replace(" ", "").Split("-")[0]);
            cmd = new NpgsqlCommand(sql, conn);
            data = new DataTable();
            data.Load(cmd.ExecuteReader());
            conn.Close();
            davomat = new CheckBox[students.Count];
            for (int i = 0; i < students.Count; i++) davomat[i] = new CheckBox();
            try
            {
                foreach (DataRow row in data.Rows) davomat[int.Parse(row.ItemArray[0].ToString()) - 1].Checked = true;
            }
            catch { }
            int raqam = 0;
            foreach (var temp in davomat)
            {
                if (!temp.Checked) raqam++;
            }
            lblSon.Text = raqam + " ta";
            pnlStudents.AutoScroll = false;
            pnlStudents.Controls.Clear();
            for (int i = 0; i < students.Count; i++)
            {
                Panel panel = new Panel();
                panel.Size = new Size(pnlStudents.Width, 35);
                panel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                panel.BorderStyle = BorderStyle.None;
                panel.Location = new Point(0, 0 + 35 * i);
                if (i % 2 == 1) panel.BackColor = Color.FromArgb(222, 222, 222);
                else panel.BackColor = Color.FromArgb(240, 240, 240);
                Label label = new Label();
                label.Anchor = AnchorStyles.Left;
                label.Font = new Font("Segoe UI", 10.8F);
                label.Location = new Point(10, 6);
                label.Size = new Size(350, 25);
                label.Text = (i + 1) + ". " + students[i];
                panel.Controls.Add(label);
                davomat[i].Anchor = AnchorStyles.Right;
                davomat[i].CheckedChanged += new EventHandler(checkBox_CheckedChanged);
                davomat[i].Size = new Size(25, 25);
                davomat[i].Location = new Point(pnlStudents.Width - 241, 6);
                panel.Controls.Add(davomat[i]);
                pnlStudents.Controls.Add(panel);
            }
            pnlStudents.AutoScroll = true;
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
            try
            {
                string ismlar = string.Empty;
                for (int i = 0; i < davomat.Length; i++) if (davomat[i].Checked) ismlar += students[i] + ", ";
                MessageBox.Show($"{dateTimePicker1.Value.ToString().Split()[0]} kuni {comboBox2.SelectedItem.ToString().Replace(" ", "")} fanida {comboBox1.SelectedItem.ToString().Replace(" ", "")} guruxidan {ismlar.Substring(0, ismlar.Length - 2)} yo'q.");
                for (int i = 0; i < davomat.Length; i++)
                {
                    if (davomat[i].Checked)
                    {
                        conn.Open();
                        sql = @"INSERT INTO davomat (talaba_id, fan_id, davomat, sana) VALUES
                            (:_talaba_id, :_fan_id, :_davomat, :_sana)";
                        cmd = new NpgsqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("_talaba_id", i + 1);
                        cmd.Parameters.AddWithValue("_fan_id", comboBox2.SelectedIndex + 1);
                        cmd.Parameters.AddWithValue("_davomat", true);
                        cmd.Parameters.AddWithValue("_sana", dateTimePicker1.Value);
                        cmd.ExecuteScalar();
                        conn.Close();
                    }
                }

            }
            catch
            {
                MessageBox.Show("Qoldirilgan darsni o'zlashtirgach yo'qlamani baza orqali o'chirishingiz mumkin bo'ladi!");
                showStudents();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            showStudents();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1) showStudents();
        }
    }
}