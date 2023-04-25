using Npgsql;
using System.Data;

namespace Davomat
{
    public partial class Form1 : Form
    {
        private string connectionString = String.Format("Server = localhost; Port=5432; User Id = postgres; Password = matsalayev; Database = kidt;");
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable data;
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

        }
    }
}