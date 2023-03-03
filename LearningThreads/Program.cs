using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace HV
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }


    // Definition for a Node.
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }




    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public int MaxDepth(TreeNode root)
        {
            int maxDepth = 0;
            void Helper(TreeNode r)
            {
                if(r.right!=null)
                {
                    
                    Helper(r.right);
                }
                if(r.left!=null)
                {
                    
                    Helper(r.left);
                }
                maxDepth++;
            }
            return maxDepth;
        }
    }

    //if (ro1 != null && ro2 != null)
    //    sum += ro1.val + ro2.val;
    //else if (ro1 == null && ro2 != null)
    //    sum += ro2.val;
    //else
    //    sum += ro1.val;
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = {2,1,2,1,0,1,2};
            Solution solution = new Solution();
            Console.WriteLine(solution.MaxProfit(ints));
            Console.WriteLine();
        }
    }
    

}