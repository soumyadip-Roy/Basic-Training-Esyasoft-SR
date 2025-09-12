using System.Security.Cryptography;

namespace BankConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string generateHello()
            {
                Console.WriteLine("Welcome to EBank");
                Console.Write("Please Enter your Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Welcome " + name);

                return name;
            }

            long askAccountNum()
            {
                //Console.WriteLine("Welcome to EBank");
                Console.Write("Please Enter your Acc Number: ");
                long accNum = Convert.ToInt64((Console.ReadLine()));
                //Console.WriteLine("Welcome " + na);

                return accNum;
            }




            int generateMenu()
            {
                // Writing the Bank Website options:

                Console.WriteLine("Please Select The Options As Given Below: ");
                Console.WriteLine("[1] --> Create A New Bank Account.");
                Console.WriteLine("[2] --> Deposit Money.");
                Console.WriteLine("[3] --> Withdraw Money.");
                Console.WriteLine("[4] --> Display Account Details.");
                Console.WriteLine("[5] --> Exit.");
                Console.Write("Please Enter the Option Number You would like: ");
                int optionNumber = Convert.ToInt16(Console.ReadLine());
                return optionNumber;              


            }

            string generateNewAccount(string name,string panNum, string aadharNum, string phoneNum, long accNum)
            {
                //string panNum;
                //string aadharNum;
                //string phoneNum;
                

                Console.WriteLine("Hi " + name + "Please Verify if you have given us the correct name");
                Console.Write("Type y/n");
                if (Convert.ToChar(Console.ReadLine()) == 'y') {
                    Console.WriteLine("Please Your Provide PAN Number: ");
                    panNum = Console.ReadLine();
                    Console.WriteLine("Please Your Provide AADHAR Number: ");
                    aadharNum = Console.ReadLine();
                    Console.WriteLine("Please Your Provide Moblie Phone Number: ");
                    phoneNum = Console.ReadLine();

                    Console.WriteLine("Please verify the details: ");
                    Console.WriteLine("PAN Number: "+panNum);
                    Console.WriteLine("AADHAR Number: "+aadharNum);
                    Console.WriteLine("Phone Number: "+phoneNum);
                    Console.Write("Type y/n");
                    char userDesc = Convert.ToChar(Console.ReadLine());
                    if(userDesc == 'y')
                    {
                        accNum = 333300000000 + RandomNumberGenerator.GetInt32(1000000000);
                        Console.WriteLine("Welcome " + name + " to the Family!");
                        Console.WriteLine("Here are the account details: ");
                        Console.WriteLine("Name: " + name);
                        Console.WriteLine("Account Number: " + accNum);
                        Console.WriteLine("IFSC Code: 1006575");
                        Console.WriteLine("Thank You.");
                        return "accountCreationComplete";
                    } 
                    else
                    {
                        Console.WriteLine("Please enter your details carefully this time: ");
                        Console.WriteLine("Please Your Provide PAN Number: ");
                        panNum = Console.ReadLine();
                        Console.WriteLine("Please Your Provide AADHAR Number: ");
                        aadharNum = Console.ReadLine();
                        Console.WriteLine("Please Your Provide Moblie Phone Number: ");
                        phoneNum = Console.ReadLine();

                        Console.WriteLine("Please verify the details: ");
                        Console.WriteLine("PAN Number: " + panNum);
                        Console.WriteLine("AADHAR Number: " + aadharNum);
                        Console.WriteLine("Phone Number: " + phoneNum);
                        Console.Write("Type y/n");
                        if (userDesc == 'y')
                        {
                            accNum = 333300000000 + RandomNumberGenerator.GetInt32(1000000000);
                            Console.WriteLine("Welcome " + name + " to the Family!");
                            Console.WriteLine("Here are the account details: ");
                            Console.WriteLine("Name: " + name);
                            Console.WriteLine("Account Number: " + accNum);
                            Console.WriteLine("IFSC Code: 1006575");
                            Console.WriteLine("Thank You.");
                            return "accountCreationComplete";
                        }
                        else
                        {
                            Console.WriteLine("There is some error, reverting to home page");
                            return "error";
                        }

                    }


                }
                else
                {
                    Console.WriteLine("There is some error, reverting to home page");
                    return "error";
                }


            }

            long depositMoney(string name, long accNum, int prevBalance) {
                Console.WriteLine("Previous account balance: " + prevBalance);
                Console.WriteLine("Please enter the amount of money to be deposited: ");
                int depositMoney = Convert.ToInt32(Console.ReadLine());
                prevBalance += depositMoney;
                Console.WriteLine("Current account balance: " + prevBalance);

                return prevBalance;
                
            }

            long withdrawMoney(string name, long accNum, int prevBalance)
            {
                Console.WriteLine("Previous account balance: " + prevBalance);
                Console.WriteLine("Please enter the amount of money to be withdrawn: ");
                int withdrawMoney = Convert.ToInt32(Console.ReadLine());
                prevBalance -= withdrawMoney;
                if (prevBalance < 0)
                {
                    Console.WriteLine("Insufficient Balance");
                    return 101010;
                }
                Console.WriteLine("Current account balance: " + prevBalance);

                return prevBalance;

            }

            void displayAccDetails(string name, long accNum, int prevBalance)
            {
                Console.WriteLine("Hi " + name + ", These are your account details: ");
                Console.WriteLine(" Name: "+name);
                Console.WriteLine(" Acc Number: " + accNum);
                Console.WriteLine(" Amount Present: " + prevBalance);
            }

            string name;
            string panNum = "default";
            string aadharNum = "default";
            string phoneNum = "default";
            long accNum = 0;
            int prevBalance = 0;

            name = generateHello();
            int errorvar = 0;
            
            while (errorvar==0)
            {
                Console.Write("Do you have an account? (y/n)");
                char userInp = Convert.ToChar(Console.ReadLine());
                if(userInp == 'y') {
                    accNum = askAccountNum();
                    int userChoice = generateMenu();
                    switch (userChoice)
                    {
                        case 1:
                            generateNewAccount(name, panNum, aadharNum, phoneNum, accNum);
                            break;
                        case 2:
                            depositMoney(name,accNum,prevBalance);
                            break;
                        case 3:
                            withdrawMoney(name, accNum, prevBalance);
                            break;
                        case 4:
                            displayAccDetails(name, accNum, prevBalance);
                            break;
                        case 5:
                            Console.WriteLine("Thank You for Visiting EBank!");
                            errorvar = 1;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please Create a new Account:");
                    string action = generateNewAccount(name, panNum, aadharNum, phoneNum, accNum);
                    errorvar = 1;
                    
                }
                
            }
            






        }
    }
}
