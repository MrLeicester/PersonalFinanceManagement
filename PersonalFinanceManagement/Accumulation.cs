namespace PersonalFinanceManagement
{
    internal class Accumulation
    {
        public static int balance { get; set; } = 0;
        public static int purpose { get; set; } = 0;
        public static int term { get; set; } = 0;
        public static int putAside { get; set; } = 0;

        public static void CalculationPutAside(int termFunc, int purposeFunc)
        {
            term = termFunc;
            purpose = purposeFunc;
            putAside = purpose / term;
        }

        public static void AddInBalance(string sum)
        { 
            if(MainFinance.savings > Int32.Parse(sum))
            {
                balance += Int32.Parse(sum);
                MainFinance.savings -= Int32.Parse(sum);
            }
            else
            {
                balance += MainFinance.savings;
                MainFinance.savings = 0;
            }
        }

        public static void RemoveFromBalance(string sum)
        {
            if (balance > Int32.Parse(sum))
            {
                balance -= Int32.Parse(sum);
                MainFinance.savings += Int32.Parse(sum);
            }
            else
            {
                MainFinance.savings += balance;
                balance = 0;
            }
        }
    }
}
