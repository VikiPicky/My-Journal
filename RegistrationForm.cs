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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace My_Journal
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();

            nameField.Text = "add name";
            nameField.ForeColor = Color.Red;

            ProgramField.Text = "name of your program";
            ProgramField.ForeColor = Color.Red;

            emailField.Text = "ALGONQUIN email address only";
            emailField.ForeColor = Color.Red;
        }

        Point lastPoint;
        private void RegistrationForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void RegistrationForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void closeButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void nameField_Enter(object sender, EventArgs e)
        {
            if (nameField.Text == "add name")
            {
                nameField.Text = "";
                nameField.ForeColor = Color.Black;
            }

        }

        private void nameField_Leave(object sender, EventArgs e)
        {
            if (nameField.Text == "")
            {

                nameField.Text = "add name";
                nameField.ForeColor = Color.Red;
            }

        }

        private void ProgramField_Enter(object sender, EventArgs e)
        {
            if (ProgramField.Text == "name of your program")
            {
                ProgramField.Text = "";
                ProgramField.ForeColor = Color.Black;
            }

        }

        private void ProgramField_Leave(object sender, EventArgs e)
        {
            if (ProgramField.Text == "")
            {

                ProgramField.Text = "name of your program";
                ProgramField.ForeColor = Color.Red;
            }

        }

        private void emailField_Enter(object sender, EventArgs e)
        {
            if (emailField.Text == "ALGONQUIN email address only")
            {
                emailField.Text = "";
                emailField.ForeColor = Color.Black;
            }

        }

        private void emailField_Leave(object sender, EventArgs e)
        {
            if (emailField.Text == "")
            {

                emailField.Text = "ALGONQUIN email address only";
                emailField.ForeColor = Color.Red;
            }

        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            checkEmptyFields();

            if (UserExists())
                return;

            if (!ValidateEmail())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `user` (`name`, `program`, `email`, `password`) VALUES (@name, @program, @email, @password);", db.getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameField.Text;
            command.Parameters.Add("@program", MySqlDbType.VarChar).Value = ProgramField.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = emailField.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passField.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("account created");
            else
                MessageBox.Show("creation failed");

            db.closeConnection();

        }

        public Boolean ValidateEmail() {

            string address = emailField.Text;
            string host = address.Split('@')[1];

            if (host == "algonquinlive.com")
            {
                MessageBox.Show("Welcome to Algonquin Student");
                return true;
            }
            else {
                MessageBox.Show("Only available to Algonquin Student");
                return false;
            }
        }

        public void checkEmptyFields()
        {

            if (nameField.Text == "add name")
            {
                MessageBox.Show("type your name");
                return;
            }

            if (ProgramField.Text == "name of your program")
            {
                MessageBox.Show("type your program name");
                return;
            }

            if (emailField.Text == "ALGONQUIN email address only")
            {
                MessageBox.Show("type your email");
                return;
            }


            if (passField.Text == "")
            {
                MessageBox.Show("create password");
                return;
            }

        }

        public Boolean UserExists()
        {

            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM user WHERE email = @email", db.getConnection());
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = emailField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("User already exists");
                return true;
            }

            MessageBox.Show("User can be added");
            return false;
        }

        private void BackToLoginLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
