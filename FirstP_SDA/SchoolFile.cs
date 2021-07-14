using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstP_SDA
{
    class SchoolFile
    {
        public int id { get; set; }
        public string name { get; set; }
        public string class_ { get; set; }
        public string section { get; set; }
         
        public SchoolFile(int id ,string name ,string class_,string section)
        {
            this.id = id;
            this.name = name;
            this.class_ = class_;
            this.section = section;
        }
    }
}
