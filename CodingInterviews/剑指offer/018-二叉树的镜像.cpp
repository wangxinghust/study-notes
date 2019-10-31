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
//操作给定的二叉树，将其变换为源二叉树的镜像。
class Solution {
public:
	void Mirror(TreeNode *pRoot) {
		//任何时间都不要忘了空指针的访问，访问空指针指向一定会炸的
		if (!pRoot)
		{
			return;
		}
		//交换左右子节点
		TreeNode* tmp = pRoot->left;
		pRoot->left = pRoot->right;
		pRoot->right = tmp;
		//对左右子树分别镜像
		if (pRoot->left)
		{
			Mirror(pRoot->left);
		}
		if (pRoot->right)
		{
			Mirror(pRoot->right);
		}
	}
};