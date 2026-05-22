using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session_5
{
    internal class Baitap6
    {
        static void Main(string[] args)
        {
            //Bai1: Tinh gia tri trung binh cua mang
            int[] arr1 = { 1, 2, 3, 4, 5 };
            double average = arr1.Average();
            Console.WriteLine("Average: " + average);

            //Bai2: Kiem tra mang co chua gia tri hay khong
            int[] arr2 = { 1, 2, 3, 4, 5 };
            Console.Write("Nhap so bat ki: ");
            int number = int.Parse(Console.ReadLine());
            bool result = arr2.Contains(number);
            Console.WriteLine("Contains " + number + "? " + result);

            //Bai3: Tim vi tri cua phan tu trong mang
            int[] arr3 = { 10, 20, 30, 40, 50 };
            Console.Write("Nhap mot so can tim: ");
            int value = int.Parse(Console.ReadLine());
            int index = -1;
            for (int i = 0; i < arr3.Length; i++)
            {
                if (arr3[i] == value)
                {
                    index = i;
                    break;
                }
            }
            if (index != -1)
            {
                Console.WriteLine("Phan tu " + value + " nam o vi tri: " + index);
            }
            else
            {
                Console.WriteLine("Khong tim thay phan tu " + value);
            }

            //Bai4: Xoa mot phan tu khoi mang
            int[] arr4 = { 1, 2, 3, 4, 5 };
            Console.Write("Nhap so can xoa: ");
            int xoa = int.Parse(Console.ReadLine());
            List<int> list = new List<int>(arr4);
            list.Remove(xoa);
            Console.WriteLine("Mang sau khi xoa: " + string.Join(", ", list));

            //Bai5: Tim gia tri lon nhat va nho nhat trong mang
            int[] arr5 = { 5, 8, 2, 10, 3 };
            int max = arr5.Max();
            int min = arr5.Min();
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);

            //Bai6: Dao nguoc mang so nguyen
            int[] arr6 = { 1, 2, 3, 4, 5 };
            Array.Reverse(arr6);
            Console.WriteLine("Mang dao nguoc: " + string.Join(", ", arr6));

            //Bai7: Tim gia tri trung lap trong mang
            int[] arr7 = { 1, 2, 3, 2, 4, 5, 1 };
            var duplicates = arr7.GroupBy(x => x).Where(g => g.Count() > 1).Select(g => g.Key);
            Console.WriteLine("Cac gia tri trung lap: " + string.Join(", ", duplicates));

            //Bai8: Xoa phan tu trung lap trong mang
            int[] arr8 = { 1, 2, 2, 3, 4, 4, 5 };
            var unique = arr8.Distinct();
            Console.WriteLine("Mang sau khi xoa trung lap: " + string.Join(", ", unique));

            //Bai9: Sap xep mang bang Bubble Sort
            int[] arr9 = new int[10];
            Console.WriteLine("Nhap 10 so nguyen:");
            for (int i = 0; i < 10; i++)
            {
                arr9[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr9.Length - 1; i++)
            {
                for (int j = 0; j < arr9.Length - i - 1; j++)
                {
                    if (arr9[j] > arr9[j + 1])
                    {
                        int temp = arr9[j];
                        arr9[j] = arr9[j + 1];
                        arr9[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Mang sau khi sap xep:");
            foreach (int item in arr9)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //Bai10: Tim tu trong cau bang Linear Search
            Console.Write("Nhap mot cau: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            Console.Write("Nhap tu can tim: ");
            string target = Console.ReadLine();
            bool found = false;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Equals(target, StringComparison.OrdinalIgnoreCase))
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                Console.WriteLine("Tu \"" + target + "\" co trong cau.");
            }
            else
            {
                Console.WriteLine("Khong tim thay tu \"" + target + "\".");
            }
        }
    }
}
