using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ваш счет открыт до 2012? (в этот год мы позволили клиентам вместо номера счета выбирать красивое название)\ny- да  n - нет   Esc - выход");
                ConsoleKeyInfo choose = Console.ReadKey();
                while (choose.Key != ConsoleKey.Escape)
                {
                    {

                        if (choose.Key == ConsoleKey.Y)
                        {
                            Console.Write("\nВведите номер счета: ");
                            int accountNumber = Convert.ToInt32(Console.ReadLine());
                            Random random = new Random(1000000);
                            int balance = random.Next();
                            Console.Write("Введите имя: ");
                            string name = Console.ReadLine();
                            Console.Write("Введите пароль: ");
                            string password = Console.ReadLine();

                            //int accountNumber3 = 1;
                            //int balance3 = 1000000000;
                            //string name3 = "Rockefeller John Davison";
                            //string password3 = "7";
                            BankAccount<int> c = new BankAccount<int>(password, accountNumber, balance, name);
                            c.ShowInfo();
                            Console.WriteLine("\nХотите воспользоваться услугами банка?\ny- да  n - нет)");
                            choose = Console.ReadKey();
                            if (choose.Key == ConsoleKey.Y)
                            {
                                Console.WriteLine("\nВыберите действие:\n1 - положить деньги\n\n2 - снять деньги\n\n3 - Сменить имя\n\n4 - напомнить пароль\n0 - Выход");
                                ConsoleKeyInfo num = Console.ReadKey();
                                do
                                {
                                    switch (num.Key)
                                    {
                                        case ConsoleKey.D1:
                                            {
                                                Console.WriteLine("\nСколько денег вы передали в кассу?(только честно)");
                                                int s = Convert.ToInt32(Console.ReadLine());
                                                c.AddMoney(s);
                                                break;
                                            }
                                        case ConsoleKey.D2:
                                            {
                                                Console.WriteLine("\nСколько денег вы желаете снять?");
                                                int s = Convert.ToInt32(Console.ReadLine());
                                                break;
                                            }
                                        case ConsoleKey.D3:
                                            {
                                                c.ChangeName();
                                                break;
                                            }
                                        case ConsoleKey.D4:
                                            {
                                                string pass = c.GetPassword();
                                                Console.WriteLine(pass);
                                                break;
                                            }
                                        default:
                                            break;
                                    }
                                    c.ShowInfo();
                                    Console.WriteLine("\nВыберите действие:\n1 - положить деньги\n\n2 - снять деньги\n\n3 - Сменить имя\n\n4 - напомнить пароль\n0 - Выход");
                                    num = Console.ReadKey();
                                } while (num.Key != ConsoleKey.D0);
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nЗначит нет\n");
                            Console.Write("\nВведите номер счета: ");
                            string accountNumber = Console.ReadLine();
                            Random random = new Random(1000000);
                            int balance = random.Next();
                            Console.Write("Введите имя: ");
                            string name = Console.ReadLine();
                            Console.Write("Введите пароль: ");
                            string password = Console.ReadLine();
                            //string accountNumber3 = "ZZZZZ4";
                            //int balance3 = 100;
                            //string name3 = "Простой Рабочий Иван";
                            //string password3 = "7";
                            BankAccount<string> c = new BankAccount<string>(password, accountNumber, balance, name);
                            c.ShowInfo();
                            Console.WriteLine("\nХотите воспользоваться услугами банка?\ny- да  n - нет)");
                            choose = Console.ReadKey();
                            if (choose.Key == ConsoleKey.Y)
                            {
                                Console.WriteLine("\nВыберите действие:\n1 - положить деньги\n\n2 - снять деньги\n\n3 - Сменить имя\n\n4 - напомнить пароль\n0 - Выход");
                                ConsoleKeyInfo num = Console.ReadKey();
                                do
                                {
                                    switch (num.Key)
                                    {
                                        case ConsoleKey.D1:
                                            {
                                                Console.WriteLine("\nСколько денег вы передали в кассу?(только честно)");
                                                int s = Convert.ToInt32(Console.ReadLine());
                                                c.AddMoney(s);
                                                break;
                                            }
                                        case ConsoleKey.D2:
                                            {
                                                Console.WriteLine("\nСколько денег вы желаете снять?");
                                                int s = Convert.ToInt32(Console.ReadLine());
                                                c.Donate(s);
                                                break;
                                            }
                                        case ConsoleKey.D3:
                                            {
                                                c.ChangeName();
                                                break;
                                            }
                                        case ConsoleKey.D4:
                                            {
                                                string pass = c.GetPassword();
                                                Console.WriteLine(pass);
                                                break;
                                            }
                                        default:
                                            break;
                                    }
                                    c.ShowInfo();
                                    Console.WriteLine("\nВыберите действие:\n1 - положить деньги\n\n2 - снять деньги\n\n3 - Сменить имя\n\n4 - напомнить пароль\n0 - Выход");
                                    num = Console.ReadKey();
                                } while (num.Key != ConsoleKey.D0);
                            }
                        }
                    }
                    Console.WriteLine("Ваш счет открыт до 2012? (в этот год мы позволили клиентам вместо номера счета выбирать красивое название)\ny- да  n - нет   Esc - выход)");
                    choose = Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }           
        }
           // Console.WriteLine("How much do you want to donate to orphans?");
            //int sum = Convert.ToInt32(Console.ReadLine());
           // c.Donate(sum);
            //c.ShowInfo();
            //int accountNumber = 1;
            //int balance = 1000000000;
            //string name = "Rockefeller John Davison";
            //string password = "7";
            //BankAccount<int> a = new BankAccount<int>(password, accountNumber, balance, name);
          
            //string accountNumber1 = "ZZZZZ4";
            //int balance1 = 100;
            //string name1 = "Простой Рабочий Иван";
            //BankAccount<string> b = new BankAccount<string>(password,accountNumber1, balance1, name1);
         
            //string accountNumber2 = "1";
            //int balance2 = 1000000000;
            //string name2 = "Рокфелер Джон Давидович";
            //string password1 = "77";
            //BankAccount<string> d = new BankAccount<string>(password1,accountNumber2, balance2, name2);
            //a.ShowInfo();
            //b.ShowInfo();
            //d.ShowInfo();
            
        }
    }

