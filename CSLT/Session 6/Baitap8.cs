using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ConsoleApp1.Session_08
{
    internal class Baitap8
    {
        //bai1
        static void inchuoi(String s)
        {
            Console.WriteLine($"chuỗi bạn vừa nhập là {s}");
        }

        //bai2
        static int tinhdodai(string s)
        {
            int dem = 0;
            for (int i = 0; i < s.Length; i++)
            {
                dem++;
            }
            return dem;
        }

        //bai3
        static void TachKyTu(string s)
        {
            Console.Write("-> Các ký tự riêng lẻ trong chuỗi: ");
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i] + " ");
            }
            Console.WriteLine();
        }

        //bai4
        static void daonguoc(string s)
        {

            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
            Console.WriteLine();
        }

        //bai5
        static int demtu(string s)
        {
            int a = 0;
            bool trongtu = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ' || s[i] == '\t' || s[i] == '\n')
                {
                    trongtu = false;
                }
                else if (!trongtu)
                {
                    trongtu = true;
                    a++;
                }
            }
            return a;
        }

        //bai6
        static bool sosanhchuoi(string s, string s1)
        {
            int len1 = tinhdodai(s);
            int len2 = tinhdodai(s1);
            if (len1 != len2) return false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != s1[i]) { return false; }
            }
            return true;
        }

        //bai7
        static void demloaikytu(string s)
        {
            int chucai = 0, chuso = 0, dacbiet = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= 'A' && s[i] <= 'Z'))
                {
                    chucai++;
                }

                else if (s[i] >= '0' && s[i] <= '9')
                {
                    chuso++;
                }
                else dacbiet++;
            }
            Console.WriteLine($"Chữ cái {chucai} , Chữ số {chuso} , đặc biệt {dacbiet} ");
        }

        // 8. Đã sửa từ foreach thành vòng lặp FOR
        static void DemNguyenAmPhuAm(string s)
        {
            int nguyenAm = 0, phuAm = 0;

            // Chuyển đổi thành vòng for
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i]; // Lấy ký tự tại vị trí i giống foreach cũ
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                {

                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                        nguyenAm++;
                    else
                        phuAm++;
                }
            }
            Console.WriteLine($"8. Thống kê: Nguyên âm = {nguyenAm}, Phụ âm = {phuAm}");
        }

        // 10. Tìm vị trí chuỗi con
        static void TimViTriChuoiCon(string s, string s1)

        {
            int b = s.IndexOf(s1);
            if (b == -1)
            {
                Console.WriteLine("chuoi con khong co");
            }
            else
            {
                Console.WriteLine($"chuoi con xuat hien o vi tri {b}");
            }
        }



        //9. Kiểm tra chuỗi con có tồn tại không
        static bool chuoicon(string s, string s1)
        {
            int c = s.Length;
            int d = s1.Length;
            if (c < d) return false;

            else if ((c == 0) && (d == 0)) { return true; }
            else if (c >= 0 && (d == 0))
            {

                if (s.Contains(s1)) return true;

            }
            return true;
        }

        // 11. Kiểm tra loại chữ cái
        static void KiemTraKieuChu(char c)
        {
            if (c >= 'A' && c <= 'Z')
                Console.WriteLine($"Ký tự '{c}' là CHỮ CÁI viết HOA.");
            else if (c >= 'a' && c <= 'z')
                Console.WriteLine($"Ký tự '{c}' là CHỮ CÁI viết thường.");
            else
                Console.WriteLine($"Ký tự '{c}' không phải là chữ cái.");
        }

        // 12. Tìm số lần xuất hiện của chuỗi con
        static int DemSoLanXuatHien(string s, string s1)
        {
            int f = 0;
            int b = s.IndexOf(s1);
            while (b != -1)
            {
                f++;
                b = s.IndexOf(s1, b + s1.Length);
            }
            return f;
        }
        // 13 chèn chuỗi
        static void ChenTruocCumTu(ref string source, string target, string toInsert)
        {
            // Kiểm tra điều kiện đầu vào an toàn
            if (string.IsNullOrEmpty(source) || string.IsNullOrEmpty(target) || toInsert == null)
            {
                return; // Thoát hàm sớm nếu dữ liệu không hợp lệ
            }

            // Tìm vị trí xuất hiện đầu tiên của chuỗi target
            int index = source.IndexOf(target);

            // Nếu tìm thấy, tiến hành chèn và gán đè lại vào biến source
            if (index != -1)
            {
                source = source.Insert(index, toInsert);
            }
        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //bai1
            string chuoigoc = Console.ReadLine();
            inchuoi(chuoigoc);

            //bai2
            int dodai = tinhdodai(chuoigoc);
            Console.WriteLine($"Do dai cua chuoi la {dodai}");

            //bai3
            TachKyTu(chuoigoc);

            //bai4
            daonguoc(chuoigoc);

            //bai5
            int b = demtu(chuoigoc);
            Console.Write($"Số từ trong chuỗi là {b} ");
            Console.WriteLine();

            //bai6 
            string s1 = Console.ReadLine();
            bool bangnhau = sosanhchuoi(chuoigoc, s1);
            if (bangnhau)
            {
                Console.WriteLine($"hai chuoi bang nhau");
            }
            else { Console.WriteLine($"hai chuoi khong bang nhau"); }

            //bai7
            demloaikytu(chuoigoc);

            // 8. Đếm số nguyên âm và phụ âm
            DemNguyenAmPhuAm(chuoigoc);

            // Chuẩn bị cho các phần tìm kiếm chuỗi con
            Console.Write("\nNhập vào một chuỗi con để tìm kiếm: ");
            string chuoiCon = Console.ReadLine();

            //9. Kiểm tra chuỗi con có tồn tại không
            bool timThay = chuoicon(chuoigoc, chuoiCon);
            Console.WriteLine($"9. Chuỗi con có tồn tại không? {timThay}");

            // 10. Tìm vị trí xuất hiện đầu tiên của chuỗi con
            TimViTriChuoiCon(chuoigoc, chuoiCon);


            // 11 kiemtrakytu
            Console.Write("Nhập một ký tự từ bàn phím: ");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            char c = keyInfo.KeyChar;
            KiemTraKieuChu(c);


            // 12. Tìm số lần xuất hiện của chuỗi con
            int soLan = DemSoLanXuatHien(chuoigoc, chuoiCon);
            Console.WriteLine($"12. Số lần chuỗi con xuất hiện: {soLan}");

            // 13. Chèn chuỗi con trước từ/chuỗi tìm thấy đầu tiên
            static void Main()
            {
                string original = "Hello World, chào mừng bạn.";
                string target = "World";
                string toInsert = "Beautiful ";

                Console.WriteLine("Trước khi chèn: " + original);
                ChenTruocCumTu(ref original, target, toInsert);

                Console.WriteLine("Sau khi chèn:  " + original);
            }
        }
    }
}