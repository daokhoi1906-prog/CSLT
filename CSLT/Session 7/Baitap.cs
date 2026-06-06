using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session_7
{
    internal class Baitap
    {
        static void Main(string[] args)
        {
            // Gọi câu muốn test
            Cau1();
            //Cau2();
            //Cau3();
            //...
        }

        // 1. Create a blank file
        static void Cau1()
        {
            File.Create("blank.txt").Close();
            Console.WriteLine("blank.txt created");
        }

        // 2. Remove a file
        static void Cau2()
        {
            if (File.Exists("blank.txt"))
            {
                File.Delete("blank.txt");
                Console.WriteLine("blank.txt deleted");
            }
        }

        // 3. Create a file and add some text
        static void Cau3()
        {
            File.WriteAllText("sample.txt", "Hello World");
            Console.WriteLine("sample.txt created");
        }

        // 4. Create a text file and read it
        static void Cau4()
        {
            File.WriteAllText("readme.txt", "Line 1\nLine 2\nLine 3");

            string content = File.ReadAllText("readme.txt");
            Console.WriteLine(content);
        }

        // 5. Write an array of strings to file
        static void Cau5()
        {
            string[] fruits =
            {
                "Apple",
                "Banana",
                "Orange",
                "Mango"
            };

            File.WriteAllLines("fruits.txt", fruits);
            Console.WriteLine("Array written");
        }

        // 6. Append text to existing file
        static void Cau6()
        {
            File.AppendAllText("sample.txt", "\nAppended Text");
            Console.WriteLine("Text appended");
        }

        // 7. Copy file and display content
        static void Cau7()
        {
            File.WriteAllText("source.txt", "This is source file");

            File.Copy("source.txt", "copy.txt", true);

            Console.WriteLine(File.ReadAllText("copy.txt"));
        }

        // 8. Move file with another name
        static void Cau8()
        {
            File.WriteAllText("old.txt", "Move me");

            if (File.Exists("new.txt"))
                File.Delete("new.txt");

            File.Move("old.txt", "new.txt");

            Console.WriteLine("Moved");
        }

        // 9. Read first line
        static void Cau9()
        {
            string firstLine = File.ReadLines("sample.txt").First();

            Console.WriteLine(firstLine);
        }

        // 10. Create and read last line
        static void Cau10()
        {
            File.WriteAllLines("lastline.txt",
            new string[]
            {
                "Line 1",
                "Line 2",
                "Line 3"
            });

            string lastLine = File.ReadLines("lastline.txt").Last();

            Console.WriteLine(lastLine);
        }

        // 11. Read last n lines
        static void Cau11()
        {
            int n = 2;

            var lines = File.ReadLines("lastline.txt").TakeLast(n);

            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }

        // 12. Read a specific line
        static void Cau12()
        {
            int lineNumber = 2;

            string line =
                File.ReadLines("lastline.txt")
                .ElementAt(lineNumber - 1);

            Console.WriteLine(line);
        }

        // 13. Count number of lines
        static void Cau13()
        {
            int count = File.ReadLines("lastline.txt").Count();

            Console.WriteLine("Total lines = " + count);
        }

        // 14. Print folder structure (include files)
        static void Cau14()
        {
            PrintFolder(".", 0);
        }

        static void PrintFolder(string path, int level)
        {
            string indent = new string(' ', level * 2);

            foreach (string dir in Directory.GetDirectories(path))
            {
                Console.WriteLine(indent + "[Folder] "
                    + Path.GetFileName(dir));

                PrintFolder(dir, level + 1);
            }

            foreach (string file in Directory.GetFiles(path))
            {
                Console.WriteLine(indent + "[File] "
                    + Path.GetFileName(file));
            }
        }

        // 15. Statistics characters and digits
        static void Cau15()
        {
            File.WriteAllText("stats.txt",
                "Hello123 World456");

            string text = File.ReadAllText("stats.txt");

            Dictionary<char, int> result =
                new Dictionary<char, int>();

            foreach (char c in text)
            {
                if (char.IsLetterOrDigit(c))
                {
                    if (result.ContainsKey(c))
                        result[c]++;
                    else
                        result[c] = 1;
                }
            }

            foreach (var item in result)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
    }
}
