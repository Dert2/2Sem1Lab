﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Sem1Lab
{
    class Cheburek : ISemiFinishedFood
    {
        public string Name { get; } = "Cheburek";
        public bool Proteins => false;

        public bool Fats => true;

        public bool Carbohydrates => false;
    }
}
