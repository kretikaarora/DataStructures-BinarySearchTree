using System;

namespace DataStructures_BinarySearchTree
{
    /// <summary>
    /// Program class
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Binary Search Tree");
            MyBinaryTree<int> myBinaryTree = new MyBinaryTree<int>(56);            
            myBinaryTree.Insert(30);
            myBinaryTree.Insert(70);
            Console.WriteLine("Displaying Binary Search Tree");
            myBinaryTree.Display();
        }
    }
}
