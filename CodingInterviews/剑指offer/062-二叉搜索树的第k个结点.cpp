#include "stdafx.h"
#include <stack>
using namespace std;


struct TreeNode {
    int val;
    struct TreeNode *left;
    struct TreeNode *right;
    TreeNode(int x) :
            val(x), left(NULL), right(NULL) {
    }
};

//给定一棵二叉搜索树，请找出其中的第k小的结点。例如（5，3，7，2，4，6，8）中，按结点数值大小顺序第三小结点的值为4。
class Solution {
public:
    //solve by non-recursive inorder traversal
    TreeNode* KthNode(TreeNode* pRoot, int k)
    {
        if(!pRoot||k<1)
        {
            return nullptr;
        }
        
        stack<TreeNode*> s;
        TreeNode *pNode=pRoot;
        while(pNode||!s.empty())
        {
            //if right node exist, push in stack, temporary memory until find the last left node
            while(pNode)
            {
                s.push(pNode);
                pNode=pNode->left;
            }
            //fetch the value stored in the stack
            if(!s.empty())
            {
                pNode=s.top();
                k--;
                if(k<1)
                {
                    return pNode;
                }
                s.pop();
                pNode=pNode->right;
            }
        }
        return nullptr;
    }
};