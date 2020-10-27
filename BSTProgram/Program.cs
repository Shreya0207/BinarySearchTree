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
            var numbers = new int[5] { 4, 5, 78, 34, 53 };
            foreach (var num in numbers)
            {
                bst.Add(num);
            }
            bst.Display(bst.value);
            Console.WriteLine(bst.Size());
        }
    }
}
