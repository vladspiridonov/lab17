using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class BankAccount <T>
    {
        public T accountNumber;        
        private int balance;
        private string name;
        public string password;
        private static string userPassword = "7";
         

        public T AccountNumber
        {
            get
            {
               return accountNumber;                
            }
            set
            {
                if (userPassword == password)
                    accountNumber = value;
               else accountNumber = default(T);
            }
        }
        public int Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (userPassword == password)
                    balance = value;
                else balance = 0;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
               if (userPassword == password)
                    name = value;
               else name = "Wrong password";
            }
        }


        public BankAccount(string password, T accountNumber, int balance, string name)
        {
            this.password = password;
            AccountNumber = accountNumber;
            Balance = balance;
            Name = name;
            
            
        }
        public string GetPassword()
        {
            return userPassword;
        }
        public void ChangeName()
        {
            Console.Write("Введите новое имя: ");
            Name = Console.ReadLine();
        }
        public int GetBalance()
        {

            return balance;
        }
        public void AddMoney(int sum)
        {
            if (sum > 0) Balance += sum;
            else Console.WriteLine("Не удалось пополнить счет");
        }
        public void Donate(int sum)
        {
            if (sum>0) Balance -= sum;
            else Console.WriteLine("Не удалось снять со счета");
        }
        public void ShowInfo()
        {
            Console.WriteLine("Номер счета: {0}", accountNumber);
            Console.WriteLine("Баланс:{0}", balance);            
            Console.WriteLine("ФИО Владельца: {0}", name);

            if (balance < 0) Console.WriteLine("За вами должок. Коллекторы уже направлены к вам.");
        }
    }
}
