using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Basic_Command.Model
{
    public class Category
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public Category(string iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}
