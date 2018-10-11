using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.BinaryTree2
{
    public delegate bool DataCompare<T>(T a, T b);

    public class PBinaryTree<T>
    {
        private BNode<T> _rootNode;
        private DataCompare<T> _dataCompare;

        public PBinaryTree(T data, DataCompare<T> dataCompare)
        {
            _rootNode = new BNode<T>(data);
            _dataCompare = dataCompare;
        }

        public void SetDataComparison(DataCompare<T> dataCompare)
        {
            _dataCompare = dataCompare;
        }

        public bool Insert(T targetData)
        {
            if (GetNode(targetData).Item2 != null)
                return false;
            else
            {
                BNode<T> pNode = GetNode(targetData).Item1;

                if (_dataCompare(pNode.Data, targetData))
                    pNode.LeftNode = new BNode<T>(targetData);
                else
                    pNode.RightNode = new BNode<T>(targetData);

                return true;
            }

        }

        public bool Delete(T targetData)
        {
            if (GetNode(targetData).Item2 != null)
            {
                BNode<T> pNode = GetNode(targetData).Item1;
                BNode<T> cNode = GetNode(targetData).Item2;
                BNode<T> rNode;

                if (_dataCompare(pNode.Data, cNode.Data))
                {
                    if (cNode.LeftNode == null)
                    {
                        if (cNode.RightNode == null)
                        {
                            pNode.LeftNode = null;
                        }
                        else
                        {
                            rNode = cNode.RightNode;

                            while (true)
                            {
                                if (rNode.LeftNode != null)
                                {
                                    rNode = rNode.LeftNode;
                                }
                                else
                                    break;
                            }

                            pNode.LeftNode = rNode;
                            rNode.LeftNode = cNode.LeftNode;
                            rNode.RightNode = cNode.RightNode;
                        }
                    }
                    else
                    {
                        rNode = cNode.LeftNode;

                        while (true)
                        {
                            if (rNode.RightNode != null)
                            {
                                rNode = rNode.RightNode;
                            }
                            else
                                break;
                        }

                        pNode.LeftNode = rNode;
                        rNode.LeftNode = cNode.LeftNode;
                        rNode.RightNode = cNode.RightNode;
                    }

                    return true;
                }
                else
                {
                    if (cNode.LeftNode == null)
                    {
                        if (cNode.RightNode == null)
                        {
                            pNode.RightNode = null;
                        }
                        else
                        {
                            rNode = cNode.RightNode;

                            while (true)
                            {
                                if (rNode.LeftNode != null)
                                {
                                    rNode = rNode.LeftNode;
                                }
                                else
                                    break;
                            }

                            pNode.RightNode = rNode;
                            rNode.LeftNode = cNode.LeftNode;
                            rNode.RightNode = cNode.RightNode;
                        }
                    }
                    else
                    {
                        rNode = cNode.LeftNode;

                        while (true)
                        {
                            if (rNode.RightNode != null)
                            {
                                rNode = rNode.RightNode;
                            }
                            else
                                break;
                        }

                        pNode.RightNode = rNode;
                        rNode.LeftNode = cNode.LeftNode;
                        rNode.RightNode = cNode.RightNode;
                    }

                    return true;

                }
            }
            else
                return false;
        }


        public BNode<T> Search(T targetData)
        {
            if (GetNode(targetData).Item2 != null)
                return GetNode(targetData).Item2;
            else
                return null;
        }

        private Tuple<BNode<T>, BNode<T>> GetNode(T targetData)
        {
            BNode<T> curNode = _rootNode;
            BNode<T> parNode = null;

            while (curNode != null)
            {
                if (curNode.Data.Equals(targetData))
                {
                    return new Tuple<BNode<T>, BNode<T>>(parNode, curNode);
                }

                parNode = curNode;

                if (_dataCompare(curNode.Data, targetData))
                    curNode = curNode.LeftNode;
                else
                    curNode = curNode.RightNode;
            }

            return new Tuple<BNode<T>, BNode<T>>(parNode, null);
        }

        public void Show()
        {
            InOrder(_rootNode);
        }

        private void InOrder(BNode<T> node)
        {
            if (node.LeftNode != null)
                InOrder(node.LeftNode);

            Console.WriteLine(node.Data);

            if (node.RightNode != null)
                InOrder(node.RightNode);
        }

    }


}
