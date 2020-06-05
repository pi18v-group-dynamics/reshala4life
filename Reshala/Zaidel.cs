using authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reshala
{
    public partial class Zaidel : Form
    {
        bool isEdit = false;
        public Zaidel()
        {
            InitializeComponent();
        }

        private void Zaidel_Load(object sender, EventArgs e)
        {
            comboBox_Column.SelectedItem = comboBox_Column.Items[0];
        }

        private void button_Solve_Click(object sender, EventArgs e)
        {
            var watch = Stopwatch.StartNew();
            for (int i = 1; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    if(String.IsNullOrWhiteSpace(dataGridView1.Rows[j].Cells[i].Value?.ToString()) || dataGridView1.CurrentCell.Value?.ToString() == "-")
                    dataGridView1.Rows[j].Cells[i].Value = 0;
                }
            }
            //Собсна сам агоритм. Саня я в тебя верю (/°о°)/






            //а потом вывод затраченого времени
            watch.Stop();
            MessageBox.Show("Время затраченное на решение СЛАУ методоом Гаусса: " + watch.Elapsed /*или watch.ElapsedMilliseconds*/, "Затраченное время", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            /*и запись результатов в лог. Допустим чтобы разделить пользователей в логе можно использовать их логин(либо из БД, либо из формы авторизации используя 
            !!!!!
            Sign_IN_OUT authorizationForm = (Sign_IN_OUT)Application.OpenForms["Sign_IN_OUT"];
            !!!!!
            если её не закрывать а прятать). Думаю лог можно на одном языке сделать.
            */
        }

        private void button_AutoValues_Click(object sender, EventArgs e)
        {
            //Рандом наше всё
            Random rand = new Random();
            for (int i = 1; i < dataGridView1.Columns.Count; i++)
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                    dataGridView1[i, j].Value = rand.Next(-10, 10);
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPress);

            TextBox textBox = e.Control as TextBox;
            if (textBox != null)
                textBox.KeyPress += new KeyPressEventHandler(Column_KeyPress);
        }
        private void Column_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar) && e.KeyChar != '-' && !char.IsWhiteSpace(e.KeyChar) /*&& !char.IsDigit(e.KeyChar)*/)
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && e.KeyChar == '-' && isEdit != false)
            {
                e.Handled = true;
            }
            else isEdit = true;

        }

        private void comboBox_Column_SelectedValueChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count - 1 > int.Parse(comboBox_Column.SelectedItem.ToString()))//если к примеру было 8 переменных, а стало 2
            {
                dataGridView1.Columns.Clear(); //удаляю коллекцию столбцов
                //DataGridViewTextBoxColumn Column_Result = new DataGridViewTextBoxColumn();
                //DataGridViewTextBoxColumn Column1 = new DataGridViewTextBoxColumn();
                //DataGridViewTextBoxColumn Column2 = new DataGridViewTextBoxColumn();
                dataGridView1.Columns.Add("Column_Result", "Результат"); //добавляю первый фиксированный столбец
                dataGridView1.Columns["Column_Result"].Frozen = true;

                for (int i = dataGridView1.Columns.Count; i <= int.Parse(comboBox_Column.SelectedItem.ToString()); i++) //добавляю выбранное количество столбцов
                {
                    dataGridView1.Columns.Add("Column" + i, "Переменная " + i);
                }
                dataGridView1.Rows.Add(int.Parse(comboBox_Column.SelectedItem.ToString())); //добавляю указанное количество строк
            }
            else   //если к примеру было 2 переменных, а стало 5, то добавляю столбцы начиная со 2-го
            {
                for (int i = dataGridView1.Columns.Count; i <= int.Parse(comboBox_Column.SelectedItem.ToString()); i++)
                {
                    dataGridView1.Columns.Add("Column" + i, "Переменная " + i);
                }
                dataGridView1.Rows.Add(Math.Abs(int.Parse(comboBox_Column.SelectedItem.ToString()) - dataGridView1.Rows.Count)); //добавляю указанное количество строк
            }
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count >= 2)
            {
                if (dataGridView1.CurrentCell.Value?.ToString() == "-")
                {
                    dataGridView1.CurrentCell.Value = null;
                    isEdit = false;
                }
                else isEdit = true;

            }
            
        }
    }
}
