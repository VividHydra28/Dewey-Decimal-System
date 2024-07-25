using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_POE
{

    public class DataTree<T>
    {

        public T Data { get; set; }
        public DataTree<T> Parent { get; set; }
        public List<DataTree<T>> Children { get; set; }
    }


    public class Tree<T>
    {
        public DataTree<T> Root { get; set; }
    }


}
