using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class BinaryTreeNode
    {
        public BinaryTreeNode(int data)
        {
            Data = data;
        }

        public BinaryTreeNode() { }

        private BinaryTreeNode _leftNode;
        public BinaryTreeNode LeftNode
        {
            get { return _leftNode; }
            set
            {
                _leftNode = value;

                if( value != null )
                    _leftNode.Parent = this;
            }
        }
        private BinaryTreeNode _rightNode;
        public BinaryTreeNode RightNode
        {
            get { return _rightNode; }
            set
            {
                _rightNode = value;

                if( value != null )
                    _rightNode.Parent = this;
            }
        }

        public int Data { get; set; }

        public BinaryTreeNode Parent { get; private set; }        
    }

    public class BinaryTree
    {
        private BinaryTreeNode _rootNode;

        public BinaryTree(int rootData)
        {
            _rootNode = new BinaryTreeNode(rootData);
        }

        public bool AddNode(int data)
        {
            BinaryTreeNode currentNode = _rootNode;

            while(true)
            {
                if (data == currentNode.Data)
                    return false;

                if( data < currentNode.Data )
                {
                    if( currentNode.LeftNode != null )
                    {
                        currentNode = currentNode.LeftNode;
                    }
                    else
                    {
                        currentNode.LeftNode = new BinaryTreeNode(data);
                        break;
                    }
                }
                else
                {
                    if ( currentNode.RightNode != null )
                    {
                        currentNode = currentNode.RightNode;
                    }
                    else
                    {
                        currentNode.RightNode = new BinaryTreeNode(data);
                        break;
                    }
                }
            }

            return true;
        }

        public void Traverse(TreeTraversal order)
        {
            if (order == TreeTraversal.InOrder)
                InOrder(_rootNode);
            else if (order == TreeTraversal.PreOrder)
                PreOrder(_rootNode);
            else if (order == TreeTraversal.PostOrder)
                PostOrder(_rootNode);
        }

        public void PreOrder( BinaryTreeNode node)
        {
            Console.WriteLine( node.Data );
            if ( node.LeftNode != null )
                PreOrder( node.LeftNode );
            if (node.RightNode != null)
                PreOrder( node.RightNode );
        }
        
        public void InOrder ( BinaryTreeNode node)
        {
            if ( node.LeftNode != null )
                InOrder( node.LeftNode );
            Console.WriteLine( node.Data );
            if (node.RightNode != null)
                InOrder(node.RightNode);
        }

        public void PostOrder (BinaryTreeNode node)
        {
            if (node.LeftNode != null)
                InOrder(node.LeftNode);
            if (node.RightNode != null)
                InOrder(node.RightNode);
            Console.WriteLine(node.Data);
        }

        public BinaryTreeNode SearchNode(int data)
        {
            BinaryTreeNode currentNode = _rootNode;

            while (true)
            {

                if (data == currentNode.Data)
                    return currentNode;

                if (data < currentNode.Data)
                {
                    if (currentNode.LeftNode != null)
                    {
                        currentNode = currentNode.LeftNode;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    if (currentNode.RightNode != null)
                    {
                        currentNode = currentNode.RightNode;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public bool RemoveNode(int data)
        {
            BinaryTreeNode targetNode = SearchNode(data);

            if (targetNode == null)
                return false;
            else
            {
                BinaryTreeNode tempNode;

                if ((targetNode.LeftNode == null) && (targetNode.RightNode == null))
                {
                    if (targetNode.Parent.LeftNode == targetNode)
                    {
                        targetNode.Parent.LeftNode = null;
                    }
                    else if (targetNode.Parent.RightNode == targetNode)
                    {
                        targetNode.Parent.RightNode = null;
                    }
                }
                else if ((targetNode.LeftNode != null) || (targetNode.RightNode != null))
                {
                    if ((targetNode.LeftNode != null) && (targetNode.RightNode != null))
                    {
                        if (targetNode.Parent.LeftNode == targetNode)
                        {
                            tempNode = GetSmallNode(targetNode.RightNode);
                            RemoveNode(tempNode.Data);
                            targetNode.Data = tempNode.Data;
                        }
                        else if (targetNode.Parent.RightNode == targetNode)
                        {
                            tempNode = GetSmallNode(targetNode.RightNode);
                            RemoveNode(tempNode.Data);
                            targetNode.Data = tempNode.Data;
                        }

                        return true;
                    }

                    if (targetNode.Parent.LeftNode == targetNode)
                    {
                        if (targetNode.LeftNode != null)
                        {
                            targetNode.Parent.LeftNode = targetNode.LeftNode;
                        }
                        else
                        {
                            targetNode.Parent.LeftNode = targetNode.RightNode;
                        }
                    }
                    else if (targetNode.Parent.RightNode == targetNode)
                    {
                        if (targetNode.LeftNode != null)
                        {
                            targetNode.Parent.RightNode = targetNode.LeftNode;
                        }
                        else
                        {
                            targetNode.Parent.RightNode = targetNode.RightNode;
                        }
                    }
                }


            }

            return true;
        }

        private BinaryTreeNode GetSmallNode(BinaryTreeNode node)
        {
            if( node.LeftNode != null )
            {
                node = node.LeftNode;
                GetSmallNode(node);
            }

            return node;
            
        }
    }

    public enum TreeTraversal
    {
        PreOrder,
        PostOrder,
        InOrder
    }


}
