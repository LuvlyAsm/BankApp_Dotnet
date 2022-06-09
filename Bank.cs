using System;

namespace BankApp;

public class Bank {
    private string name,password;
    int amount;

    //Default
   public Bank(){}
    //constructor
   public Bank(string name,string password,int amount){
        this.name=name;
        this.password=password;
        this.amount=amount;}

    //return for check
       public string getName(){return name;}
       public string getPassword(){return password;}

    public void operation(){
        Console.WriteLine("Enter to Continue\n1.Deposit\n2.Withdraw\n3.Balance\n4.Transaction History\n5.LogOut\n");
        string choise=Console.ReadLine();
        switch(choise){
            case "1":deposit();
                break;
            case "2":withdraw();
                break;
            case "3":balance();
                break;
            case "4":transaction();
                break;
            case "5":logOut();
                break;
            default:
                Console.WriteLine("Invalid");
                operation();
                break;
        }
    }

    List<String> transactionHistory=new List<String>();

    void deposit(){
        Console.WriteLine("Enter a Amount to be Deposit...:");
        var depositAmount=Console.ReadLine();
        //int intID = int . Parse (varID.ToString ());
        amount=amount+int.Parse(depositAmount.ToString());
        Console.WriteLine("After Deposit Account Balance is :"+amount);
        transactionHistory.Add("+"+depositAmount);
        operation();
    }
    void withdraw(){
        Console.WriteLine("Enter How Much You Want to Withdraw...");
        var withdrawAmount=Console.ReadLine();
        amount=amount-int.Parse(withdrawAmount.ToString());
        Console.WriteLine("Your Account Balance is :"+amount);
        transactionHistory.Add("-"+withdrawAmount);
        operation();
    }
    void balance(){
        Console.WriteLine("Your Account Balance is : "+amount);
        operation();
    }

    void transaction(){
        Console.WriteLine("Your Transaction History is :");
        for(int i=0;i<transactionHistory.Count;i++){
            Console.WriteLine(transactionHistory[i]);
        }
        operation();
    }
    void logOut(){
        Console.WriteLine("Successfully Logged Out :)");
        Validation validation=new Validation();
        validation.validate();
    }
}