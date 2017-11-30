using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SMSLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            ServiceSMS sender = new ServiceSMS();
            ServiceEmail emailSender = new ServiceEmail();
            List<User> users = new List<User>();
            User currentuser = new User();
            int menu = 0;
            bool result = false;
            while (true)
            {
                Console.Clear();
                switch (menu)
                {
                    case 0:
                        {
                            Console.WriteLine("1. Регистрация");
                            Console.WriteLine("2. Авторизация");
                            Console.WriteLine("3. Выход");
                            Console.Write(":>");
                            result = int.TryParse(Console.ReadLine(), out menu);
                            if (!result)
                                break;
                            break;
                        }
                    case 1:
                        {
                            User tmpUser = new User();
                            Console.Write("ВВедите Имя :>");
                            tmpUser.SetName(Console.ReadLine());
                            Console.Write("ВВедите Email :>");
                            tmpUser.SetEmail(Console.ReadLine());
                            Console.Write("ВВедите пароль :>");
                            tmpUser.SetPassword(Console.ReadLine());
                            Console.Write("ВВедите Телефон (10 цифр, в формате 7083503145) :>");
                            tmpUser.SetPhone(Console.ReadLine());
                            if (users.Contains(tmpUser))
                            {
                                Console.WriteLine("Такой email или телефон уже зарегистрирован");
                                break;
                            }
                            Console.WriteLine("-----------------------------------------");
                            Console.Write("На Ваш номер отправлен код подтверждения, введите его: ");
                            int code = rand.Next(10000, 99999);
                            string text = "Verification SMS CODE: " + code.ToString();
                            sender.SendSms(tmpUser.GetPhone(), text);
                            int verifCode;
                            result = int.TryParse(Console.ReadLine(), out verifCode);
                            if (result)
                            {
                                if (verifCode == code)
                                {
                                    users.Add(tmpUser);
                                    menu = 2;
                                    Console.WriteLine("Вы успешно зарегестрированы!.");

                                }
                                else
                                {
                                    Console.WriteLine("Неверный код!");
                                    menu = 1;
                                }
                            }
                            else
                            {
                                Console.Write("Ошибка Ввода");
                                menu = 1;
                            }
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            int authMenu;
                           
                            Console.WriteLine("1. Вход");
                            Console.WriteLine("2. Забыли пароль?");
                            Console.WriteLine("3. На главную");
                            result = int.TryParse(Console.ReadLine(), out authMenu);
                            if (result)
                                if (authMenu == 3)
                                {
                                    menu = 0;
                                    break;
                                }

                            Console.WriteLine("Введите номер телефона или email: ");
                            string input = Console.ReadLine();
                            if (input.Contains("@"))
                            {
                                currentuser = users.Find(user => (user.GetEmail() == input));
                            }
                            else
                            {
                                currentuser = users.Find(user => (user.GetPhone() == input));
                            }
                            if (authMenu == 1)
                            {
                                Console.WriteLine("Введите пароль");
                                string tmpPassword = Console.ReadLine();
                                if (currentuser != null)
                                {
                                    if (currentuser.GetPassword() == tmpPassword)
                                    {
                                        menu = 4;
                                        Console.WriteLine("Добро пожаловать {0}", currentuser.GetName());
                                        Console.ReadKey();
                                        break;
                                    }
                                }
                                Console.WriteLine("Неверный email/телефон или пароль");
                                Console.ReadKey();
                                break;
                            }
                            else
                            {
                                if (currentuser != null)
                                {
                                    int newPass = rand.Next(10000, 99999);
                                    string text = "Your new password: " + newPass.ToString();
                                    if (input.Contains("@"))
                                    {
                                        
                                        emailSender.SendEmailAsync(text, currentuser.GetEmail(), "Your new password");
                                        Console.WriteLine("You will recieve a new password by Email ");
                                    }
                                    else
                                    {
                                        sender.SendSms(currentuser.GetPhone(),text);
                                        Console.WriteLine("You will recieve a new password by SMS ");
                                    }
                                    currentuser.SetPassword(newPass.ToString());
                                    break;
                                }
                                Console.WriteLine("Неверный email/телефон или пароль");
                                Console.ReadKey();
                                break;
                            }

                            break;
                        }
                    case 3:
                        {
                            return;
                        }
                    case 4:
                        {
                            Console.WriteLine(" --- Личный кабинет ---");
                            Console.WriteLine("    Имя: {0}",currentuser.GetName());
                            Console.WriteLine("  Email: {0}", currentuser.GetEmail());
                            Console.WriteLine("Телефон: {0}", currentuser.GetPhone());
                            Console.ReadKey();
                            break;
                        }
                    default:
                        break;
                }
            }

            // Your Account SID from twilio.com/console

        }
    }
}
