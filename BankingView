using System;

public class BankingView
{
    public void ShowWelcomeMessage()
    {
        Console.WriteLine("\nWelcome to Sevillano Banking!");
    }

    public string GetUserName()
    {
        Console.Write("Enter your name: ");
        return Console.ReadLine();
    }

    public void ShowMenu()
    {
        Console.WriteLine("\nATM MENU");
        Console.WriteLine("1: Check Balance");
        Console.WriteLine("2: Deposit Money");
        Console.WriteLine("3: Withdraw Money");
        Console.WriteLine("4: Print Mini Statement");
        Console.WriteLine("5: Exit");
    }

    public string GetMenuChoice()
    {
        Console.Write("Please choose an option: ");
        return Console.ReadLine();
    }

    public void ShowCurrentBalance(double balance)
    {
        Console.WriteLine($"Your current balance is: P{balance:F2}");
    }

    public double GetDepositAmount()
    {
        Console.Write("Enter the amount to deposit: P");
        return Convert.ToDouble(Console.ReadLine());
    }

    public double GetWithdrawAmount()
    {
        Console.Write("Enter the amount to withdraw: P");
        return Convert.ToDouble(Console.ReadLine());
    }

    public void ShowDepositSuccess(double deposit, double balance)
    {
        Console.WriteLine($"Deposit successful! +P{deposit:F2}");
        Console.WriteLine($"Updated Balance: P{balance:F2}");
    }

    public void ShowWithdrawalSuccess(double withdraw, double balance)
    {
        Console.WriteLine($"Withdrawal successful. -P{withdraw:F2}");
        Console.WriteLine($"Updated Balance: P{balance:F2}");
    }

    public void ShowInsufficientBalance()
    {
        Console.WriteLine("Withdrawal failed. Insufficient Balance.");
    }

    public void ShowInvalidAmount()
    {
        Console.WriteLine("Invalid amount. Please enter a positive value.");
    }

    public void ShowMiniStatement(string name, double balance, double lastTransaction)
    {
        Console.WriteLine("\n--- Mini Statement ---");
        Console.WriteLine($"Account Holder: {name}");
        Console.WriteLine($"Current Balance: P{balance:F2}");

        if (lastTransaction > 0)
            Console.WriteLine($"Last Transaction: Deposited P{lastTransaction:F2}");
        else if (lastTransaction < 0)
            Console.WriteLine($"Last Transaction: Withdrew P{Math.Abs(lastTransaction):F2}");
        else
            Console.WriteLine("No transactions yet.");
    }

    public void ShowGoodbyeMessage()
    {
        Console.WriteLine("Thank you for using the ATM. Goodbye!");
    }

    public void ShowInvalidOption()
    {
        Console.WriteLine("Invalid option selected. Please try again.");
    }
}
