public class Program
{
    static void Main(string[] args)
    {
      
        BankingView view = new BankingView();
        double balance = 1000.0; 
        string name = "Bill Zaire R. Sevillano"; 
        double lastTransaction = 0.0;

        view.ShowWelcomeMessage();

        bool exitProgram = false;
        while (!exitProgram)
        {

            view.ShowMenu();

            string choice = view.GetMenuChoice();

            
            switch (choice)
            {
                case "1":
                    view.ShowCurrentBalance(BankingService.GetBalance(balance));
                    break;

                case "2": 
                    double depositAmount = view.GetDepositAmount();
                    if (BankingService.Deposit(ref balance, depositAmount))
                    {
                        lastTransaction = depositAmount;
                        view.ShowDepositSuccess(depositAmount, balance);
                    }
                    else
                    {
                        view.ShowInvalidAmount();
                    }
                    break;

                case "3":
                    double withdrawAmount = view.GetWithdrawAmount();
                    bool withdrawalSuccess;
                    BankingService.Withdraw(ref balance, withdrawAmount, out withdrawalSuccess);

                    if (withdrawalSuccess)
                    {
                        lastTransaction = -withdrawAmount;
                        view.ShowWithdrawalSuccess(withdrawAmount, balance);
                    }
                    else
                    {
                        view.ShowInsufficientBalance();
                    }
                    break;

                case "4":
                    view.ShowMiniStatement(name, balance, lastTransaction);
                    break;

                case "5":
                    view.ShowGoodbyeMessage();
                    exitProgram = true; // Exit the program
                    break;

                default:
                    view.ShowInvalidOption();
                    break;
            }

            if (!exitProgram)
            {
                Console.Write("\nDo you want to perform another operation? (Y/N): ");
                string continueChoice = Console.ReadLine();
                if (continueChoice.ToUpper() != "Y")
                {
                    view.ShowGoodbyeMessage();
                    exitProgram = true;
                }
            }
        }
    }
}
