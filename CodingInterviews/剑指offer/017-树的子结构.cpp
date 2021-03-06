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
//输入两棵二叉树A，B，判断B是不是A的子结构。（ps：我们约定空树不是任意一个树的子结构）
//TODO 可以考虑先序遍历，以及其他遍历来辅助验证
class Solution {
public:
	bool HasSubtree(TreeNode* pRoot1, TreeNode* pRoot2)
	{
		bool result = false;
		if (pRoot1 != nullptr&&pRoot2 != nullptr)
		{
			if (pRoot1->val == pRoot2->val)
			{
				result = DoseTree1HaveTree2(pRoot1, pRoot2);
			}
			if (!result)
			{
				result = HasSubtree(pRoot1->left, pRoot2);
			}
			if (!result)
			{
				result = HasSubtree(pRoot1->right, pRoot2);
			}
		}
		return result;
	}
	bool DoseTree1HaveTree2(TreeNode* pRoot1, TreeNode* pRoot2)
	{
		if (pRoot2 == nullptr)
		{
			return true;
		}
		if (pRoot1 == nullptr)
		{
			return false;
		}
		if (pRoot1->val != pRoot2->val)
		{
			return false;
		}
		return DoseTree1HaveTree2(pRoot1->left, pRoot2->left) && DoseTree1HaveTree2(pRoot1->right, pRoot2->right);
	}
};