namespace PersonalFinanceManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            label3 = new Label();
            income = new TextBox();
            label1 = new Label();
            expenses = new TextBox();
            remains = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            averageIncome = new TextBox();
            averageExpenses = new TextBox();
            savings = new TextBox();
            debt = new TextBox();
            payoffDebt = new Button();
            balance = new TextBox();
            label9 = new Label();
            createReport = new Button();
            label10 = new Label();
            term = new TextBox();
            label11 = new Label();
            label12 = new Label();
            putAside = new TextBox();
            AddMoney = new Button();
            calculation = new Button();
            enterSavings = new Button();
            label13 = new Label();
            averageRemains = new TextBox();
            button2 = new Button();
            purpose = new TextBox();
            label14 = new Label();
            сalculationPutAside = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 9);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 2;
            label2.Text = "Доходы";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 78);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 3;
            label3.Text = "Расходы";
            // 
            // income
            // 
            income.Location = new Point(25, 32);
            income.Name = "income";
            income.Size = new Size(153, 27);
            income.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 149);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 5;
            label1.Text = "Остаток";
            // 
            // expenses
            // 
            expenses.Location = new Point(25, 101);
            expenses.Name = "expenses";
            expenses.Size = new Size(153, 27);
            expenses.TabIndex = 6;
            // 
            // remains
            // 
            remains.Location = new Point(25, 172);
            remains.Name = "remains";
            remains.ReadOnly = true;
            remains.Size = new Size(153, 27);
            remains.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(250, 9);
            label4.Name = "label4";
            label4.Size = new Size(298, 20);
            label4.TabIndex = 8;
            label4.Text = "Средние доходы за последние 6 месяцев";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(250, 78);
            label5.Name = "label5";
            label5.Size = new Size(305, 20);
            label5.TabIndex = 8;
            label5.Text = "Средние расходы за последние 6 месяцев";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(470, 150);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 9;
            label6.Text = "Сбережения";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(678, 150);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 10;
            label7.Text = "Долг";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(25, 468);
            label8.Name = "label8";
            label8.Size = new Size(250, 35);
            label8.TabIndex = 11;
            label8.Text = "Накопление на цель";
            // 
            // averageIncome
            // 
            averageIncome.Location = new Point(250, 32);
            averageIncome.Name = "averageIncome";
            averageIncome.ReadOnly = true;
            averageIncome.Size = new Size(153, 27);
            averageIncome.TabIndex = 12;
            // 
            // averageExpenses
            // 
            averageExpenses.Location = new Point(250, 101);
            averageExpenses.Name = "averageExpenses";
            averageExpenses.ReadOnly = true;
            averageExpenses.Size = new Size(153, 27);
            averageExpenses.TabIndex = 13;
            // 
            // savings
            // 
            savings.Location = new Point(470, 173);
            savings.Name = "savings";
            savings.ReadOnly = true;
            savings.Size = new Size(153, 27);
            savings.TabIndex = 14;
            // 
            // debt
            // 
            debt.Location = new Point(678, 173);
            debt.Name = "debt";
            debt.ReadOnly = true;
            debt.Size = new Size(153, 27);
            debt.TabIndex = 15;
            // 
            // payoffDebt
            // 
            payoffDebt.Location = new Point(678, 236);
            payoffDebt.Name = "payoffDebt";
            payoffDebt.Size = new Size(153, 80);
            payoffDebt.TabIndex = 16;
            payoffDebt.Text = "Погасить долг из сбережений на указанную сумму";
            payoffDebt.UseVisualStyleBackColor = true;
            payoffDebt.Click += payoffDebt_Click;
            // 
            // balance
            // 
            balance.Location = new Point(25, 526);
            balance.Name = "balance";
            balance.ReadOnly = true;
            balance.Size = new Size(334, 27);
            balance.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 503);
            label9.Name = "label9";
            label9.Size = new Size(58, 20);
            label9.TabIndex = 18;
            label9.Text = "Баланс";
            // 
            // createReport
            // 
            createReport.Location = new Point(25, 370);
            createReport.Name = "createReport";
            createReport.Size = new Size(520, 81);
            createReport.TabIndex = 19;
            createReport.Text = "Создать отчёт";
            createReport.UseVisualStyleBackColor = true;
            createReport.Click += createReport_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15F);
            label10.Location = new Point(25, 332);
            label10.Name = "label10";
            label10.Size = new Size(330, 35);
            label10.TabIndex = 11;
            label10.Text = "Создать отчёт за 6 месяцев";
            // 
            // term
            // 
            term.Location = new Point(678, 526);
            term.Name = "term";
            term.Size = new Size(153, 27);
            term.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(678, 503);
            label11.Name = "label11";
            label11.Size = new Size(385, 20);
            label11.TabIndex = 21;
            label11.Text = "Срок, на который планируется накопление в месяцах";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(678, 575);
            label12.Name = "label12";
            label12.Size = new Size(426, 20);
            label12.TabIndex = 22;
            label12.Text = "Средства, которые необходимо откладывать каждый месяц";
            // 
            // putAside
            // 
            putAside.Location = new Point(678, 598);
            putAside.Name = "putAside";
            putAside.ReadOnly = true;
            putAside.Size = new Size(153, 27);
            putAside.TabIndex = 23;
            // 
            // AddMoney
            // 
            AddMoney.Location = new Point(25, 573);
            AddMoney.Name = "AddMoney";
            AddMoney.Size = new Size(153, 52);
            AddMoney.TabIndex = 24;
            AddMoney.Text = "Добавить средства";
            AddMoney.UseVisualStyleBackColor = true;
            AddMoney.Click += button1_Click;
            // 
            // calculation
            // 
            calculation.Location = new Point(25, 236);
            calculation.Name = "calculation";
            calculation.Size = new Size(378, 80);
            calculation.TabIndex = 25;
            calculation.Text = "Рассчитать";
            calculation.UseVisualStyleBackColor = true;
            calculation.Click += calculation_Click;
            // 
            // enterSavings
            // 
            enterSavings.Location = new Point(470, 236);
            enterSavings.Name = "enterSavings";
            enterSavings.Size = new Size(153, 80);
            enterSavings.TabIndex = 26;
            enterSavings.Text = "Внести сбережения";
            enterSavings.UseVisualStyleBackColor = true;
            enterSavings.Click += enterSavings_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(250, 149);
            label13.Name = "label13";
            label13.Size = new Size(126, 20);
            label13.TabIndex = 27;
            label13.Text = "Средний остаток";
            // 
            // averageRemains
            // 
            averageRemains.Location = new Point(250, 172);
            averageRemains.Name = "averageRemains";
            averageRemains.ReadOnly = true;
            averageRemains.Size = new Size(153, 27);
            averageRemains.TabIndex = 28;
            // 
            // button2
            // 
            button2.Location = new Point(206, 574);
            button2.Name = "button2";
            button2.Size = new Size(153, 50);
            button2.TabIndex = 29;
            button2.Text = "Вернуть средства в сбережения";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // purpose
            // 
            purpose.Location = new Point(470, 526);
            purpose.Name = "purpose";
            purpose.Size = new Size(153, 27);
            purpose.TabIndex = 30;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(470, 503);
            label14.Name = "label14";
            label14.Size = new Size(44, 20);
            label14.TabIndex = 31;
            label14.Text = "Цель";
            // 
            // сalculationPutAside
            // 
            сalculationPutAside.Location = new Point(468, 574);
            сalculationPutAside.Name = "сalculationPutAside";
            сalculationPutAside.Size = new Size(155, 50);
            сalculationPutAside.TabIndex = 32;
            сalculationPutAside.Text = "Рассчитать";
            сalculationPutAside.UseVisualStyleBackColor = true;
            сalculationPutAside.Click += сalculationPutAside_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(557, 441);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(10, 10);
            dataGridView1.TabIndex = 33;
            dataGridView1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 650);
            Controls.Add(dataGridView1);
            Controls.Add(сalculationPutAside);
            Controls.Add(label14);
            Controls.Add(purpose);
            Controls.Add(button2);
            Controls.Add(averageRemains);
            Controls.Add(label13);
            Controls.Add(enterSavings);
            Controls.Add(calculation);
            Controls.Add(AddMoney);
            Controls.Add(putAside);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(term);
            Controls.Add(createReport);
            Controls.Add(label9);
            Controls.Add(balance);
            Controls.Add(payoffDebt);
            Controls.Add(debt);
            Controls.Add(savings);
            Controls.Add(averageExpenses);
            Controls.Add(averageIncome);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(remains);
            Controls.Add(expenses);
            Controls.Add(label1);
            Controls.Add(income);
            Controls.Add(label3);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "MyFinances";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox income;
        private Label label1;
        private TextBox expenses;
        private TextBox remains;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox averageIncome;
        private TextBox averageExpenses;
        private TextBox savings;
        private TextBox debt;
        private Button payoffDebt;
        private TextBox balance;
        private Label label9;
        private Button createReport;
        private Label label10;
        private TextBox term;
        private Label label11;
        private Label label12;
        private TextBox putAside;
        private Button AddMoney;
        private Button calculation;
        private Button enterSavings;
        private Label label13;
        private TextBox averageRemains;
        private Button button2;
        private TextBox purpose;
        private Label label14;
        private Button сalculationPutAside;
        private DataGridView dataGridView1;
    }
}
