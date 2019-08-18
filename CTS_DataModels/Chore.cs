using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS_DataModels
{
    class Chore
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Chore(string name)
        {
            this.Name = name;
        }

    }
}
