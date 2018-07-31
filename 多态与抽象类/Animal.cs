using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态与抽象类
{
    abstract class Animal
    {
        public abstract void Bark();

        public abstract string Name
        {
            get;
            set;
        }
    }
}
