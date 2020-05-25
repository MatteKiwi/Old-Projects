using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneriskaKlasser2
{
    class Container<T>
    {
        public T contents;
        public Container<T> next;
    }
}
