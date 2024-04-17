using MySql.Data.MySqlClient;

namespace WFA240417
{
    public partial class MainForm : Form
    {
        private string connStr = "SERVER=localhost;DATABASE=people;UID=root;";
        private int selID = -1;

        public MainForm()
        {
            InitializeComponent();
            this.Load += DgvPeopleFillEvent;
            txbFilter.TextChanged += DgvPeopleFillEvent;
            dgvPeople.CellClick += DgvPeople_CellClick;
            btnUpdate.Click += BtnUpdate_Click;
        }

        private void BtnUpdate_Click(object? sender, EventArgs e)
        {
            if (selID == -1) return;

            DialogResult res = 
                MessageBox.Show(
                    caption: "MEGERÕSÍTÉS",
                    text: $"biztosan megváltoztatod {lblSelName.Text} e-mail címét?",
                    icon: MessageBoxIcon.Warning,
                    buttons: MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                using MySqlConnection conn = new(connStr);
                conn.Open();

                MySqlDataAdapter adapter = new()
                {
                    UpdateCommand = new(
                        "UPDATE personal_data " +
                        $"SET email = '{txbEmail.Text}' " +
                        $"WHERE id = {selID};", conn),
                };

                adapter.UpdateCommand.ExecuteNonQuery();

                DgvPeopleFillEvent(null, null);
            }
        }

        private void DgvPeople_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            selID = (int)dgvPeople[0, e.RowIndex].Value;
            lblSelName.Text = $"{dgvPeople[1, e.RowIndex].Value}";
            txbEmail.Text = $"{dgvPeople[3, e.RowIndex].Value}";
        }

        private void DgvPeopleFillEvent(object? sender, EventArgs e)
        {
            dgvPeople.Rows.Clear();

            using MySqlConnection conn = new(connStr);
            conn.Open();

            MySqlDataReader reader = new MySqlCommand(
                "SELECT * FROM personal_data " +
                $"WHERE name LIKE '{txbFilter.Text}%';", conn)
                .ExecuteReader();

            while (reader.Read())
            {
                dgvPeople.Rows.Add(
                    reader[0],reader[1],reader[2],reader[3],reader[4]);
            }
        }
    }
}
