﻿using System;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib sünniaastat;
            //arvutab kasutaja vanuse
            //kuvab kasutaja vanuse konsoolis


            Console.WriteLine("Palun sisesta oma sünniaasta");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2021 - yearOfBirth;

            Console.WriteLine("Oled " + userAge + " aastat vana.");

            //Console.WriteLine($"Oled {userAge} aastat vana .")

        }
    }
}
