using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类练习
{
    class Computer
    {
        private Storage _storage;

        internal Storage Storage { get => _storage; set => _storage = value; }

        public Computer(Storage storage)
        {
            this.Storage = storage;
        }

        
    }
}
