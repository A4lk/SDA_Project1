using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FirstP_SDA
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int choose;
            School sc = new School();
           // StreamWriter WriteNew = new StreamWriter("newFile.txt", true);
            string pathFile = @"C:\Users\azooz\source\repos\FirstP_SDA\FirstP_SDA\bin\Debug\newFile.txt\";
            Console.WriteLine("---- Welcome To Rainbow School System ----");
            bool status = true;
            while (status)
            {
                //Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Choose from 1 to 3 Please");
                Console.WriteLine("1- Add New Data");
                Console.WriteLine("2- Update Data");
                Console.WriteLine("3- Exit");
                choose = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.White;



                switch (choose)
                {
                    case 1:

                       

                        Console.WriteLine("Enter ID");
                        int id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter a name ");
                        string name = Console.ReadLine();

                        Console.WriteLine("Enter a Class ");
                        string Class_ = Console.ReadLine();

                        Console.WriteLine("Enter a Sectaion ");
                        string section = Console.ReadLine();

                        sc.addNew(id, name, Class_, section);

                        break;
                    case 2:
           
                        Console.WriteLine("Enter ID you want to update");
                        int id_search = int.Parse(Console.ReadLine());
                        SchoolFile s1 = sc.GetSchoolFile(id_search);

                        if (s1 != null)
                        {


                            Console.WriteLine($"The ID: {s1.id}\nTheName: {s1.name}\nThe Class: {s1.class_}\nThe Section: {s1.section}");

                            int old_id = s1.id;


                            Console.WriteLine("Enter New id ");
                            int new_id = int.Parse(Console.ReadLine());

                            Console.WriteLine("Enter New name");
                            string new_name = Console.ReadLine();

                            Console.WriteLine("Enter New Class");
                            string new_class = Console.ReadLine();

                            Console.WriteLine("Enter New secation");
                            string new_secation = Console.ReadLine();


                            sc.upDate(old_id, new_id, new_name, new_class, new_secation);

                        }
                        else
                        {
                            Console.WriteLine("we can't found this id sorry ");
                        }

                            break;
                    case 3:
                        status = false;
                        break;
                     
                }
            }
           
            Console.ReadLine();
        }
    }
}
