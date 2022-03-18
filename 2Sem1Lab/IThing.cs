using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Sem1Lab
{
    interface IThing
    {
        public abstract string Name { get; }

        public virtual string GetName()
        {
            return Name;
        }
    }
}
