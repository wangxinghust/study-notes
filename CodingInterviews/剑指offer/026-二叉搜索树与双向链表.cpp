#include "stdafx.h"
using namespace std;

//输入一棵二叉搜索树，将该二叉搜索树转换成一个排序的双向链表。要求不能创建任何新的结点，只能调整树中结点指针的指向。
struct TreeNode {
	int val;
	struct TreeNode *left;
	struct TreeNode *right;
	TreeNode(int x) :
		val(x), left(NULL), right(NULL) {
	}
};

//失败方案 方案是可以的，但是漏写了一点很小的东西，注释内容均为后添加
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
			//pLeftMax = pRootOfTree; 修改前
			pLeftMax = pRootOfTree->left;
			while (pLeftMax->right)
			{
				pLeftMax = pLeftMax->right;
			}
		}
		if (pRootOfTree->right)
		{
			//pRightMin = pRootOfTree; 修改前
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