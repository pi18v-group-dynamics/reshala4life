using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;


// Если получится запихать в твое меню, то запихивай только форма вызывается так   ZaidelV20.ZaidelV20 zaidel = new ZaidelV20.ZaidelV20();
namespace authorization
{
    public partial class ZaidelV20 : Form
    {
        Sign_IN_OUT sign = (Sign_IN_OUT)Application.OpenForms["Sign_IN_OUT"];

       public  bool isStartLocal;

        public ZaidelV20()
        {
            InitializeComponent();
        }

        private string DefaultText = String.Format("{0:f}", 0.0);

        // создает текстарию и назначает ему кое какие свойства
        private TextBox InitTextBox(bool readOnly)
        {
            TextBox textBox = new TextBox();
            textBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox.Text = DefaultText;
            textBox.ReadOnly = readOnly;
            if (!readOnly)
            {
                textBox.CausesValidation = true;
                textBox.Validating += ValidateTextBox;
            }
            return textBox;
        }

        // проверка валидности текста в текстарии
        private void ValidateTextBox(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            double result;
            e.Cancel = !double.TryParse(textBox.Text, out result);
        }

        // создаёт вдумерный массив текстарий, вставляя каждую в таблицу расположения
        private TextBox[,] InitTextBoxMatrix(TableLayoutPanel layoutPanel, int count, bool readOnly)
        {
            layoutPanel.SuspendLayout();

            layoutPanel.Controls.Clear();

            layoutPanel.ColumnStyles.Clear();
            layoutPanel.ColumnCount = count;

            layoutPanel.RowStyles.Clear();
            layoutPanel.RowCount = count;

            TextBox[,] result = new TextBox[count, count];
            float cellSize = 1f / count * 100f;

            for (int col = 0; col < count; ++col)
            {
                layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, cellSize));
                for (int row = 0; row < count; ++row)
                {
                    layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, cellSize));

                    TextBox textBox = InitTextBox(readOnly);

