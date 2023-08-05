using SimplePrograms;
using System.Diagnostics.CodeAnalysis;
//int consumernumber = Convert.ToInt32(Console.ReadLine());
//string? consumername = Console.ReadLine();
//int prevreading = Convert.ToInt32(Console.ReadLine());
//int curreading = Convert.ToInt32(Console.ReadLine());
//string? consumertype = Console.ReadLine();
//ElectricReading electricReading = new ElectricReading(123,"Suriya",2000,3000,"Domestic");
//int billamt = electricReading.CalculateBill();
//Console.WriteLine($"Bill: {electricReading.Consumernumber} {electricReading.Consumername} {billamt}");


//int num1;
//int num2;
//int sum = 0;
//int res;
//num1 = Convert.ToInt32(Console.ReadLine());
//int temp = num1;
//while (num1 != 0)
//{
//    num2 = num1 % 10;
//    res = num2 * num2 * num2;
//    sum = sum + res;
//    num1 = num1 / 10;
//}
//if (sum == temp)
//{
//    Console.WriteLine("armstrong number");
//}
//else
//{
//    Console.WriteLine("Not a armstrong number");
//}

//int num1;
//int sumvalue = 0;
//num1 = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i < num1; i++)
//{
//    if (num1 % i == 0)
//    {
//        sumvalue = sumvalue + i;
//    }
//}
//if (num1 == sumvalue)
//{
//    Console.WriteLine("perfect number");
//}
//else
//{
//    Console.WriteLine("not a perfect number");
//}


////int num1,num2;

////int sumvalue = 0;
////num1 = Convert.ToInt32(Console.ReadLine());
////num2= Convert.ToInt32(Console.ReadLine());
////for (int j = num1; j <=num2; j++)
////{
////    for (int i = 2; i<j; i++)
////    {
////        if (j%i == 0)
////        {
////            sumvalue = sumvalue + 1;
////        }
////    }
////    if (sumvalue == 0)
////    {
////        Console.WriteLine(j);

////    }
////    sumvalue = 0;

////}
///

Console.WriteLine("account name : ");
string holder_name = Console.ReadLine();
Console.WriteLine("deposite amount ");
int deposite = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("withdraw amount :  ");
int withdraw = Convert.ToInt32(Console.ReadLine());


BankAccount bankAccount = new BankAccount(holder_name);

bankAccount.Deposit(deposite);
bankAccount.Withdraw(withdraw);
bankAccount.Display();
Console.ReadLine();

