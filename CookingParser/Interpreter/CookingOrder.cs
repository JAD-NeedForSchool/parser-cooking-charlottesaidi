﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingParser.Interpreter
{
    interface CookingOrder
    {
        void Interprete(CookingRecipeOrder context);
    }
}
