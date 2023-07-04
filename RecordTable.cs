using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.CodeDom;
using System.Linq.Expressions;
using MySqlX.XDevAPI.Relational;

namespace My_Journal
{
    public partial class RecordTable : Form
    {
        private MySqlCommandBuilder sqlCommandBuilder = null;

        private MySqlDataAdapter sqlDataAdapter = null;

        private DataSet dataSet = null;

        DB db = new DB();

        private bool newRowAdding = false;
        public RecordTable()
        {
            InitializeComponent();
        }

        private void RecordTable_Load(object sender, EventArgs e)
        {

            db.openConnection();
            LoadData();

        }

        private void LoadData()
        {
            try
            {
                sqlDataAdapter = new MySqlDataAdapter("SELECT *, 'Delete' FROM record", db.getConnection());

                sqlCommandBuilder = new MySqlCommandBuilder(sqlDataAdapter);

                sqlCommandBuilder.GetInsertCommand();
                sqlCommandBuilder.GetUpdateCommand();
                sqlCommandBuilder.GetDeleteCommand();

                dataSet = new DataSet();

                sqlDataAdapter.Fill(dataSet, "record");

                dataGridView1.DataSource = dataSet.Tables["record"];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {

                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridView1[3, i] = linkCell;
                }
            }

            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error while downloading records taable data from db", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ReLoadData()
        {
            try
            {
                dataSet.Tables["record"].Clear();

                sqlDataAdapter.Fill(dataSet, "record");

                dataGridView1.DataSource = dataSet.Tables["record"];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {

                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridView1[3, i] = linkCell;
                }
            }

            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error while reloading dataset", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UpdateRecordButton_Click(object sender, EventArgs e)
        {
            ReLoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 3)
                {
                    string task = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

                    if (task == "Delete")
                    {
                        if (MessageBox.Show("Do you want to delete this entry?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            int rowIndex = e.RowIndex;
                            dataGridView1.Rows.RemoveAt(rowIndex);
                            dataSet.Tables["record"].Rows[rowIndex].Delete();
                            sqlDataAdapter.Update(dataSet, "record");
                        }
                    }

                    else if (task == "Insert")
                    {
                        int rowIndex = dataGridView1.Rows.Count - 2;
                        DataRow dataRow = dataSet.Tables["record"].NewRow();
                        dataRow["record"] = dataGridView1.Rows[rowIndex].Cells["record"].Value;
                        dataRow["date"] = dataGridView1.Rows[rowIndex].Cells["date"].Value;

                        dataSet.Tables["record"].Rows.Add(dataRow);
                        dataSet.Tables["record"].Rows.RemoveAt(dataSet.Tables["record"].Rows.Count - 1);

                        dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 2);
                        dataGridView1.Rows[e.RowIndex].Cells[3].Value = "Delete";

                        sqlDataAdapter.Update(dataSet, "record");

                        newRowAdding = false;
                    }

                    else if (task == "Update")
                    {
                        int dataRow = e.RowIndex;
                        dataSet.Tables["record"].Rows[dataRow]["record"] = dataGridView1.Rows[dataRow].Cells["record"].Value;
                        dataSet.Tables["record"].Rows[dataRow]["date"] = dataGridView1.Rows[dataRow].Cells["date"].Value;

                        sqlDataAdapter.Update(dataSet, "record");

                        dataGridView1.Rows[e.RowIndex].Cells[3].Value = "Delete";
                    }

                    ReLoadData();
                }
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error while reloading records taable dataset", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                    newRowAdding = true;
                    int lastRow = dataGridView1.Rows.Count - 2;
                    DataGridViewRow row = dataGridView1.Rows[lastRow];
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridView1[3, lastRow] = linkCell;
                    row.Cells["Delete"].Value = "Insert";
                }
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "Error while adding records to the records table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                    int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow editingRow = dataGridView1.Rows[rowIndex];
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridView1[3, rowIndex] = linkCell;
                    editingRow.Cells["Delete"].Value = "Update";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void viewProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileForm form = new ProfileForm();
            form.Show();
        }
    }
}
