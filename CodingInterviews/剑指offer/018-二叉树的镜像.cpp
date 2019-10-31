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
//���������Ķ�����������任ΪԴ�������ľ���
class Solution {
public:
	void Mirror(TreeNode *pRoot) {
		//�κ�ʱ�䶼��Ҫ���˿�ָ��ķ��ʣ����ʿ�ָ��ָ��һ����ը��
		if (!pRoot)
		{
			return;
		}
		//���������ӽڵ�
		TreeNode* tmp = pRoot->left;
		pRoot->left = pRoot->right;
		pRoot->right = tmp;
		//�����������ֱ���
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