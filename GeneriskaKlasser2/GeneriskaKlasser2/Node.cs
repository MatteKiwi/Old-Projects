using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneriskaKlasser2
{
    class Node<T>
    {
        public T contents;
        List<Node<T>> neighbors = new List<Node<T>>();
    }
}
