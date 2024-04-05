using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingParser.Operation
{
    abstract class Operation
    {
        string Name { get; set; }

        public Operation(string name)
        {
            Name = name;
        }
    }
}
