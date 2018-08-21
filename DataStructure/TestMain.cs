using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class TestMain
    {
        static void Main(string[] args)
        {
            BTreeTest();
        }

        public static void BTreeTest()
        {
            BinaryTree bTree = new BinaryTree(8);

            bTree.AddNode(7);
            bTree.AddNode(9);
            bTree.AddNode(2);
            bTree.AddNode(3);
            bTree.AddNode(14);

            bTree.Traverse(TreeTraversal.InOrder);
            Console.WriteLine();
            bTree.Traverse(TreeTraversal.PreOrder);
            Console.WriteLine();
            bTree.Traverse(TreeTraversal.PostOrder);
            Console.WriteLine();

            bTree.AddNode(12);
            bTree.AddNode(17);
            bTree.AddNode(16);
            bTree.AddNode(19);

            bTree.Traverse(TreeTraversal.InOrder);

            if (bTree.RemoveNode(14))
            {
                Console.WriteLine();
                bTree.Traverse(TreeTraversal.InOrder);
            }

        }
    }
}
