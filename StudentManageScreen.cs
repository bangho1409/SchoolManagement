using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    class StudentManageScreen
    {
        public const int MAX_STU = 100;
        static Student[] stuList = new Student[MAX_STU];
        static int LStu = 0;

        public void AddStudent()
        {
            do
            {
                Console.Write("\t\t\t\t\t\t Add Student Data\n");
                Console.Write("Student ID: ");
                string stdId = Console.ReadLine();
                Console.Write("Student Name: ");
                string stdName = Console.ReadLine();
                Console.Write("Student Email: ");
                string stdEmail = Console.ReadLine();
                Console.Write("Student Address: ");
                string stdAddress = Console.ReadLine();
                Console.Write("Student DoB: ");
                string stdDoB = Console.ReadLine();
                Console.Write("Student Class: ");
                string stdBatch = Console.ReadLine();
                Console.Write("Do you want to save the input data (Y/N): ");
                char a = Console.ReadKey().KeyChar;
                if ((a == 'Y') || (a == 'y'))
                {
                    if (checkStuId(stdId) == false)
                    {
                        insertStuData(LStu, stdId, stdName, stdAddress, stdEmail, stdDoB, stdBatch);
                        ++LStu;
                    }
                }
                Console.Write("\n\t\t Continue to insert (Y/N)\t\t\t: ");
                a = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");

                if ((a != 'Y') && (a != 'y'))
                {
                    break;
                }
            } while (true);
            return;

        }

        public void ViewallStudents()
        {
            Console.WriteLine("\n\t\t\t\t\t\t View all Students \n");

            Console.WriteLine("Student ID \t Student Name \t Student Address \t Student Email \t Student DoB \t Student Class ");

            for (int i = 0; i < LStu; i++)
            {

                Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4} \t {5} ",
                    stuList[i].getId(),
                    stuList[i].getName(),
                    stuList[i].getAddress(),
                    stuList[i].getEmail(),
                    stuList[i].getDoB(),
                    stuList[i].getBatch());

            }
            Console.WriteLine("Number of students:{0}", LStu);

            Console.ReadLine();
            return;

        }
        public void UpdateStudent()
        {

            while (true)
            {
                Console.WriteLine("\t\t\t\t\t\t Update Student Data \n");

                Console.Write("Student ID : ");
                string stdId = Convert.ToString(Console.ReadLine());
                Console.Write("Student Name: ");
                string stdName = Console.ReadLine();
                Console.Write("Student Email: ");
                string stdEmail = Console.ReadLine();
                Console.Write("Student Address: ");
                string stdAddress = Console.ReadLine();
                Console.Write("Student DoB: ");
                string stdDoB = Console.ReadLine();
                Console.Write("Student Class: ");
                string stdBatch = Console.ReadLine();
                Console.Write("Do you want to save the input data (Y/N) : ");
                char a = char.Parse(Console.ReadLine());

                if ((a == 'Y') || (a == 'y'))
                {
                    if (checkStuId(stdId) == true)
                    {
                        insertStuData(getStuIdx(stdId), stdId, stdName, stdAddress, stdEmail, stdDoB, stdBatch);
                    }
                }

                Console.Write("Continue to update (Y/N) : ");
                a = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");

                if ((a != 'Y') && (a != 'y'))
                {
                    break;
                }
            }
            return;

        }

        
        public void DeleteStudent()
        {         

            while (true)
            {
                Console.WriteLine("\t\t\t\t\t\t Delete Student Data \n");

                Console.Write("Input the student id : ");
                String stuId = Console.ReadLine();

                if (checkStuId(stuId))
                {
                    Student stu = getStuData(getStuIdx(stuId));


                }
                else
                {
                    Console.WriteLine("\n\t\t You enter a wrong student Id !!!");
                }

                Console.Write("Delete the student data (Y/N) : ");
                char a = Console.ReadKey().KeyChar;

                if ((a == 'Y') || (a == 'y'))
                {
                    if (checkStuId(stuId) == true)
                    {
                        deleteStuData(getStuIdx(stuId));
                        --LStu;
                    }
                }

                Console.Write("Continue to delete (Y/N) : ");
                a = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");

                if ((a != 'Y') || (a != 'y'))
                {
                    break;
                }

            }

            return;
        }

        public void SearchStudent()
        {  

            do
            {
                Console.WriteLine("\t\t\t\t\t\t Show Student Data \n");
                Console.Write("Input the student id : ");
                String stuId = Console.ReadLine();
                while (checkStuId(stuId) == true)
                {
                    Student stu = getStuData(getStuIdx(stuId));
                    Console.WriteLine("Student Id: {0}", stu.getId());
                    Console.WriteLine("Student Name: {0}", stu.getName());                  
                    Console.WriteLine("Student Address: {0}", stu.getAddress());
                    Console.WriteLine("Student Email: {0}", stu.getEmail());
                    Console.WriteLine("Student DoB: {0}", stu.getDoB());
                    Console.WriteLine("Student Class: {0}", stu.getBatch());

                    break;
                }
                while (checkStuId(stuId) == false)
                {
                    Console.WriteLine("\n\t\t You enter a wrong student Id !!!");
                    break;
                }
                Console.Write("Continue (Y/N) : ");
                char c = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");
                if ((c != 'Y') && (c != 'y'))
                {
                    break;
                }
            } while (true);
            return;
        }

        static bool checkStuId(String id)
        {

            for (int i = 0; i < LStu; i++)
            {
                if (stuList[i].getId() == id)
                    return true;
            }
            return false;
        }

        static int getStuIdx(String id)
        {
            for (int i = 0; i < LStu; i++)
                if (stuList[i].getId() == id)
                    return i;

            return -1;
        }

        static void insertStuData(int idx, string stdId, string stdName, string stdAddress, string stdEmail, string stdDoB, string stdBatch)
        {
            stuList[idx] = new Student(stdId, stdName, stdAddress, stdEmail, stdDoB, stdBatch);
        }

        static Student getStuData(int idx)
        {
            return stuList[idx];
        }

        static void deleteStuData(int idx)
        {
            Student[] StuArray = new Student[MAX_STU];

            for (int i = 0; i < LStu; i++)
            {
                StuArray[i] = new Student();
            }

            Array.Copy(stuList, 0, StuArray, 0, idx);
            Array.Copy(stuList, idx + 1, StuArray, idx, MAX_STU - idx - 1);

            Array.Copy(StuArray, stuList , MAX_STU);

        }
    }
}
