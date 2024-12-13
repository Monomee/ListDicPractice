using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ListDicPractice
{
    public class StudentList
    {
        public static void addStudentGrade()
        {
            int id = 0;
            string name = "";
            double grade = 0;

            // Đọc nội dung từ file
            string filePath = @"D:\CodeGym\Homework\ListDicPractice\StudentGrade.txt"; // Đường dẫn file
            string[] lines = File.ReadAllLines(filePath);// Đọc tất cả các dòng từ file


            // Xử lý từng dòng
            foreach (string line in lines)
            {
                string[] infoPairs = line.Split(';'); // Tách từng cặp thông tin

                foreach (string pair in infoPairs)
                {
                    string[] keyValue = pair.Split(':'); // Tách key và value
                    string key = keyValue[0].Trim();    // Xóa khoảng trắng thừa
                    string value = keyValue[1].Trim();

                    // Gán giá trị vào các biến tương ứng
                    if (key == "id")
                    {
                        id = int.Parse(value);
                    }
                    else if (key == "name")
                    {
                        name = value;
                    }
                    else if (key == "grade")
                    {
                        grade = double.Parse(value);
                    }
                }
                Storage.students.Add(id, new Student(id, name, grade));
            }

        }
    }
}
