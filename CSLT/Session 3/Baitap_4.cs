using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session_3
{
    internal class Baitap_4
    {
        static void Main(string[] args)
        {
            //SLIDE 21

            //1. Write a C# Sharp program to check whether a given number is even or odd.
            Console.Write("Nhap mot so: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} la so chan");
            }
            else
            {
                Console.WriteLine($"{number} la so le");
            }

            //2. Write a C# Sharp program to find the largest of three numbers.
            Console.Write("Nhap so thu nhat: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int second = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu ba: ");
            int third = int.Parse(Console.ReadLine());
            int max = first;
            if (second > max)
            {
                max = second;
            }

            if (third > max)
            {
                max = third;
            }
            Console.WriteLine($"So lon nhat la: {max}");

            //3. Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
            Console.Write("Nhap toa do x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap toa do y: ");
            int y = int.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine($"Diem ({x},{y}) nam o goc phan tu thu nhat");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"Diem ({x},{y}) nam o goc phan tu thu hai");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"Diem ({x},{y}) nam o goc phan tu thu ba");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine($"Diem ({x},{y}) nam o goc phan tu thu tu");
            }
            else
            {
                Console.WriteLine($"Diem ({x},{y}) nam tren truc toa do");
            }


            // SLIDE 22

            //1. Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhap canh a: ");
            double a;
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap canh b: ");
            double b;
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap canh c: ");
            double c;
            c = Convert.ToDouble(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("La tam giac");
                if (a == b && b == c)
                {
                    Console.WriteLine("Tam giac deu");
                }
                else if (a == b || b == c || a == c)
                {
                    Console.WriteLine("Tam giac can");
                }
                else
                {
                    Console.WriteLine("Tam giac thuong");
                }
            }
            else
            {
                Console.WriteLine("Khong phai la tam giac");
            }

            //2. Write a program to read 10 numbers and find their average and sum.
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            double sum = 0;
            double number0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Nhap so thu " + i + ": ");
                number0 = Convert.ToDouble(Console.ReadLine());
                sum = sum + number0;
            }
            Console.WriteLine("Tong cac so tren bang: " + sum);
            double average = 0;
            average = sum / 10;
            Console.WriteLine("Trung binh cong cac so tren bang:" + average);

            //3. Write a program to display the multiplication table of a given integer.
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            double number1 = 0;
            Console.Write("Nhap 1 so:");
            number1 = Convert.ToDouble(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number1} x {i} = {number1 * i}");
            }

            //4. Write a program to display a pattern like triangles with a number.
            //Tam giac 1
            Console.WriteLine("Tam giac 1:");
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            //Tam giac 2
            Console.WriteLine("Tam giac 2:");
            int num = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine();
            }

            //Tam giac 3
            Console.WriteLine("Tam giac 3:");
            int number2 = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int k = 1; k <= 4 - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number2 + " ");
                    number2++;
                }
                Console.WriteLine();
            }

            //6. Write a program to display the n terms of harmonic series and their sum.
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            double tong = 0;
            Console.Write("Day harmonic: ");
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"1/{i}");
                if (i < n)
                {
                    Console.Write(" + ");
                }
                tong = tong + 1.0 / i;
            }
            Console.WriteLine();
            Console.WriteLine($"Tong cua day = {tong}");

            //7. Write a program to find the perfect numbers within a given number range.
            Console.Write("Nhap gioi han: ");
            int limit = int.Parse(Console.ReadLine());
            Console.WriteLine("Cac so hoan hao la:");
            for (int i = 1; i <= limit; i++)
            {
                int sum1 = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum1 = sum1 + j;
                    }
                }
                if (sum1 == i)
                {
                    Console.WriteLine(i);
                }
            }

            //8. Write a program to determine whether a given number is prime or not.
            Console.Write("Nhap so can kiem tra: ");
            int so = int.Parse(Console.ReadLine());
            bool laSoNguyenTo = true;
            if (so < 2)
            {
                laSoNguyenTo = false;
            }
            else
            {
                for (int i = 2; i < so; i++)
                {
                    if (so % i == 0)
                    {
                        laSoNguyenTo = false;
                        break;
                    }
                }
            }
            if (laSoNguyenTo)
            {
                Console.WriteLine($"{so} la so nguyen to");
            }
            else
            {
                Console.WriteLine($"{so} khong phai la so nguyen to");
            }
        }
    }
}
