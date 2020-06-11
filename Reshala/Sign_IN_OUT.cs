using Reshala;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace authorization
{
    public partial class Sign_IN_OUT : Form
    {
        public String[] Rus = File.ReadAllLines(@"..\RusLoc.txt");
        public String[] Eng = File.ReadAllLines(@"..\EngLoc.txt");
        public bool isStartLocal = true; //стартовый язык русский
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
                    MessageBox.Show(isStartLocal ?  Rus[13] : Eng[13], isStartLocal ? Rus[8] : Eng[8],/*"Неверный логин или пароль", "ВНИМАНИЕ",*/ MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    File.AppendAllText(@"..\LOG\Log.txt", "\r\nОшибка авторизации. Введён неверный логин или пароль");
                }
                else
                {
                    MessageBox.Show(isStartLocal ? Rus[14] : Eng[14], isStartLocal ? Rus[11] : Eng[11],/*"Авторизация пройдена", "УСПЕШНО"*/ MessageBoxButtons.OK, MessageBoxIcon.Information);
                    File.AppendAllText(@"..\LOG\Log.txt", "\r\nПользователь авторизован под логином: " + maskedTextBox1.Text);
                    //Сюда вставить код перехода на некст форму 
                    ZaidelV20 zaidel = new ZaidelV20();
                    this.Hide();
                    zaidel.ShowDialog();
                    File.AppendAllText(@"..\LOG\Log.txt", "\r\nВозврат на окно авторизации.\r\n");
                    if (!zaidel.isStartLocal && isStartLocal)
                        ChangeLanguage();
                    else
                    if (zaidel.isStartLocal && !isStartLocal)
                        ChangeLanguage();
                    //Удалит только после закрытия диалога
                    maskedTextBox1.Text = null;
                    maskedTextBox2.Text = null;
                }
            }
            else
            {
                MessageBox.Show(isStartLocal ? Rus[9] : Eng[9], isStartLocal ? Rus[8] : Eng[8],/*"Не заполнены все поля", "!!!ВНИМАНИЕ!!!"*/ MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Krouri\Downloads\reshala4life-master (1)\reshala4life-master\Reshala\UserBase.mdf; Integrated Security = True"); 
            sqlConnection.Open();
            if (!Directory.Exists(@"..\LOG"))
                Directory.CreateDirectory(@"..\LOG");
            File.AppendAllText(@"..\LOG\Log.txt", "\r\n\nЗапуск программы. \r\nДата запуска: " + DateTime.Now.ToShortDateString() + "\r\nВремя запуска: " +DateTime.Now.ToLongTimeString() + "\r\n");
            if(isStartLocal)
            {
                isStartLocal = false;
                ChangeLanguage();
            }
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

                    MessageBox.Show(isStartLocal ? Rus[12] : Eng[12], isStartLocal ? Rus[11] : Eng[11],/*"Регистрация прошла успешно", "УСПЕШНО"*/ MessageBoxButtons.OK, MessageBoxIcon.Information);
                    File.AppendAllText(@"..\LOG\Log.txt", "\r\nРегистрация нового пользователя. Логин: " + maskedTextBox1.Text);

                }
                else
                {
                    MessageBox.Show(isStartLocal ? Rus[10] : Eng[10], isStartLocal ? Rus[8] : Eng[8],/*"Логин занят. Введите новый логин", "!!!ВНИМАНИЕ!!!"*/ MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                    File.AppendAllText(@"..\LOG\Log.txt", "\r\nОшибка регистраци нового пользователя. Логин <" + maskedTextBox1.Text + "> занят!");
                }
            }
            else
            {
                MessageBox.Show(isStartLocal ? Rus[9] : Eng[9], isStartLocal ? Rus[8] : Eng[8],/*"Не заполнены все поля", "!!!ВНИМАНИЕ!!!"*/ MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Sign_IN_OUT_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.AppendAllText(@"..\LOG\Log.txt", "\r\nЗавершение работы программы. \r\nДата завершения работы: " + DateTime.Now.ToShortDateString() + "\r\nВремя завершения работы: " + DateTime.Now.ToLongTimeString() + "\r\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void ChangeLanguage()
        {
            /*Смена языка*/
            if (isStartLocal) //если руссуий
            {
                isStartLocal = false; //был русский стал не русский
                linkLabel2.Text = Eng[0];
                this.Text = Eng[1];
                linkLabel1.Text = Eng[3];
                label1.Text = Eng[4];
                label2.Text = Eng[5];
                label3.Text = Eng[2];
                button1.Text = Eng[6];
                button2.Text = Eng[7];
            }
            else
            if (!isStartLocal)
            {
                isStartLocal = true;
                linkLabel2.Text = Rus[0];
                this.Text = Rus[1];
                linkLabel1.Text = Rus[3];
                label1.Text = Rus[4];
                label2.Text = Rus[5];
                label3.Text = Rus[2];
                button1.Text = Rus[6];
                button2.Text = Rus[7];
            }
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangeLanguage();
        }
    }
}

