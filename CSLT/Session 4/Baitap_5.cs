using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session_4
{
    internal class Baitap_5
    {
        static void Main(string[] args)
        {
            //Bai1: Tinh tong hai so nguyen
            Console.WriteLine("Nhap 2 so a,b: ");
            int so1 = int.Parse(Console.ReadLine());
            int so2 = int.Parse(Console.ReadLine());
            int ketqua = so1 + so2;
            Console.WriteLine("Tong cua {0} va {1} la: {2}", so1, so2, ketqua);

            //Bai2: Kiem tra so chan le
            Console.WriteLine("Nhap mot so: ");
            int so = int.Parse(Console.ReadLine());
            bool ketqua2 = so % 2 == 0;
            Console.WriteLine($"So {so} co chan khong? {ketqua2}");

            //Bai3: Tim so lon nhat trong ba so
            Console.WriteLine("Nhap 3 so a,b,c: ");
            int so3 = int.Parse(Console.ReadLine());
            int so4 = int.Parse(Console.ReadLine());
            int so5 = int.Parse(Console.ReadLine());
            int max = Math.Max(Math.Max(so3, so4), so5);
            Console.WriteLine($"So lon nhat trong ba so la: {max}");

            //Bai4: Tinh giai thua cua mot so
            Console.Write("Nhap mot so muon tinh giai thua: ");
            int gt = int.Parse(Console.ReadLine());
            long giaithua = 1;
            for (int i = 1; i <= gt; i++)
            {
                giaithua *= i;
            }
            Console.WriteLine($"Giai thua cua {gt} la: {giaithua}");

            //Bai5: Dao nguoc chuoi ky tu
            Console.WriteLine("Nhap chuoi can dao nguoc:");
            string nhap = Console.ReadLine();
            char[] chuoi = nhap.ToCharArray();
            Array.Reverse(chuoi);
            string daonguoc = new string(chuoi);
            Console.WriteLine($"Ket qua la: {daonguoc}");

            //Bai6: Kiem tra so nguyen to
            Console.Write("Nhap so muon kiem tra: ");
            int songuyento = int.Parse(Console.ReadLine());
            bool check = true;
            if (songuyento < 2)
            {
                check = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(songuyento); i++)
                {
                    if (songuyento % i == 0)
                    {
                        check = false;
                        break;
                    }
                }
            }
            Console.WriteLine($"So {songuyento} co la so nguyen to hay khong: {check}");

            //Bai7: In day Fibonacci
            Console.Write("Nhap so muon tinh: ");
            int fibo = int.Parse(Console.ReadLine());
            int f1 = 0;
            int f2 = 1;
            Console.WriteLine("So Fibonacci bang:");
            if (fibo >= 1)
            {
                Console.Write(f1 + " ");
            }
            if (fibo >= 2)
            {
                Console.Write(f2 + " ");
            }
            for (int i = 3; i <= fibo; i++)
            {
                int f3 = f1 + f2;
                Console.Write(f3 + " ");
                f1 = f2;
                f2 = f3;
            }

            //Bai8: Dem so luong nguyen am trong chuoi
            Console.Write("Nhap chuoi can dem: ");
            string chuoiam = Console.ReadLine();
            int dem = 0;
            string nguyenam = "aeiouAEIOU";
            foreach (char luu in chuoiam)
            {
                if (nguyenam.Contains(luu))
                {
                    dem++;
                }
            }
            Console.WriteLine($"So luong nguyen am trong chuoi la: {dem}");

            //Bai9: Tinh luy thua
            Console.Write("Nhap co so: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Nhap so mu: ");
            int y = int.Parse(Console.ReadLine());
            double result = 1;
            if (y > 0)
            {
                for (int i = 0; i < y; i++)
                {
                    result *= x;
                }
            }
            else if (y < 0)
            {
                for (int i = 0; i < -y; i++)
                {
                    result *= x;
                }
                result = 1 / result;
            }
            Console.WriteLine($"Ket qua la: {result}");

            //Bai10: Tinh diem trung binh cua mang
            int[] arr = { 4, 5, 6, 7 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            double tb = (double)sum / arr.Length;
            Console.WriteLine("Ket qua la: " + tb);

            //Bai11: Kiem tra chuoi doi xung
            Console.Write("Nhap chuoi muon kiem tra: ");
            string s = Console.ReadLine();
            string nguoc = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                nguoc += s[i];
            }
            bool doixung = s == nguoc;
            Console.WriteLine($"Chuoi {s} co phai doi xung hay khong: {doixung}");

            //Bai12: Chuyen doi nhiet do
            Console.Write("Nhap nhiet do can chuyen doi (C): ");
            double c = double.Parse(Console.ReadLine());
            double f = (c * 9 / 5) + 32;
            Console.WriteLine($"Ket qua la: {f}");

            //Bai13: Tim gia tri nho nhat trong mang
            int[] mangmin = { 10, 5, 8, 2, 9 };
            int min = mangmin[0];
            for (int i = 1; i < mangmin.Length; i++)
            {
                if (mangmin[i] < min)
                {
                    min = mangmin[i];
                }
            }
            Console.WriteLine("Gia tri nho nhat trong mang la: " + min);

            //Bai14: Tinh tong cac chu so cua mot so nguyen
            Console.Write("Nhap so muon tinh tong: ");
            int so14 = int.Parse(Console.ReadLine());
            int tong14 = 0;
            while (so14 > 0)
            {
                tong14 += so14 % 10;
                so14 /= 10;
            }
            Console.WriteLine("Ket qua bang: " + tong14);

            //Bai15: Sap xep mang tang dan
            int[] sapxep = { 3, 1, 4, 2 };
            for (int i = 0; i < sapxep.Length - 1; i++)
            {
                for (int j = 0; j < sapxep.Length - i - 1; j++)
                {
                    if (sapxep[j] > sapxep[j + 1])
                    {
                        int temp = sapxep[j];
                        sapxep[j] = sapxep[j + 1];
                        sapxep[j + 1] = temp;
                    }
                }
            }
            Console.Write("Mang sau sap xep: ");
            for (int i = 0; i < sapxep.Length; i++)
            {
                Console.Write(sapxep[i] + " ");
            }

            //Bai16: Xoa ky tu trung lap
            Console.Write("Nhap chuoi muon kiem tra: ");
            string chuoi16 = Console.ReadLine();
            string ketqua16 = "";
            foreach (char c16 in chuoi16)
            {
                if (!ketqua16.Contains(c16))
                {
                    ketqua16 += c16;
                }
            }
            Console.WriteLine($"Ket qua la: {ketqua16}");

            //Bai17: Tim UCLN
            Console.Write("Nhap so a: ");
            int a17 = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            int b17 = int.Parse(Console.ReadLine());
            while (b17 != 0)
            {
                int r = a17 % b17;
                a17 = b17;
                b17 = r;
            }
            Console.WriteLine($"UCLN la: {a17}");

            //Bai18: Chuyen doi he thap phan sang nhi phan
            Console.Write("Nhap so can tinh: ");
            int so18 = int.Parse(Console.ReadLine());
            string nhiphan = Convert.ToString(so18, 2);
            Console.WriteLine($"Ket qua la: {nhiphan}");

            //Bai19: Kiem tra nam nhuan
            Console.Write("Nhap nam can kiem tra: ");
            int nam = int.Parse(Console.ReadLine());
            bool namnhuan = false;
            if (nam % 400 == 0)
            {
                namnhuan = true;
            }
            else if (nam % 100 == 0)
            {
                namnhuan = false;
            }
            else if (nam % 4 == 0)
            {
                namnhuan = true;
            }
            Console.WriteLine($"Nam {nam} la nam nhuan: {namnhuan}");

            //Bai20: Dem so tu trong cau
            Console.Write("Nhap cau can kiem tra: ");
            string cau = Console.ReadLine();
            string[] words = cau.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int demtu = words.Length;
            Console.WriteLine($"Ket qua la: {demtu}");
        }
    }
}