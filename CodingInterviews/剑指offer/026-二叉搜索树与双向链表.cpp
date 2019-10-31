#include "stdafx.h"
using namespace std;

//����һ�ö��������������ö���������ת����һ�������˫������Ҫ���ܴ����κ��µĽ�㣬ֻ�ܵ������н��ָ���ָ��
struct TreeNode {
	int val;
	struct TreeNode *left;
	struct TreeNode *right;
	TreeNode(int x) :
		val(x), left(NULL), right(NULL) {
	}
};

//ʧ�ܷ��� �����ǿ��Եģ�����©д��һ���С�Ķ�����ע�����ݾ�Ϊ�����
class Solution1 {
public:
	TreeNode* Convert(TreeNode* pRootOfTree)
	{
		if (pRootOfTree == nullptr)
		{
			return nullptr;
		}
		/*if (pRootOfTree->left == nullptr&&pRootOfTree->right == nullptr)
		{
			return pRootOfTree;
		}
		TreeNode *left = Convert(pRootOfTree);
		TreeNode *p = left;
		while (p != nullptr&&p->right != nullptr)
		{
			p = p->right;
		}
		if (left != nullptr)
		{
			p->right = pRootOfTree;
			pRootOfTree->left = p;
		}*/


		TreeNode *pHead = pRootOfTree;
		TreeNode *pLeftMax = nullptr;
		TreeNode *pRightMin = nullptr;
		if (pHead->left)
		{
			while (pHead->left)
			{
				pHead = pHead->left;
			}
		}
		if (pRootOfTree->left)
		{
			//pLeftMax = pRootOfTree; �޸�ǰ
			pLeftMax = pRootOfTree->left;
			while (pLeftMax->right)
			{
				pLeftMax = pLeftMax->right;
			}
		}
		if (pRootOfTree->right)
		{
			//pRightMin = pRootOfTree; �޸�ǰ
			pRightMin = pRootOfTree->right;
			while (pRightMin->left)
			{
				pRightMin = pRightMin->left;
			}
		}
		if (pLeftMax)
		{
			Convert(pRootOfTree->left);
			pLeftMax->right = pRootOfTree;
			pRootOfTree->left = pLeftMax;
		}
		if (pRightMin)
		{
			Convert(pRootOfTree->right);
			pRightMin->left = pRootOfTree;
			pRootOfTree->right = pRightMin;
		}
		return pHead;
	}
};

class Solution {
public:
	TreeNode* Convert(TreeNode* pRootOfTree)
	{
		TreeNode *pLastNodeInList = nullptr;
		ConvertNode(pRootOfTree, pLastNodeInList);

		TreeNode *pHeadOfList = pLastNodeInList;
		while (pHeadOfList != nullptr&&pHeadOfList->left != nullptr)
		{
			pHeadOfList = pHeadOfList->left;
		}
		return pHeadOfList;
	}
	void ConvertNode(TreeNode* pNode, TreeNode* pLastNodeInList)
	{
		if (pNode == nullptr)
		{
			return;
		}
		TreeNode *pCurrent = pNode;
		if (pCurrent->left != nullptr)
		{
			ConvertNode(pCurrent->left, pLastNodeInList);
		}
	}
};