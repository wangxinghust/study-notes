#include "stdafx.h"
#include <stdlib.h>
#include <algorithm>
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
    bool IsBalanced_Solution(TreeNode* pRoot) {
        return getDepth(pRoot)!=-1;
    }
private:
    int getDepth(TreeNode* pRoot)
    {
        if(pRoot==nullptr)
        {
            return 0;
        }
        int left=getDepth(pRoot->left);
        if(left==-1)
        {
            return -1;
        }
        int right=getDepth(pRoot->right);
        if(right==-1)
        {
            return -1;
        }
        return abs(left-right)>1?-1:1+max(left,right);
    }
};