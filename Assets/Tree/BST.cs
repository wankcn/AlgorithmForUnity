using System;

namespace Tree
{
    public class BST<E> where E : IComparable<E>
    {
        private class Node
        {
            public E e;
            public Node left, right;

            public Node(E e)
            {
                this.e = e;
                left = null;
                right = null;
            }
        }

        private Node root;
        private int size;

        public BST()
        {
            root = null;
            size = 0;
        }

        public int Length => size;
        public bool IsEmpty => size == 0;


        public void Add(E e)
        {
            // if (root == null)
            // {
            //     root = new Node(e);
            //     size++;
            // }
            // else
            //     Add(root, e);
            root = Add(root, e);
        }


        /// <summary>
        /// 向以node为根节点的二分搜索树中插入元素e
        /// </summary>
        /// <param name="node"></param>
        /// <param name="e"></param>
        /// <returns>返回插入新节点后二分搜索树的根</returns>
        private Node Add(Node node, E e)
        {
            // if (e.Equals(node.e)) return;
            // else if (e.CompareTo(node.e) < 0 && node.left == null)
            // {
            //     node.left = new Node(e);
            //     size++;
            //     return;
            // }
            // else if (e.CompareTo(node.e) > 0 && node.right == null)
            // {
            //     node.right = new Node(e);
            //     size++;
            //     return;
            // }

            // Add(e.CompareTo(node.e) < 0 ? node.left : node.right, e);
            if (node == null)
            {
                size++;
                return new Node(e);
            }

            if (e.CompareTo(node.e) < 0) node.left = Add(node.left, e);
            else if (e.CompareTo(node.e) > 0) node.right = Add(node.right, e);
            return node;
        }


        public bool Contains(E e)
        {
            return Contains(root, e);
        }

        private bool Contains(Node node, E e)
        {
            if (node == null) return false;
            if (e.CompareTo(node.e) == 0) return true;
            else if (e.CompareTo(node.e) < 0) return Contains(node.left, e);
            else return Contains(node.right, e);
        }
    }
}