using DataStructure.HashTable;
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
            //BTreeTest();
            HashTableTest();
        }

        public static void HashTableTest()
        {
            CHashTable<int, string> hashTable = new CHashTable<int, string>(10);
            hashTable.Insert(16, "야구");
            hashTable.Insert(26, "농구");
            hashTable.Insert(12, "축구");

            Console.WriteLine(hashTable.GetValue(16));
            Console.WriteLine(hashTable.GetValue(26));
            Console.WriteLine(hashTable.GetValue(12));
            Console.WriteLine(hashTable.GetValue(15));

            CHashTable<Foo, int> hashTable2 = new CHashTable<Foo, int>(14);

            Foo key1 = new Foo();
            key1.a = 1;
            Foo key2 = new Foo();
            key2.a = 4;

            hashTable2.Insert(key1, 11);
            hashTable2.Insert(key1, 14);
            hashTable2.Insert(key2, 24);

            Console.WriteLine(hashTable2.GetValue(key1));
            Console.WriteLine(hashTable2.GetValue(key2));

            hashTable2.Remove(key2);

            Console.WriteLine(hashTable2.GetValue(key2));

            hashTable.TestShow();
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

    public class Foo
    {
        public int a;
    }
}
