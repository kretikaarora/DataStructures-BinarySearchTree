// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Capgemini">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Kretika Arora"/>
// --------------------------------------------------------------------------------------------------------------------
using System;

namespace DataStructures_BinarySearchTree
{
    /// <summary>
    /// Program class
    /// </summary>
    class Program
    {
        /// <summary>
        /// Calling functions from MyBinaryTree
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Binary Search Tree");
            MyBinaryTree<int> myBinaryTree = new MyBinaryTree<int>(56);            
            myBinaryTree.Insert(30);
            myBinaryTree.Insert(70);
            myBinaryTree.Insert(22);
            myBinaryTree.Insert(40);
            myBinaryTree.Insert(60);
            myBinaryTree.Insert(95);
            myBinaryTree.Insert(11);
            myBinaryTree.Insert(65);
            myBinaryTree.Insert(3);
            myBinaryTree.Insert(16);           
            myBinaryTree.Insert(63);
            myBinaryTree.Insert(67);
            Console.WriteLine("Displaying Binary Search Tree");
            myBinaryTree.Display();
            Console.WriteLine("Searching an element");
            myBinaryTree.Search(63, myBinaryTree);
            myBinaryTree.Search(12, myBinaryTree);
        }
    }
}
