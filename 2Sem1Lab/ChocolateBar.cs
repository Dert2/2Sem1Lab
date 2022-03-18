using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Sem1Lab
{
    class ChocolateBar : ISnacks
    {
        public string Name { get; } = "ChocolateBar";
        public bool Proteins => false;

        public bool Fats => false;

        public bool Carbohydrates => true;
    }
}
