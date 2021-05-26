using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            do
            {
                Console.WriteLine("\t\t\t\t\t\t Menu\n");
                Console.WriteLine("1. Manage Students\n");
                Console.WriteLine("2. Manage Lecturers\n");
                Console.WriteLine("3. Exit\n");
                Console.Write("select from 1 to 3 :");
                i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        StudentManageMenu();
                        break;
                    case 2:
                        LecturerManageMenu();
                        break;
                    case 3:
                        Console.WriteLine("\t\t Exit\n");
                        break;
                    default:
                        Console.WriteLine("you entered an invalid number");
                        break;
                }
            } while (i != 3);
        }

        public static void StudentManageMenu()
        {
            StudentManageScreen SM = new StudentManageScreen();
            int i;
            do
            {
                Console.WriteLine("\n\t\t\t\t\t\t Manage Student\n");
                Console.WriteLine("1. Add Student\n");
                Console.WriteLine("2. View all Students\n");
                Console.WriteLine("3. Update Student \n");
                Console.WriteLine("4. Delete Student\n");
                Console.WriteLine("5. Search Student\n");
                Console.WriteLine("6. Back to Main Menu\n");
                Console.Write("select from 1 to 6:");
                i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        SM.AddStudent();
                        break;
                    case 2:
                        SM.ViewallStudents();
                        break;
                    case 3:
                        SM.UpdateStudent();
                        break;
                    case 4:
                        SM.DeleteStudent();
                        break;
                    case 5:
                        SM.SearchStudent();
                        break;

                }
            } while (i != 6);
        }

        public static void LecturerManageMenu()
        {
            LecturerManageScreen LM = new LecturerManageScreen();
            int i;
            do
            {
                Console.WriteLine("\n\t\t\t\t\t\t Manage Lecturer\n");
                Console.WriteLine("1. Add Lecturer\n");
                Console.WriteLine("2. View all Lecturers\n");
                Console.WriteLine("3. Update Lecturer\n");
                Console.WriteLine("4. Delete Lecturer\n");
                Console.WriteLine("5. Search Lecturer\n");
                Console.WriteLine("6. Back to Main Menu\n");
                Console.Write("select from 1 to 6 :");
                i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        LM.AddLecturer();
                        break;
                    case 2:
                        LM.ViewallLecturers();
                        break;
                    case 3:
                        LM.UpdateLecturer();
                        break;
                    case 4:
                        LM.DeleteLecturer();
                        break;
                    case 5:
                        LM.SearchLecturer();
                        break;

                }
            } while (i != 6);
        }
    }
}









