using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Sem1Lab
{
    class DumplingsMeat : ISemiFinishedFood
    {
        public string Name { get; } = "DumplingsMeat";
        public bool Proteins => true;

        public bool Fats => false;

        public bool Carbohydrates => false;
    }
}
