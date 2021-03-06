using System;

namespace OOP_HW_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var Vasia = new bank_account(0, account_types.Credit);
            var Petiya = new bank_account(0, account_types.Calculated);
            Console.WriteLine($"Номер счёта {Vasia.account_number}");
            Console.WriteLine($"Тип счёта {Vasia.account_type}");
            Console.WriteLine($"Старый баланс Васи {Vasia.balance}");
            Vasia.balance = 100;
            Console.WriteLine($"Новый баланс Васи {Vasia.balance}");
            Console.ReadKey();
            Console.Clear();

            //Задание №1
            Console.WriteLine("Вася перевёл Пете 30");
            Petiya.transferMoney(Vasia, 30);
            Console.WriteLine($"Новый баланс Васи {Vasia.balance}");
            Console.WriteLine($"Новый баланс Пети {Petiya.balance}");
            Console.ReadKey();
            Console.Clear();

            // Задание №2
            string Revers(string str)
            {
                string revStr = "";
                char[] charArr = str.ToCharArray();
                for (int i = charArr.Length - 1; i >= 0; i--)
                {
                    revStr = revStr + charArr[i];
                }
                return revStr;
            }
            var hello = "Hello World!";
            Console.WriteLine(hello);
            Console.WriteLine(Revers(hello));          
            Console.ReadKey();
        }
        public enum account_types
        {
            Current,
            Calculated,
            Credit,
            Deposit
        }
        class bank_account
        {
            public int account_number { get; set; }

            public double balance { get; set; }
            public account_types account_type { get; set; }

            private static Random rnd = new Random();

            public bank_account()
            {
                this.account_number = rnd.Next();
            }
            public bank_account(double balance)
            {
                this.account_number = rnd.Next();
                this.balance = balance;
            }
            public bank_account(account_types account_type)
            {
                this.account_number = rnd.Next();
                this.account_type = account_type;
            }
            public bank_account(double balance, account_types account_type)
            {
                this.account_number = rnd.Next();
                this.balance = balance;
                this.account_type = account_type;
            }

            //Задание №1
            public void transferMoney(bank_account account, double sum)
            {
                if (account.balance >= sum)
                {
                    account.balance = account.balance - sum;
                    this.balance = this.balance + sum;
                }
                else
                {
                    Console.WriteLine("Операция невозможна, недостаточно средств.");
                }
            }
        }
    }
}
