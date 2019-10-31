#include "stdafx.h"
#include <stack>
#include <deque>
using namespace std;

//请实现一个函数，用来判断一颗二叉树是不是对称的。注意，如果一个二叉树同此二叉树的镜像是同样的，定义其为对称的。
struct TreeNode {
    int val;
    struct TreeNode *left;
    struct TreeNode *right;
    TreeNode(int x) :
            val(x), left(NULL), right(NULL) {
    }
};

//递归解法 只要pRoot.left和pRoot.right是否对称即可
//左右结点的值相等且对称子树left.left,right.right; left.right,right.left也对称

//非递归解法 利用DFS和BFS
//DFS使用stack保存成对的点，BFS利用Queue保存成对的点
class Solution {
public:
	//深度遍历 DFS
    bool isSymmetrical(TreeNode* pRoot)
    {
		if (pRoot == nullptr) return true;
		stack<TreeNode*> s;
		s.push(pRoot->left);
		s.push(pRoot->right);
		while (!s.empty())
		{
			TreeNode *pRight = s.top();
			s.pop();
			TreeNode *pLeft = s.top();
			s.pop();
			if (!pRight && !pLeft) continue;
			if (!pRight || !pLeft) return false;
			if (pRight->val != pLeft->val) return false;
			//如果左右子树都存在 且左右子结点的值相等 则成对插入
			s.push(pLeft->left);
			s.push(pRight->right);
			s.push(pLeft->right);
			s.push(pRight->left);
		}
		return true;
    }

	//广度遍历 BFS
	bool isSymmetrical1(TreeNode* pRoot)
	{
		if (pRoot == nullptr) return true;
		deque<TreeNode*> s;
		s.push_back(pRoot->left);
		s.push_back(pRoot->right);
		while (!s.empty())
		{
			TreeNode *pRight = s.front();
			s.pop_front();
			TreeNode *pLeft = s.front();
			s.pop_front();
			if (!pRight && !pLeft) continue;
			if (!pRight || !pLeft) return false;
			if (pRight->val != pLeft->val) return false;
			s.push_back(pLeft->left);
			s.push_back(pRight->right);
			s.push_back(pLeft->right);
			s.push_back(pRight->left);

		}
		return true;
	}
};