                    layoutPanel.Controls.Add(textBox, col, row);
                    result[col, row] = textBox;
                }
            }

            layoutPanel.ResumeLayout(true);

            return result;
        }

        // создаёт одномерный массив текстарий, вставляя каждую таблицу расположения
        private TextBox[] InitTextBoxArray(TableLayoutPanel layoutPanel, int count, bool readOnly)
        {
            layoutPanel.SuspendLayout();

            layoutPanel.Controls.Clear();

            layoutPanel.ColumnStyles.Clear();
            layoutPanel.ColumnCount = 1;

            layoutPanel.RowStyles.Clear();
            layoutPanel.RowCount = count;

            TextBox[] result = new TextBox[count];
            float cellSize = 1f / count * 100f;

            layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));

            for (int row = 0; row < count; ++row)
            {
                layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, cellSize));
                TextBox textBox = InitTextBox(readOnly);
                layoutPanel.Controls.Add(textBox, 0, row);
                result[row] = textBox;
            }
            layoutPanel.ResumeLayout(true);
            return result;
        }
        private int n;
        private TextBox[,] matrixA;
        private TextBox[] vectorB;
        private TextBox[] vectorX;
        private TextBox[] vectorU;
        private void InitMatrixA()
        {
            matrixA = InitTextBoxMatrix(layoutMatrixA, n, false);
        }
        private void InitVectorX()
        {
            vectorX = InitTextBoxArray(layoutVectorX, n, true);
        }
        private void InitVectorB()
        {
            vectorB = InitTextBoxArray(layoutVectorB, n, false);
        }
        private void InitVectorU()
        {
            vectorU = InitTextBoxArray(layoutVectorU, n, true);
        }
        public int N
        {
            get { return n; }
            set
            {
                if (value != n && value > 0)
                {
                    n = value;
                    InitMatrixA();
                    InitVectorX();
                    InitVectorB();
                    InitVectorU();
                }
            }
        }
        private void ZaidelV20_Load(object sender, EventArgs e)
        {
            N = (int)numericUpDown1.Value;
            isStartLocal = sign.isStartLocal; //если на авторизации инглиш, то тут будет false
            if (!isStartLocal) // если isStartLocal == false
            {
                isStartLocal = true;
                ChangeLanguage(); //сменит язык на английский
            }
            else //если на авторизации русский, то тут будет true
            {
                isStartLocal = false;
                ChangeLanguage(); //сменит язык на английский
            }

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            N = (int)numericUpDown1.Value;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                try
                {
                    File.AppendAllText(@"..\LOG\Log.txt", "\r\nЗапуск алгоритма решения СЛАУ методом Зейделя(Гаусса-Зейделя)\r\n");
                    var watch = Stopwatch.StartNew();
                    String str = "";
                    LinearSystem system = new LinearSystem(MatrixA, VectorB);
                    VectorX = system.XVector;
                    VectorU = system.UVector;
                    foreach(var item in system.XVector)
                    {
                        str += item + " ";
                    }    
                    watch.Stop();
                    MessageBox.Show(isStartLocal ? sign.Rus[22] + watch.Elapsed : sign.Eng[22] + watch.Elapsed/*"Время затраченное на решение СЛАУ методом Зейделя(Гаусса-Зейделя): "*/  /*или watch.ElapsedMilliseconds*/, isStartLocal ? sign.Rus[23] : sign.Eng[23] /*"Затраченное время"*/, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    File.AppendAllText(@"..\LOG\Log.txt", "\r\nЗавершение алгоритма решения СЛАУ методом Зейделя(Гаусса-Зейделя). \r\n\tЗатраченное время: " + watch.Elapsed+ " \r\n\tРезультат решения СЛАУ для каждого уравнения по порядку:" + str + "\r\n");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        public double[,] MatrixA
        {
            get
            {
                // собираем введённую пользователем матрицу A
                double[,] matrix_a = new double[n, n];
                for (int i = 0; i < n; ++i)
                    for (int j = 0; j < n; ++j)
                        matrix_a[i, j] = double.Parse(matrixA[j, i].Text);
                return matrix_a;
            }
            set
            {
                // записываем в текстбоксы матрицу A
                for (int i = 0; i < n; ++i)
                    for (int j = 0; j < n; ++j)
                        matrixA[j, i].Text = value[i, j].ToString("f");
            }
        }
        public double[] VectorB
        {
            get
            {
                // собираем введённый пользователем вектор B
                double[] vector_b = new double[n];
                for (int j = 0; j < n; ++j)
                    vector_b[j] = double.Parse(vectorB[j].Text);
                return vector_b;
            }
            set
            {
                // записываем в текстбоксы вектор B
                for (int j = 0; j < n; ++j)
                    vectorB[j].Text = value[j].ToString("f");
            }
        }
        public double[] VectorX
        {
            set
            {
                // показываем вычисленный результат X
                for (int j = 0; j < n; ++j)
                    vectorX[j].Text = value[j].ToString("f");
            }
        }
        public double[] VectorU
        {
            set
            {
                // показываем вычисленную невязку U
                for (int j = 0; j < n; ++j)
                    vectorU[j].Text = value[j].ToString("e");
            }
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void пример1ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            numericUpDown1.Value = 3;
            MatrixA = new double[,]
                { { 3.0, -9.0,   3.0 },
                  { 2.0, -4.0,   4.0 },
                  { 1.0,  8.0, -18.0 } };
            VectorB = new double[] { -18.0, -10.0, 35.0 };
        }
        private void пример2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 4;
            MatrixA = new double[,]
                { { 2.0, 3.0, 5.0,  2.0 },
                  { 2.0, 2.0, 4.0,  3.0 },
                  { 3.0, 6.0, 3.0,  5.0 },
                  { 2.0, 5.0, 3.0,  7.0  } };
            VectorB = new double[] { 4.0, 3.0, 8.0, 9.0 };
        }
        private void пример3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 4;
            MatrixA = new double[,]
                { { 1.0, 6.0, 4.0,    1.0 },
                  { 6.0, 4.0, 4.0,    6.0 },
                  { 0.0, 1.0, 566.0,  7.0 },
                  { 2.0, 4.0, 5.0,    6.0  } };
            VectorB = new double[] { 4.0, 6.0, 6.0, 6.0 };
        }

        private void пример4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 5;
            MatrixA = new double[,] {
                {7.0, 1.0, 3.0, 2.0, 4.0},
                {9.0, 2.0, 4.0, 2.0, 1.0},
                {4.0, 2.0, 1.0, 3.0, 4.0},
                {1.0, 3.0, 1.0, 2.0, 1.0},
                {2.0, 1.0, 2.0, 4.0, 3.0}
            };
            VectorB = new double[] { 4.0, 2.0, 5.0, 3.0, 1.0 };
        }

        void ChangeLanguage()
        {
            if (isStartLocal)
            {
                isStartLocal = false; //был русский стал не русский
                тестовыеПримерыToolStripMenuItem.Text = sign.Eng[17];//автозаполнение
                this.Text = sign.Eng[15];//подпись формы
                button1.Text = sign.Eng[16];//решить слау
                label1.Text = sign.Eng[20];//размерность
                label2.Text = sign.Eng[21];//матрица
                label4.Text = sign.Eng[18];//результат
                label5.Text = sign.Eng[19];//погрешность
                пример1ToolStripMenuItem.Text = sign.Eng[24];
                пример2ToolStripMenuItem.Text = sign.Eng[25];
                пример3ToolStripMenuItem.Text = sign.Eng[26];
                пример4ToolStripMenuItem.Text = sign.Eng[27];
            }
            else
            if (!isStartLocal)
            {
                isStartLocal = true;
                тестовыеПримерыToolStripMenuItem.Text = sign.Rus[17];//автозаполнение
                this.Text = sign.Rus[15];//подпись формы
                button1.Text = sign.Rus[16];//решить слау
                label1.Text = sign.Rus[20];//размерность
                label2.Text = sign.Rus[21];//матрица
                label4.Text = sign.Rus[18];//результат
                label5.Text = sign.Rus[19];//погрешность
                пример1ToolStripMenuItem.Text = sign.Rus[24];
                пример2ToolStripMenuItem.Text = sign.Rus[25];
                пример3ToolStripMenuItem.Text = sign.Rus[26];
                пример4ToolStripMenuItem.Text = sign.Rus[27];
            }
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangeLanguage();

        }

        private void ZaidelV20_FormClosing(object sender, FormClosingEventArgs e)
        {
            sign.Show();
        }
    }
}