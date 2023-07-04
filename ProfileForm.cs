using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace My_Journal
{
    public partial class ProfileForm : Form
    {

        private MySqlCommandBuilder sqlCommandBuilder = null;

        private MySqlDataAdapter sqlDataAdapter = null;

        private DataSet dataSet = null;

        DB db = new DB();
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void seeMyEntriesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecordTable form = new RecordTable();
            form.Show();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            db.openConnection();
            LoadData();
        }


        private void LoadData()
        {
            try
            {
                sqlDataAdapter = new MySqlDataAdapter("SELECT * FROM user", db.getConnection());
                sqlCommandBuilder = new MySqlCommandBuilder(sqlDataAdapter);

                sqlCommandBuilder.GetInsertCommand();
                sqlCommandBuilder.GetUpdateCommand();
                sqlCommandBuilder.GetDeleteCommand();
                dataSet = new DataSet();

                sqlDataAdapter.Fill(dataSet, "user");

                dataGridViewProfile.DataSource = dataSet.Tables["user"];

            }

            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error while downloading user taable data from db", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
