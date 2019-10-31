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
        //first in first out, need deque
        //solution by two deque
        vector<vector<int> > Print(TreeNode* pRoot) {
            vector<vector<int> > res;
            deque<TreeNode*> deque1,deque2;
            if(pRoot)
            {
                deque1.push_back(pRoot);
            }
            while(!deque1.empty()||!deque2.empty())
            {
                vector<int> data;
                if(!deque1.empty())
                {
                    while(!deque1.empty())
                    {
                        TreeNode *pNode=deque1.front();
                        deque1.pop_front();
                        data.push_back(pNode->val);
                        if(pNode->left)
                        {
                            deque2.push_back(pNode->left);
                        }
                        if(pNode->right)
                        {
                            deque2.push_back(pNode->right);
                        }
                    }
                    res.push_back(data);
                }
                else if(!deque2.empty())
                {
                    while(!deque2.empty())
                    {
                        TreeNode *pNode=deque2.front();
                        deque2.pop_front();
                        data.push_back(pNode->val);
                        if(pNode->left)
                        {
                            deque1.push_back(pNode->left);
                        }
                        if(pNode->right)
                        {
                            deque1.push_back(pNode->right);
                        }
                    }
                    res.push_back(data);
                }
            }
            return res;
        }
    
};