#include "stdafx.h"
#include <vector>
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


class Solution {
public:
    //双栈解法
    vector<vector<int> > Print(TreeNode* pRoot) {
        vector<vector<int> > res;
        stack<TreeNode*> stack1,stack2;
        
        if(pRoot)
        {
            stack1.push(pRoot);
        }
        
        while(!stack1.empty()||!stack2.empty())
        {
            vector<int> data;
            //stack1从左到右
            if(!stack1.empty())
            {
                while(!stack1.empty())
                {
                    //pNode pop
                    TreeNode *pNode=stack1.top();
                    stack1.pop();
                    //data push
                    data.push_back(pNode->val);
                    //pNode push in stack2, from left to right
                    if(pNode->left)
                    {
                        stack2.push(pNode->left);
                    }
                    if(pNode->right)
                    {
                        stack2.push(pNode->right);
                    }
                }
                //vector<int> data push
                res.push_back(data);
            }
            //stack2从右到左
            else if(!stack2.empty())
            {
                while(!stack2.empty())
                {
                    //pNode pop
                    TreeNode *pNode=stack2.top();
                    stack2.pop();
                    //data push
                    data.push_back(pNode->val);
                    //pNode push in stack1, from right to left
                    if(pNode->right)
                    {
                        stack1.push(pNode->right);
                    }
                    if(pNode->left)
                    {
                        stack1.push(pNode->left);
                    }

                }
                //vector<int> data push
                res.push_back(data);
            }
        }
        return res;

    }
    
};