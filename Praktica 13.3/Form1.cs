using System.Runtime.InteropServices;

namespace Praktica_13._3
    {
    public partial class Form1 : Form
    {

        private DataGridViewColumn dataGridViewColumn1 = null;
        private DataGridViewColumn dataGridViewColumn2 = null;
        private DataGridViewColumn dataGridViewColumn3 = null;
        private DataGridViewColumn dataGridViewColumn4 = null;

        private IList<Mebel> students = new List<Mebel>();
        public Form1()
        {
            InitializeComponent();
            initDataGridView();
        }

        private void initDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Add(GetDataGridViewColumn1());
            dataGridView1.Columns.Add(GetDataGridViewColumn2());
            dataGridView1.Columns.Add(GetDataGridViewColumn3());
            dataGridView1.Columns.Add(GetDataGridViewColumn4());
            dataGridView1.AutoResizeColumns();
        }

        private DataGridViewColumn GetDataGridViewColumn1()
        {
            if (dataGridViewColumn1 == null)
            {
                dataGridViewColumn1 = new DataGridViewTextBoxColumn();
                dataGridViewColumn1.Name = "";
                dataGridViewColumn1.HeaderText = "Вес";
                dataGridViewColumn1.ValueType = typeof(int);
                dataGridViewColumn1.Width = dataGridView1.Width / 4;
            }
            return dataGridViewColumn1;
        }

        private DataGridViewColumn GetDataGridViewColumn2()
        {
            if (dataGridViewColumn2 == null)
            {
                dataGridViewColumn2 = new DataGridViewTextBoxColumn();
                dataGridViewColumn2.Name = "";
                dataGridViewColumn2.HeaderText = "Количество";
                dataGridViewColumn2.ValueType = typeof(int);
                dataGridViewColumn2.Width = dataGridView1.Width / 4;
            }
            return dataGridViewColumn2;
        }

        private DataGridViewColumn GetDataGridViewColumn3()
        {
            if (dataGridViewColumn3 == null)
            {
                dataGridViewColumn3 = new DataGridViewTextBoxColumn();
                dataGridViewColumn3.Name = "";
                dataGridViewColumn3.HeaderText = "Цвет";
                dataGridViewColumn3.ValueType = typeof(string);
                dataGridViewColumn3.Width = dataGridView1.Width / 4;
            }
            return dataGridViewColumn3;
        }

        private DataGridViewColumn GetDataGridViewColumn4()
        {
            if (dataGridViewColumn4 == null)
            {
                dataGridViewColumn4 = new DataGridViewTextBoxColumn();
                dataGridViewColumn4.Name = "";
                dataGridViewColumn4.HeaderText = "Тип";
                dataGridViewColumn4.ValueType = typeof(string);
                dataGridViewColumn4.Width = dataGridView1.Width / 4;
            }
            return dataGridViewColumn4;
        }

        private void addMebel(string tip, string color, int ves, int kolv)
        {

            Mebel s = new Mebel(tip, color, ves, kolv);
            students.Add(s);
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            radioButton1.Text = "";
            showListInGrid();
        }

        private void showListInGrid()
        {
            try
            {


                dataGridView1.Rows.Clear();
                foreach (Mebel s in students)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell cell2 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell cell3 = new DataGridViewTextBoxCell();
                    DataGridViewTextBoxCell cell4 = new DataGridViewTextBoxCell();

                    cell1.ValueType = typeof(string);
                    cell1.Value = s.getTip();
                    cell2.ValueType = typeof(string);
                    cell2.Value = s.getColor();
                    cell3.ValueType = typeof(int);
                    cell3.Value = s.getVes();
                    cell3.ValueType = typeof(int);
                    cell3.Value = s.getKolv();
                    row.Cells.Add(cell1);
                    row.Cells.Add(cell2);
                    row.Cells.Add(cell3);
                    row.Cells.Add(cell4);
                    dataGridView1.Rows.Add(row);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка вводимые символы введены не верно");
            }
        }




        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool chis1 = radioButton1.Text.Any(char.IsLetter);
            bool chis2 = textBox1.Text.Any(char.IsLetter);
            bool bukv = textBox2.Text.Any(char.IsLetter);
            bool bukt = comboBox1.Text.Any(char.IsDigit);

            if (chis1 || chis2 || bukv || bukt)
            {
                MessageBox.Show("Ошибка", "В первый двух строках должны быть буквы");
            }
        }
           
              
    }
}
