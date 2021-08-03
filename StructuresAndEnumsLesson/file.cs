using System;

enum AccountState
{ // all enum varianles are constants and can not be changed
  New = 1,
  Active,
  UnderAudit,
  Frozen,
  Closed
};

enum Cart: ushort // enums also can have other literal types
{
  Ordered = 65_535,
  Current = 0
};

struct Account  // structures are collection of different things about particular item
{
  public AccountState State;
  public string Name;
  public string Address;
  public int AccountNumber;
  public int Balance;
  public int Overdraft;
}

class MainClass {
  public static void Main (string[] args) {
    const int MAX_CUST = 100;

    AccountState[] states = new AccountState [MAX_CUST];
    string[] names = new string [MAX_CUST];
    int[] accountNos = new int [MAX_CUST];
    int[] balances = new int [MAX_CUST];
    int[] overdraft = new int [MAX_CUST];

    Account RobsAccount = new Account();
    Account[] Bank = new Account[MAX_CUST];

    RobsAccount.Name = "Rob";
    RobsAccount.State = AccountState.Active;  // setting enum type to the struct
    RobsAccount.Address = "Robs house";
    RobsAccount.Balance = 100000;
    Bank[0] = RobsAccount; Console.WriteLine("Bank[0].Name - " + Bank[0].Name);
    PrintAccount(RobsAccount);  // passing account instance in the method call
    Bank[1].Name = "Jim";
    Bank[1].Balance = 0;
    Bank[1].Address = "Jim's car";
    Bank[1].State = AccountState.New;
    PrintAccount(Bank[1]);  // printing array is possible because bank[] is an instance of struct Account

    for (int i = 0; i < Bank.Length; i++)
    {
      if(Bank[i].Balance == 0)
        Bank[i].State = AccountState.Frozen;
      if(Bank[i].Name == "Jim")
        Console.WriteLine(Bank[i].State);
    }

    RobsAccount.State = AccountState.Closed;

    int myCart = (int)Cart.Current + 1; // it is possible to represent enum type as an int, not a state
    Cart otherCart = Cart.Ordered;      // it is also possible to declare new enum type as its component. Thats why they are named "enums"
    Console.WriteLine(myCart);
  }

  public static void PrintAccount ( Account a )    // Using Structure Types in Method Calls
  {
    Console.WriteLine( "\nName: " + a.Name );
    Console.WriteLine( "Address: " + a.Address );
    Console.WriteLine( "Balance: " + a.Balance );
  }

  //It is also possible to create methods that return results which are of a structure type,
  // for example we could create a ReadAccountmethod that reads an account and returns it
}