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
//�������ö�����A��B���ж�B�ǲ���A���ӽṹ����ps������Լ��������������һ�������ӽṹ��
//TODO ���Կ�������������Լ�����������������֤
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