using System;

namespace BankApp{

public class Validation{

    public void validate(){
        
        List<Bank> accounts=new List<Bank>();
        Bank customer1=new Bank("ASM","Password@123",1200);
        Bank customer2=new Bank("Kavi","Password@1234",1100);
        Bank customer3=new Bank("Ravi","Password@123456",1000);
        Bank customer4=new Bank("Mahesh","Password@123456",1000);
        accounts.Add(customer1);
        accounts.Add(customer2);
        accounts.Add(customer3);
        accounts.Add(customer4);

        
        Console.WriteLine("Welcome to our ABC Bank...\nEnter to continue....\n1.LogIn\n2.Signup");
        string userChoise = Console.ReadLine();
     
        if(userChoise.Equals("1"))
        {
            try{
                Console.WriteLine("Enter Username");
            string name=Console.ReadLine();
                 Console.WriteLine("Enter Password");
            string passwd=Console.ReadLine();



            foreach(Bank accountDetails in accounts){
            
            
               if(name.Equals(accountDetails.getName())&&passwd.Equals(accountDetails.getPassword())){
                Console.WriteLine("Logged In Successfully");
                   accountDetails.operation();}
               else{Console.WriteLine("Error"); }
               
               }
            }
            catch(Exception exception){
                    Console.WriteLine(exception);
                    validate();
            }
            
        }
        else if(userChoise.Equals("2")){

        Console.WriteLine("Enter Username");
            string name=Console.ReadLine();
        
        Console.WriteLine("Enter Password");
            string password=Console.ReadLine();
        
        Console.WriteLine("Enter amount to deposit");
            var amt=Console.ReadLine();
            
            Bank bankk=new Bank(name,password,int.Parse(amt));
            accounts.Add(bankk);
            bankk.operation();
        }

        else{
        Console.WriteLine("Input Invalid");
        }
    }



}


}