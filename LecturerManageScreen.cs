using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    class LecturerManageScreen
    {
        public const int MAX_LEC = 100;
        static Lecturer[] lecList = new Lecturer[MAX_LEC];
        static int LLec = 0;

        public void AddLecturer()
        {
            do
            {
                Console.Write("\t\t\t\t\t\t Insert Lecturer Data\n");
                Console.Write("Lecturer ID: ");
                string lecId = Console.ReadLine();
                Console.Write("Lecturer Name: ");
                string lecName = Console.ReadLine();
                Console.Write("Lecturer Email: ");
                string lecEmail = Console.ReadLine();
                Console.Write("Lecturer Address: ");
                string lecAddress = Console.ReadLine();
                Console.Write("Lecturer DoB: ");
                string lecDoB = Console.ReadLine();
                Console.Write("Lecturer Dept: ");
                string lecDept = Console.ReadLine();
                Console.Write("Save the input data (Y/N): ");
                char a = Console.ReadKey().KeyChar;
                if ((a == 'Y') || (a == 'y'))
                {
                    if (checkLecId(lecId) == false)
                    {
                        insertLecData(LLec, lecId, lecName, lecAddress, lecEmail, lecDoB, lecDept);
                        ++LLec;
                    }
                }
                Console.Write("Continue to insert (Y/N) : ");
                a = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");

                if ((a != 'Y') && (a != 'y'))
                {
                    break;
                }
            } while (true);
            return;

        }

        public void ViewallLecturers()
        {
            Console.WriteLine("\n\t\t\t\t\t\t View all Lecturers \n");

            Console.WriteLine("Lecturer ID \t Lecturer Name \t Lecturer Address \t Lecturer Email \t Lecturer DoB \t Lecturer Dept ");

            for (int i = 0; i < LLec; i++)
            {

                Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4} \t {5} ",
                    lecList[i].getId(),
                    lecList[i].getName(),
                    lecList[i].getAddress(),
                    lecList[i].getEmail(),
                    lecList[i].getDoB(),
                    lecList[i].getDept());

            }
            Console.WriteLine("Number of lecturer:{0}", LLec);

            Console.ReadLine();
            return;

        }
        public void UpdateLecturer()
        {


            while (true)
            {
                Console.WriteLine("\t\t\t\t\t\t Update Lecturer Data \n");

                Console.Write("Lecturer ID : ");
                string lecId = Convert.ToString(Console.ReadLine());
                Console.Write("Lecturer Name: ");
                string lecName = Console.ReadLine();
                Console.Write("Lecturer Email: ");
                string lecEmail = Console.ReadLine();
                Console.Write("Lecturer Address: ");
                string lecAddress = Console.ReadLine();
                Console.Write("Lecturer DoB: ");
                string lecDoB = Console.ReadLine();
                Console.Write("Lecturer Class: ");
                string lecDept = Console.ReadLine();
                Console.Write("Do you want to save the input data (Y/N) : ");
                char a = char.Parse(Console.ReadLine());

                if ((a == 'Y') || (a == 'y'))
                {
                    if (checkLecId(lecId) == true)
                    {
                        insertLecData(getLecIdx(lecId), lecId, lecName, lecAddress, lecEmail, lecDoB, lecDept);
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

        public void DeleteLecturer()
        {
            while (true)
            {
                Console.WriteLine("\t\t\t\t\t\t Delete Lecturer Data \n");

                Console.Write("Input the lecturer id : ");
                String lecId = Console.ReadLine();

                if (checkLecId(lecId))
                {
                    Lecturer lec = getLecData(getLecIdx(lecId));


                }
                else
                {
                    Console.WriteLine("\n\t\t You enter a wrong lecturer Id !!!");
                }

                Console.Write("\t\t Want to delete the lecturer data (Y/N)\t\t: ");
                char a = Console.ReadKey().KeyChar;

                if ((a == 'Y') || (a == 'y'))
                {
                    if (checkLecId(lecId) == true)
                    {
                        deleteLecData(getLecIdx(lecId));
                        --LLec;
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

        public void SearchLecturer()
        {

            do
            {
                Console.WriteLine("\t\t\t\t\t\t Show Lecturer Data \n");
                Console.Write("Input the Lecturer id : ");
                String lecId = Console.ReadLine();
                while (checkLecId(lecId) == true)
                {
                    Lecturer lec = getLecData(getLecIdx(lecId));
                    Console.WriteLine("Lecturer Id: {0}", lec.getId());
                    Console.WriteLine("Lecturer Name: {0}", lec.getName());
                    Console.WriteLine("Lecturer Address: {0}", lec.getAddress());
                    Console.WriteLine("Lecturer Email: {0}", lec.getEmail());
                    Console.WriteLine("Lecturer DoB: {0}", lec.getDoB());
                    Console.WriteLine("Lecturer Dept: {0}", lec.getDept());

                    break;
                }
                while (checkLecId(lecId) == false)
                {
                    Console.WriteLine("\n\t\t You enter a wrong lecturer Id !!!");
                    break;
                }
                Console.Write("Continue to show (Y/N) : ");
                char a = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");
                if ((a != 'Y') && (a != 'y'))
                {
                    break;
                }
            } while (true);
            return;
        }

        static bool checkLecId(String id)
        {

            for (int i = 0; i < LLec; i++)
            {
                if (lecList[i].getId() == id)
                    return true;
            }
            return false;
        }

        static int getLecIdx(String id)
        {
            for (int i = 0; i < LLec; i++)
                if (lecList[i].getId() == id)
                    return i;

            return -1;
        }

        static void insertLecData(int idx, string lecId, string lecName,  string lecAddress, string lecEmail, string lecDoB, string lecDept)
        {
            lecList[idx] = new Lecturer(lecId, lecName,  lecAddress, lecEmail, lecDoB, lecDept);
        }

        static Lecturer getLecData(int idx)
        {
            return lecList[idx];
        }

        static void deleteLecData(int idx)
        {
            Lecturer[] lecArray = new Lecturer[MAX_LEC];

            for (int i = 0; i < LLec; i++)
            {
                lecArray[i] = new Lecturer();
            }

            Array.Copy(lecList, 0, lecArray, 0, idx);
            Array.Copy(lecList, idx + 1, lecArray, idx, MAX_LEC - idx - 1);

            Array.Copy(lecArray, lecList, MAX_LEC);

        }
    }
}
