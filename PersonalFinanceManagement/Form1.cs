using DGVPrinterHelper;
using System.Data;

namespace PersonalFinanceManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            remains.Text = MainFinance.remains.ToString();
            debt.Text = MainFinance.debt.ToString();
            savings.Text = MainFinance.savings.ToString();
            averageIncome.Text = MainFinance.averageIncome.ToString();
            averageExpenses.Text = MainFinance.averageExpenses.ToString();
            averageRemains.Text = MainFinance.averageRemains.ToString();
            balance.Text = Accumulation.balance.ToString();
            putAside.Text = Accumulation.putAside.ToString();
            purpose.Text = Accumulation.purpose.ToString();
            income.Text = MainFinance.income.ToString();
            expenses.Text = MainFinance.expenses.ToString();
            term.Text = Accumulation.term.ToString();
            FillDataGridView();
        }

        private void calculation_Click(object sender, EventArgs e)
        {
            MainFinance.Calculation(Int32.Parse(income.Text), Int32.Parse(expenses.Text));
            MainFinance.AverageIncomeExpenses();
            remains.Text = MainFinance.remains.ToString();
            debt.Text = MainFinance.debt.ToString();
            savings.Text = MainFinance.savings.ToString();
            averageIncome.Text = MainFinance.averageIncome.ToString();
            averageExpenses.Text = MainFinance.averageExpenses.ToString();
            averageRemains.Text = MainFinance.averageRemains.ToString();
            FillDataGridView();
        }

        private void enterSavings_Click(object sender, EventArgs e)
        {
            string sum = "";
            if (InputBox("���� �����", "������� �����, ������� ������ �������� � ����������", ref sum) == DialogResult.OK)
            {
                MainFinance.AddSavings(sum);
                savings.Text = MainFinance.savings.ToString();
            }
        }

        public static DialogResult InputBox(string title, string promptText, ref string sum)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            form.Text = title;
            label.Text = promptText;
            buttonOk.Text = "������";
            buttonOk.DialogResult = DialogResult.OK;
            label.SetBounds(36, 36, 372, 13);
            textBox.SetBounds(36, 86, 500, 20);
            buttonOk.SetBounds(200, 160, 160, 60);
            label.AutoSize = true;
            form.ClientSize = new Size(600, 300);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk });
            form.AcceptButton = buttonOk;
            DialogResult dialogResult = form.ShowDialog();
            sum = textBox.Text;
            return dialogResult;
        }

        private void payoffDebt_Click(object sender, EventArgs e)
        {
            string sum = "";
            if (MainFinance.debt < 0)
            {
                if (InputBox("���� �����", "������� �����, ������� ������ ��������", ref sum) == DialogResult.OK)
                {
                    MainFinance.PayOffDebt(sum);
                    debt.Text = MainFinance.debt.ToString();
                    savings.Text = MainFinance.savings.ToString();
                }
            }
        }

        private void �alculationPutAside_Click(object sender, EventArgs e)
        {
            Accumulation.CalculationPutAside(Int32.Parse(term.Text), Int32.Parse(purpose.Text));
            putAside.Text = Accumulation.putAside.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sum = "";
            if (MainFinance.savings > 0)
            {
                if (InputBox("���� �����", "������� �����, ������� ������ �������� � ����������", ref sum) == DialogResult.OK)
                {
                    Accumulation.AddInBalance(sum);
                    balance.Text = Accumulation.balance.ToString();
                    savings.Text = MainFinance.savings.ToString();
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string sum = "";
            if (Accumulation.balance > 0)
            {
                if (InputBox("���� �����", "������� �����, ������� ������ ������� � ����������", ref sum) == DialogResult.OK)
                {
                    Accumulation.RemoveFromBalance(sum);
                    balance.Text = Accumulation.balance.ToString();
                    savings.Text = MainFinance.savings.ToString();
                }
            }
        }

        private void createReport_Click(object sender, EventArgs e)
        {
            var dgvPrinter = new DGVPrinter();
            dgvPrinter.CreateReport("����� �� ������� � �������� �� ��������� 6 �������", dataGridView1);
        }
        private void FillDataGridView()
        {
            // �������� ������� ������
            DataTable dataTable = new DataTable();

            // ���������� ��������
            dataTable.Columns.Add("����� ������", typeof(string));
            dataTable.Columns.Add("������", typeof(string));
            dataTable.Columns.Add("�������", typeof(string));
            dataTable.Columns.Add("�������", typeof(string));

            // ���������� ������ � �������
            dataTable.Rows.Add("1", MainFinance.incomeArray[0].ToString(), MainFinance.expensesArray[0].ToString(), MainFinance.remainsArray[0].ToString());
            dataTable.Rows.Add("2", MainFinance.incomeArray[1].ToString(), MainFinance.expensesArray[1].ToString(), MainFinance.remainsArray[1].ToString());
            dataTable.Rows.Add("3", MainFinance.incomeArray[2].ToString(), MainFinance.expensesArray[2].ToString(), MainFinance.remainsArray[2].ToString());
            dataTable.Rows.Add("4", MainFinance.incomeArray[3].ToString(), MainFinance.expensesArray[3].ToString(), MainFinance.remainsArray[3].ToString());
            dataTable.Rows.Add("5", MainFinance.incomeArray[4].ToString(), MainFinance.expensesArray[4].ToString(), MainFinance.remainsArray[4].ToString());
            dataTable.Rows.Add("6", MainFinance.incomeArray[5].ToString(), MainFinance.expensesArray[5].ToString(), MainFinance.remainsArray[5].ToString());
            dataTable.Rows.Add("�����", MainFinance.incomeSum.ToString(), MainFinance.expensesSum.ToString(), MainFinance.remainsSum.ToString());

            // �������� ������� ������ � DataGridView
            dataGridView1.DataSource = dataTable;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }
    }
}
