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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SaveEntryButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `record` (`record`, `date`) VALUES (@record, @date);", db.getConnection());
            command.Parameters.Add("@record", MySqlDbType.VarChar).Value = recordField.Text;
            command.Parameters.Add("@date", MySqlDbType.VarChar).Value = textBox1.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("record created");
            else
                MessageBox.Show("record creation failed");

            db.closeConnection();
        }

        private void viewEntries_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                RecordTable recordTable = new RecordTable();
                recordTable.Show();
            }
        }
    }
}
