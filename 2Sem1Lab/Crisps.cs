using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Sem1Lab
{
    class Crisps : ISnacks
    {
        public string Name { get; } = "Crisps";

        public bool Proteins => false;

        public bool Fats => true;

        public bool Carbohydrates => false;
    }
}
