
namespace PZ_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пароль: ");
            string password = Console.ReadLine();

            if (password.Length < 8)
            {
                Console.WriteLine("Длина пароля должна быть 8 символов или более");
            }
            else
            {
                bool correctLength = true;
                bool correctUpper = false;
                bool correctLower = false;
                bool correctNumber = false;
                bool correctDigit = false;

                for (int i = 0; i < password.Length; i++)
                {
                    if (Char.IsNumber(password[i])) correctNumber = true;
                    if (Char.IsUpper(password[i])) correctUpper = true;
                    if (Char.IsLower(password[i])) correctLower = true;
                    if (password[i] == '!' ||
                        password[i] == '-' ||
                        password[i] == '_' ||
                         password[i] == '.') correctDigit = true;
                }


                if (correctUpper && correctLower && correctNumber && correctDigit)
                {
                    Console.WriteLine("Пароль соответствует требованиям");
                }
                else
                {
                    Console.WriteLine("Пароль не соответствует требованиям");
                }
            }
        }
    }
}
    
              





