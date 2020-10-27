using System;
using System.Collections.Generic;
using System.Text;

namespace BSTProgram
{
    class BinarySearch<T> where T : IComparable
    {
        public BinaryNode<T> value;
        public BinaryNode<T> start;
        public BinarySearch()
        {
            value = null;
            start = null;
        }
        public void Add(T data)
        {
            if (value == null)
            {
                value = new BinaryNode<T>(data);
            }
            else
            {
                var node = new BinaryNode<T>(data);
                var temp = start;
                if (data.CompareTo(value.data) < 0)
                {
                    if (temp.leftside == null)
                        temp.leftside = node;
                    else
                    {
                        start = temp.leftside;
                        Add(data);
                    }
                }
                else
                {
                    if (temp.Rightside == null)
                        temp.Rightside = node;
                    else
                    {
                        start = temp.Rightside;
                        Add(data);
                    }
                }
            }
            start = value;
        }
        public int Size()
        {
            var temp = value;
            var maxSize = 0;
            var stk = new Stack<BinaryNode<T>>();


            while (temp != null || stk.Count != 0)
            {
                var size = 0;
                while (temp != null)
                {
                    stk.Push(temp);
                    temp = temp.leftside;
                    size++;
                }
                temp = stk.Pop();

                temp = temp.Rightside;
                maxSize = maxSize < size ? size : maxSize;
            }
            return maxSize - 1;
        }
        public void Display(BinaryNode<T> start)
        {
            Console.WriteLine("Start : {0}", start.data);
            if (start.leftside != null)
            {
                Console.WriteLine("Left :" + start.leftside.data);
            }
            if (start.Rightside != null)
                Console.WriteLine("Right :" + start.Rightside.data);
            if (start.leftside != null)
            {
                Display(start.leftside);
            }
            if (start.Rightside != null)
            {
                Display(start.Rightside);
            }
        }
    }
}
