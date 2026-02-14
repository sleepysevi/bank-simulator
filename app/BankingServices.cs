 public static class BankingServices
    {
        private static double lastTransactionAmount = 0;

        public static double GetBalance(double balance)
        {
            return balance;
        }

        public static double GetLastTransaction()
        {
            return lastTransactionAmount;
        }

        public static bool Deposit(ref double balance, double amount)
        {
            if (amount <= 0)
            {
                return false;
            }

            balance = balance + amount;
            lastTransactionAmount = amount;
            return true;
        }

        public static void Withdraw(ref double balance, double amount, out bool isSuccessful)
        {
            isSuccessful = false;

            if (amount <= 0)
            {
                return;
            }

            if (amount > balance)
            {
                return;
            }

            balance = balance - amount;
            lastTransactionAmount = amount;
            isSuccessful = true;
        }

        public static string GetMiniStatement(double balance, double lastTransaction)
        {
            string text = "";
            text += "--- Mini Statement ---\n";
            text += "Current Balance: P" + balance.ToString("0.00") + "\n";
            text += "Last Transaction Amount: P" + lastTransaction.ToString("0.00");
            return text;
        }
    }
