using System;
using System.IO;


namespace phase1_practiceProjectTwo1._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            openAndReadFile();
        }
        static void openAndReadFile()
        {
            string filePath = "D:\\dotNet\\phase1_practiceProjectTwo1.14\\studentData.txt";
            if (File.Exists(filePath))
            {
                using (StreamReader read = new StreamReader(filePath))
                {
                    string[] data = read.ReadToEnd().Split('\n');
                    foreach (string str in data)
                    {
                        Console.WriteLine(str);
                    }
                }
            }
            else
            {
                using (StreamWriter write = new StreamWriter(filePath))
                {
                    write.WriteLine("student_rollNo : 46");
                    write.WriteLine("Student_Name  : Banala Bhavana Ramya");
                    write.WriteLine("student_grade : A+");
                    write.Close();
                }

                using (StreamReader r = new StreamReader(filePath))
                {
                    String[] s2 = r.ReadToEnd().Split('\n');
                    foreach (String str in s2)
                    {
                        Console.WriteLine(str);
                    }
                    r.Close();
                }
            }
        }
    }
}
