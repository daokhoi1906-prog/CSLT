using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session_3
{
    internal class Baitap_3
    {
        static void Main(string[] args)
        {
            //1. Write a C# Sharp program that takes two numbers as input and performs an operation (+,-,*,x,/) on them and displays the result of that operation.
            Console.Write("Nhap so thu nhat: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Phep toan (+ - * /): ");
            char op = Convert.ToChar(Console.ReadLine());
            double result = 0;
            switch (op)
            {
                case '+': result = a + b; break;
                case '-': result = a - b; break;
                case '*': result = a * b; break;
                case '/':
                    if (b != 0) result = a / b;
                    else
                    {
                        Console.WriteLine("Khong chia cho 0!");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Phep toan khong hop le!");
                    return;
            }

            Console.WriteLine("Ket qua: " + result);

            //2. Write a C# Sharp program to display certain values of the function x = y2 + 2y + 1 (using integer numbers for y, ranging from -5 to +5).
            for (int y = -5; y <= 5; y++)
            {
                int x = y * y + 2 * y + 1;
                Console.WriteLine($"y = {y}, x = {x}");
            }

            //3. Write a C# Sharp program that takes distance and time (hours, minutes, seconds) as input and displays speed in kilometers per hour (km/h) and miles per hour (miles/h).
            Console.Write("Nhap quang duong (km): ");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Gio: ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.Write("Phut: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Giay: ");
            int s = Convert.ToInt32(Console.ReadLine());
            double totalHours = h + m / 60.0 + s / 3600.0;
            double speedKmh = distance / totalHours;
            double speedMph = speedKmh * 0.621371;
            Console.WriteLine("Toc do (km/h): " + speedKmh);
            Console.WriteLine("Toc do (miles/h): " + speedMph);

            //4. Write a C# Sharp program that takes the radius of a sphere as input and calculates and displays the surface and volume of the sphere.  V = 4/3*π*r3 
            Console.Write("Nhap ban kinh: ");
            double r = Convert.ToDouble(Console.ReadLine());
            double surface = 4 * Math.PI * r * r;
            double volume = (4.0 / 3) * Math.PI * r * r * r;
            Console.WriteLine("Dien tich: " + surface);
            Console.WriteLine("The tich: " + volume);

            //5. Write a C# Sharp program that takes a character as input and checks if it is a vowel, a digit, or any other symbol.
            Console.Write("Nhap 1 ky tu: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if ("aeiouAEIOU".IndexOf(c) >= 0)
            {
                Console.WriteLine("La nguyen am");
            }
            else if (char.IsDigit(c))
            {
                Console.WriteLine("La chu so");
            }
            else
            {
                Console.WriteLine("La ky tu khac");
            }
        }
    }
}
