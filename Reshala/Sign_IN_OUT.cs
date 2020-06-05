using Reshala;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace authorization
{
    public partial class Sign_IN_OUT : Form
    {
        private SqlConnection sqlConnection = null;

        private SqlDataAdapter addapter = null;

        private DataTable table = null;


        public Sign_IN_OUT()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string select = "SELECT login, pass FROM [user] WHERE login ='" + maskedTextBox1.Text + "' AND pass ='" + maskedTextBox2.Text + "'";

            if (!string.IsNullOrEmpty(maskedTextBox1.Text) && !string.IsNullOrWhiteSpace(maskedTextBox1.Text) &&
              !string.IsNullOrEmpty(maskedTextBox2.Text) && !string.IsNullOrWhiteSpace(maskedTextBox2.Text))
            {
                addapter = new SqlDataAdapter(select, sqlConnection);

                table = new DataTable();

                addapter.Fill(table);

                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("Неверный логин или пароль", "ВНИМАНИЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Авторизация пройдена", "УСПЕШНО", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Сюда вставить код перехода на некст форму 
                    Switcher switcher = new Switcher();
                    this.Hide();
                    switcher.ShowDialog();
                    //Удалит только после закрытия диалога
                    maskedTextBox1 = null;
                    maskedTextBox2 = null;
                }
            }
            else
            {
                MessageBox.Show("Поля не заполнены все поля", "!!!ВНИМАНИЕ!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Krouri\Downloads\reshala4life-master\Reshala\UserBase.mdf;Integrated Security=True");
            sqlConnection.Open();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string insert = "INSERT INTO [user] (login, pass) VALUES (@login, @pass)";

            string select = "SELECT login, pass FROM [user] WHERE login = '" + maskedTextBox1.Text + "'";

            if (!string.IsNullOrEmpty(maskedTextBox1.Text) && !string.IsNullOrWhiteSpace(maskedTextBox1.Text) &&
              !string.IsNullOrEmpty(maskedTextBox2.Text) && !string.IsNullOrWhiteSpace(maskedTextBox2.Text))
            {
                addapter = new SqlDataAdapter(select, sqlConnection);

                table = new DataTable();

                addapter.Fill(table);

                if (table.Rows.Count == 0)
                {
                    SqlCommand command = new SqlCommand(insert, sqlConnection);

                    command.Parameters.AddWithValue("login", maskedTextBox1.Text);

                    command.Parameters.AddWithValue("pass", maskedTextBox2.Text);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Регистрация прошла успешно", "УСПЕШНО", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Сюды тоже можно пихнуть код на некст форму
                }
                else
                {
                    MessageBox.Show("Логин занят. Введите новый логин", "!!!ВНИМАНИЕ!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Поля не заполнены все поля", "!!!ВНИМАНИЕ!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Sign_IN_OUT_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

