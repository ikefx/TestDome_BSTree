using System;

/*
 * 
 * Binary search tree (BST) is a binary tree where the value of each node is larger or equal to the values in all the nodes in that 
 * node's left subtree and is smaller than the values in all the nodes in that node's right subtree.  Write a function that checks 
 * if a given binary search tree contains a given value.

    For example, for the following tree:
        n1 (Value: 1, Left: null, Right: null)
        n2 (Value: 2, Left: n1, Right: n3)
        n3 (Value: 3, Left: null, Right: null)
    Call to Contains(n2, 3) should return true since a tree with root at n2 contains number 3.

 */

public class Node
{
    /* binary search tree node */
    public int Value { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }

    public Node(int value, Node left, Node right){
        Value = value;
        Left = left;
        Right = right;
    }
}

public class BinarySearchTree
{
    public static bool Contains(Node root, int value)
    {
        /* check if value exist in node or its node.left or node.right
         * values less than root.value must be in children to 
         *      the left of root.value
         * values greater than root.value must be in children 
         *      to the right of root.value
         * use recursion to traverse until found, otherwise
         *      return 'false'
         */

        if (root.Value == value)
            return true;
        if (root.Left != null && value < root.Value)
        {
            if (Contains(root.Left, value))
            {
                return true;
            }
        }
        if (root.Right != null && value > root.Value)
        {
            if (Contains(root.Right, value))
            {
                return true;
            }
        }
        return false;
    }

    public static void Main(string[] args)
    {
        Node n1 = new Node(1, null, null);
        Node n3 = new Node(3, null, null);
        Node n2 = new Node(2, n1, n3);

        Console.WriteLine(Contains(n2, 3));
        Console.ReadKey();
    }
}