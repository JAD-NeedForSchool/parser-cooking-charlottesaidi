using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingParser.Operation.Simple
{
    abstract class SimpleOperation: Operation
    {
        public SimpleOperation(string name) : base(name)
        {
        }
    }
}
