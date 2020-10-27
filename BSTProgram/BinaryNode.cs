using System;
using System.Collections.Generic;
using System.Text;

namespace BSTProgram
{
    class BinaryNode<T> where T : IComparable
    {
        public T data;
        public BinaryNode<T> leftside;
        public BinaryNode<T> Rightside;
        public BinaryNode(T data)
        {
            this.data = data;
            leftside = null;
            Rightside = null;
        }
    }
}
