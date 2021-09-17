using System;

namespace InstagramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun sisesta oma vanus: ");
            int userAge = Convert.ToInt32(Console.ReadLine());
            if(userAge > 13)
            {
                Console.WriteLine("Oled piisavalt vana, et luua konto.");
            }
            else if(userAge < 13)
            {
                Console.WriteLine("Oled liiga noor, et konto luua");
            }
            else
            {
                Console.WriteLine("Oled piisavalt vana, et luua konto.");
            }
        }
    }
}
