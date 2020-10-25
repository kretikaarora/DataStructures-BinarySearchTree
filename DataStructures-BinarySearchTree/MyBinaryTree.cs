using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures_BinarySearchTree
{
    /// <summary>
    /// Creating My Binar Tree
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class MyBinaryTree<T> where T: IComparable
    {
        public T nodeData;
        public MyBinaryTree<T> leftTree;
        public MyBinaryTree<T> rightTree;
        public int rightCount = 0;
        public int leftCount = 0;

        /// <summary>
        /// Parameterised Constructor
        /// </summary>
        /// <param name="nodeData"></param>
        public MyBinaryTree(T nodeData)
        {
            this.nodeData = nodeData;
            this.leftTree = null;
            this.rightTree = null;
        }

        /// <summary>
        /// Inserting values in Binary Search Tree
        /// UC1
        /// </summary>
        /// <param name="item"></param>
        public void Insert(T item)
        {
            ///copying the value of nodeData into currentnodevalue
            ///following inorder 
            ///comparing if the value entered is greater than current node or less than 
            ///if less than currentnodevalue then adding into left tree 
            ///if greater than adding into right tree
            T currentNodeValue = this.nodeData;
            if (currentNodeValue.CompareTo(item) > 0)
            {
                ///after this checking if left tree is null or not 
                ///if null then crating a new mybinarytree for left node and passing item
                ///otherwise inserting in the already existing leftnode
                if (this.leftTree == null)
                {
                    this.leftTree = new MyBinaryTree<T>(item);
                    Console.WriteLine("Inserting {0} on left", item);
                }
                ///for recursion remember first it will reach the end node and also traverse back to upper nodes
                else
                    this.leftTree.Insert(item);
            }
            else
            {
                ///if compare to function gives -1 then else block is followed
                ///same steps are followed as in left value
                ///using recursion to insert values in left and right tree
                if (this.rightTree == null)
                {
                    this.rightTree = new MyBinaryTree<T>(item);
                    Console.WriteLine("Inserting {0} on the right", item);
                }
                else
                    this.rightTree.Insert(item);
            }
            }

        /// <summary>
        /// Displaying the Binary Search Tree
        /// </summary>
        public void Display()
        {
            ///if left tree is not null then it will use recursion and reach to the last node of left tree and print it 
            ///then start coming back from that node and printing the other values in that left tree 
            ///after that it will reach the root
            ///then it will go for the right tree and reach the node which has no child and print 
            ///then start coming back using recursion
            if (this.leftTree != null)
            {
                this.leftCount++;
                this.leftTree.Display();
            }
            Console.WriteLine(this.nodeData.ToString());
            if (this.rightTree != null)
            {
                this.rightCount++;
                this.rightTree.Display();
            }          
    }

        /// <summary>
        /// Geting Size of Binary Search Tree
        /// </summary>
        public void GetSize()
        {
            Console.WriteLine("Size" + " " + (1 + this.leftCount + this.rightCount));
        }
    }
}
