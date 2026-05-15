using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session_2
{
    internal class Baitap_2
    {
        static void Main(string[] args)
        {
            //1. Write a C# Sharp program to print Hello and your name in a separate line.
            Console.WriteLine("Hello");
            Console.WriteLine("Minh Khoi");

            //2. Write a C# Sharp program to print the sum of two numbers.
            Console.Write("Nhap so a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            float b = float.Parse(Console.ReadLine());
            float c = a + b;
            Console.WriteLine($"Tong cua hai so {a} va {b} là {c}");

            //3. Write a C# Sharp program to print the result of dividing two numbers.
            Console.Write("Nhap so x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap so y: ");
            int y = int.Parse(Console.ReadLine());
            int q = x / y;
            int d = x % y;
            Console.WriteLine($"{x} chia {y} = {q} du {d}");

            //4. Write a C# Sharp program to print the results of the specified operations.
            Console.WriteLine("-1+4*6={0}", -1 + 4 * 6);
            Console.WriteLine("( 35 + 5 ) % 7 = {0}", (35 + 5) % 7);
            Console.WriteLine("14 + -4 * 6 / 11 = {0}", 14 + -4 * 6 / 11);
            Console.WriteLine("2 + 15 / 6 * 1 - 7 % 2 = {0}", 2 + 15 / 6 * 1 - 7 % 2);

            //5. Swap Two Numbers.
            int truoc = 2; int sau = 4;
            Console.WriteLine($"Truoc khi hoan doi truoc = {truoc}, sau = {sau}");
            int temp = truoc; truoc = sau; sau = temp;
            Console.WriteLine($"Sau khi hoan doi truoc = {truoc}, sau = {sau}");

            //6. Multiply Three Numbers
            Console.Write("Nhap so dau: ");
            float first = float.Parse(Console.ReadLine());
            Console.Write("Nhap so hai: ");
            float second = float.Parse(Console.ReadLine());
            Console.Write("Nhap so ba: ");
            float third = float.Parse(Console.ReadLine());
            float sum = first * second * third;
            Console.WriteLine($"Tich cua ba so {first}x{second}x{third}= {sum}");

            //7. Arithmetic Operations
            Console.Write("Nhap so thu nhat: ");
            int f = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine($"{f}+{s}={f + s}");
            Console.WriteLine($"{f}-{s}={f - s}");
            Console.WriteLine($"{f}*{s}={f * s}");
            Console.WriteLine($"{f}/{s}={f / s}");
            Console.WriteLine($"{f} mod {s}={f % s}");

            //8. Average of Four Numbers
            Console.Write("Nhap so dau: ");
            float fi = float.Parse(Console.ReadLine());
            Console.Write("Nhap so hai: ");
            float se = float.Parse(Console.ReadLine());
            Console.Write("Nhap so ba: ");
            float th = float.Parse(Console.ReadLine());
            Console.Write("Nhap so bon: ");
            float fo = float.Parse(Console.ReadLine());
            Console.WriteLine($"Trung binh cong bon so {fi};{se};{th};{fo} la {(fi + se + th + fo) / 4}");

            //9. Specified Formula with Three Numbers
            Console.Write("Nhap so dau: ");
            int dau = int.Parse(Console.ReadLine());
            Console.Write("Nhap so hai: ");
            int hai = int.Parse(Console.ReadLine());
            Console.Write("Nhap so ba: ");
            int cuoi = int.Parse(Console.ReadLine());
            Console.WriteLine($"({dau}+{hai}).{cuoi}={(dau + hai) * cuoi} va {dau}.{hai}+{hai}.{cuoi}={dau * hai + hai * cuoi}");

            //10. Print Age Message
            Console.Write("Nhap do tuoi: ");
            int tuoi = int.Parse(Console.ReadLine());
            Console.WriteLine($"You look older than {tuoi}");

            //11. Repeat Number in Rows
            Console.Write("Nhap mot so: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} {0} {0} {0}\n" + "{0}{0}{0}{0}\n" + "{0} {0} {0} {0}\n" + "{0}{0}{0}{0}", num);

            //12. Celsius to Kelvin and Fahrenheit
            Console.Write("Nhap do Celsius: ");
            int ce = int.Parse(Console.ReadLine());
            int kelvin = ce + 273;
            int fahrenheit = ce * 18 / 10 + 32;
            Console.WriteLine($"{ce} do C = {kelvin} K\n" +
                $"{ce} do C = {fahrenheit} F");

            //13. Remove Character by Index
            Console.Write("Nhap chuoi: ");
            string str = Console.ReadLine();
            Console.Write("Nhap ki tu xoa: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Chuoi sau khi xoa: {str.Remove(n, 1)}");

            //14. Swap First and Last Characters
            Console.Write("Nhap chuoi: ");
            string chuoi = Console.ReadLine();
            if (chuoi.Length <= 1)
            {
                Console.WriteLine($"Chuoi moi la: {chuoi}");
            }
            else
            {
                string fchar = chuoi.Substring(0, 1);
                string lchar = chuoi.Substring(chuoi.Length - 1);
                string mchar = chuoi.Substring(1, chuoi.Length - 2);
                Console.WriteLine($"Chuoi moi la: {lchar + mchar + fchar}");
            }

            //15. Add First Character to Front and Back
            Console.Write("Nhap chuoi: ");
            String chu = Console.ReadLine();
            Console.Write("Nhap tu them: ");
            String them = Console.ReadLine();
            Console.WriteLine($"Chuoi moi la: {them + chu + them}");

            //16. Swap First and Last Characters
            Console.Write("Nhap chuoi: ");
            string s16 = Console.ReadLine();
            if (string.IsNullOrEmpty(s16) || s16.Length == 1)
            {
                Console.WriteLine($"Chuoi moi: {s16}");
            }
            else
            {
                char first16 = s16[0];
                char last = s16[s16.Length - 1];
                string middle = s16.Substring(1, s16.Length - 2);
                string result16 = last + middle + first;
                Console.WriteLine($"Chuoi moi: {result16}");
            }

            //17. Add First Character to Front and Back
            Console.Write("Nhap chuoi: ");
            string s17 = Console.ReadLine();
            if (string.IsNullOrEmpty(s17))
            {
                Console.WriteLine("Chuoi rong!");
            }
            else
            {
                char firstChar = s17[0];
                string result17 = firstChar + s17 + firstChar;
                Console.WriteLine($"Chuoi moi: {result17}");
            }

            //18. Check Positive and Negative Pair
            Console.Write("Nhap so thu nhat: ");
            int a18 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int b18 = int.Parse(Console.ReadLine());
            bool isOpposite = (a18 < 0 && b18 > 0) || (a18 > 0 && b18 < 0);
            Console.WriteLine($"Mot am mot duong? {isOpposite}");

            //19. Sum or Triple Sum
            Console.Write("Nhap so thu nhat: ");
            int a19 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int b19 = int.Parse(Console.ReadLine());
            int sum19 = a19 + b19;
            if (a19 == b19)
            {
                Console.WriteLine($"Hai so bang nhau -> ket qua: {sum19 * 3}");
            }
            else
            {
                Console.WriteLine($"Tong hai so: {sum19}");
            }

            //20. Absolute Difference or Double It
            Console.Write("Nhap so thu nhat: ");
            int a20 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int b20 = int.Parse(Console.ReadLine());
            int diff = Math.Abs(a20 - b20);
            if (a20 > b20)
            {
                Console.WriteLine($"Ket qua (gap doi): {diff * 2}");
            }
            else
            {
                Console.WriteLine($"Ket qua: {diff}");
            }
        }
    }
}
