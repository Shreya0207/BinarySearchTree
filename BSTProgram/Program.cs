using System;

namespace BSTProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree();
        }
        public static void BinarySearchTree()
            {
                Console.WriteLine("Welcome to the Binary Search Tree program");

                var bst = new BinarySearch<int>();
                bst.Add(56);
                bst.Add(30);
                bst.Add(70);
                bst.Display(bst.value);
            }
    }
}
