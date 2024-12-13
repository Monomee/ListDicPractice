using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ListDicPractice
{
    public class Menu
    {
        public static void display()
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add and display new element.");
            Console.WriteLine("2. Find max and min value.");
            Console.WriteLine("3. Delete element.");
            Console.WriteLine("4. Sort (ascending and descending).");
            Console.WriteLine("5. Count the number of times each word appears in a paragraph.");
            Console.WriteLine("6. Contacts management.");
            Console.WriteLine("7. Student ranking.");
            Console.WriteLine("8. Poduct list statistics.");
            Console.WriteLine("9. Exit.");
            Console.Write("Your choice: ");
        }

        public static int userChoice()
        {
            bool isValid = false;
            int choice = -1;
            do
            {
                string input = Console.ReadLine();
                isValid = int.TryParse(input, out choice );
                if (!isValid)
                {
                    Console.Write("Please, try again: ");
                }
            } while (!isValid);
            return choice;
        }
        public static bool handleChoice(int choice)
        {
            bool status = true;
            switch (choice)
            {
                case 1: //Nhập 1 dãy số nguyên và in ra
                    Console.Write("Enter the number of numbers:");
                    int n = userChoice();
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("Enter number:");
                        int num = userChoice();
                        Storage.listNums.Add(num);
                    }
                    Console.WriteLine("List: " + string.Join(", ", Storage.listNums));
                    break;
                case 2: //Tìm max và min trong danh sách các số nguyên
                    Console.WriteLine(string.Join(", ", Storage.listNums));
                    Console.WriteLine("Max value in list: " + Storage.listNums.Max());
                    Console.WriteLine("Min value in list: " + Storage.listNums.Min());
                    break;
                case 3: //Loại bỏ số nhập vào nếu tồn tại trong danh sách 
                    Console.WriteLine("List: " + string.Join(", ", Storage.listNums));
                    Console.Write("Enter number to remove: ");
                    int remove_n = userChoice();
                    if (Storage.listNums.Contains(remove_n))
                    {
                        Storage.listNums.RemoveAll(x => x == remove_n);
                        Console.WriteLine("List: " + string.Join(", ", Storage.listNums));
                    }
                    else
                    {
                        Console.WriteLine(remove_n + " is not in list.");
                    }
                    break;
                case 4: //Sắp xếp danh sách theo thứ tự tăng dần và giảm dần 
                    Console.WriteLine("Before: " + string.Join(", ", Storage.listNums));
                    Console.WriteLine("After:");
                    Storage.listNums.Sort();
                    Console.WriteLine("Ascending: " + string.Join(", ", Storage.listNums));

                    Console.WriteLine("Descending: " + string.Join(", ", Storage.listNums.OrderByDescending(x => x)));
                    break;
                case 5: //Đếm số lần xuất hiện của từ trong đoạn văn 
                    Console.Write("Enter a paragraph: ");
                    string para = Console.ReadLine();
                    string[] words = Regex.Split(para, @"[^a-zA-Z0-9]+");
                    int count;
                    bool isDup;
                    for (int i = 0; i < words.Length; i++)
                    {
                        count = 1;
                        isDup = true;
                        for (int j = i + 1; j < words.Length; j++)
                        {
                            if (words[i] == words[j]) { count++; }
                        }
                        for (int k = 0; k < i; k++)
                        {
                            if (words[k] == words[i]) { isDup = false; break; }
                        }
                        if (isDup)
                        {
                            Console.WriteLine(words[i] + ": " + count);
                        }
                    }
                    break;
                case 6: //chương trình quản lí số điện thoại 
                    int userChoiceContacts;
                    do
                    {
                        UserFunction.menuUser();
                        userChoiceContacts = userChoice();
                    } while (UserFunction.handleChoiceInUser(userChoiceContacts));
                    break;
                case 7: //quản lí danh sách sinh viên 
                    StudentList.addStudentGrade();
                    var sortedStudents = Storage.students.OrderByDescending(s => s.Value.Grade);
                    foreach (var student in sortedStudents)
                    {
                        Console.WriteLine(student.Value.ToString());
                    }
                    break;
                case 8: //thống kê danh sách sản phầm 
                    Console.WriteLine("Test");
                    break;
                case 9:
                    status = false;
                    break;
                default:
                    Console.WriteLine("Please choose options from 1 to 9");
                    break;
            }
            return status;
        }
    }
}
