namespace PersonalFinanceManagement
{
    internal class MainFinance
    {
        public static int income { get; set; } = 0;
        public static int expenses { get; set; } = 0;
        public static int remains { get; set; } = 0;
        public static int savings { get; set; } = 0;
        public static int debt { get; set; } = 0;
        public static int[] incomeArray { get; set; } = new int[6];
        public static int[] expensesArray { get; set; } = new int[6];
        public static int[] remainsArray { get; set; } = new int[6];
        public static int averageIncome { get; set; }
        public static int averageExpenses { get; set; }
        public static int averageRemains { get; set; }
        public static int incomeSum { get; set; }
        public static int expensesSum { get; set; }
        public static int remainsSum { get; set; }
        static int i = 0;


        public static void Calculation(int incomeFunc, int expensesFunc)
        {
            income = incomeFunc;
            expenses = expensesFunc;
            remains = income - expenses;
            if (remains > 0)
            {
                savings += remains;
            }
            else
            {
                debt += remains;
            }
        }
        public static void AverageIncomeExpenses()
        {

            if (i < 6)
            {
                incomeArray[i] = income;
                expensesArray[i] = expenses;
                remainsArray[i] = remains;
                i++;
            }
            else
            {
                for (int j = 0; j < 5; j++)
                {
                    incomeArray[j] = incomeArray[j + 1];
                    expensesArray[j] = expensesArray[j + 1];
                    remainsArray[j] = remainsArray[j + 1];
                }
                incomeArray[5] = income;
                expensesArray[5] = expenses;
                remainsArray[5] = remains;
            }
            incomeSum = 0;
            expensesSum = 0;
            remainsSum = 0;
            for (int j = 0; j < 6; j++)
            {
                incomeSum += incomeArray[j];
                expensesSum += expensesArray[j];
                remainsSum += remainsArray[j];
            }

            averageIncome = incomeSum / i;
            averageExpenses = expensesSum / i;
            averageRemains = remainsSum / i;
        }

        public static void AddSavings(string sum)
        {
            savings += Int32.Parse(sum);
        }

        public static void PayOffDebt(string sum)
        {
            if (debt + Int32.Parse(sum) <= 0)
            {
                savings -= Int32.Parse(sum);
                debt += Int32.Parse(sum);
            }
            else
            {
                savings += debt;
                debt = 0;
            }
        }

    }
 

}
