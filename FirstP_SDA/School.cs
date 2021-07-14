using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FirstP_SDA
{
    class School
    {
        
        StreamWriter Writer;


        string pathFile = "C:\\Users\\azooz\\source\\repos\\FirstP_SDA\\FirstP_SDA\\bin\\Debug\\newFile.txt";

        public void addNew(int id,string name,string Class_, string section)
        {
            Writer = File.AppendText(pathFile);
            string value = id + "-" + name + "-" + Class_ + "-" + section + "\n";

            Writer.Write(value);


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Added done ");
            Writer.Close();

        }
        public SchoolFile GetSchoolFile(int id)
        {
            string []lines = File.ReadAllLines(pathFile);
            foreach(var x in lines)
            {
                string[] line = x.Split('-');
                if (int.Parse(line[0]) == id)
                {
                    SchoolFile s = new SchoolFile(int.Parse(line[0]), line[1], line[2], line[3]);
                    return s;
                }
            }
            return null;
        }
        public void upDate(int old_id, int new_id, string new_name,string new_class,string new_secation)
        {
            string[] lines = File.ReadAllLines(pathFile);
            bool status = false;

            for (int c = 0; c < lines.Length; c++)
            {
                string[] line = lines[c].Split('-');
                if (int.Parse(line[0])== old_id)
                {
                    lines[c] = new_id + "-" + new_name + "-" + new_class + "-" + new_secation;
                    status = true;
                }
            }
            
            if (status)
            {
                File.WriteAllLines(pathFile, lines);
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine("Update is Done");
            }
           
        }
       
    }
}
