using System;

namespace DrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun sisesta oma sünniaasta");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2021 - yearOfBirth;
            if (userAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhiluba taodelda.");
            }
            else if (userAge < 18)
            {
                Console.WriteLine("Oled liiga noor, et juhiluba taodelda");
            }
            else
            {
                Console.WriteLine("Palju õnne! Nüüd saad endale juhiloa taotleda.");
            }
        }
    }
}
