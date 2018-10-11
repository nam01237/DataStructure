using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.BinaryTree2
{
    public class BNode<T>
    {
        public BNode(T data)
        {
            Data = data;
        }

        public T Data { get; }

        public BNode<T> LeftNode { get; set; }
        public BNode<T> RightNode { get; set; }

    }
}
