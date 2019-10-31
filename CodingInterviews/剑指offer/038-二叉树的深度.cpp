#include "stdafx.h"
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
    int TreeDepth(TreeNode* pRoot)
    {
		if(pRoot==nullptr)
		{
			return 0;
		}
		if(pRoot->left==nullptr&&pRoot->right==nullptr)
		{
			return 1;
		}
		if(pRoot->left==nullptr)
		{
			return TreeDepth(pRoot->right)+1;
		}
		if(pRoot->right==nullptr)
		{
			return TreeDepth(pRoot->left)+1;
		}
		return TreeDepth(pRoot->left)>TreeDepth(pRoot->right)?TreeDepth(pRoot->left)+1:TreeDepth(pRoot->right)+1;		
    }
};