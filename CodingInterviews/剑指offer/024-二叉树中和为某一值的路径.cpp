#include "stdafx.h"
#include <vector>
using namespace std;

//输入一颗二叉树的根节点和一个整数，打印出二叉树中结点值的和为输入整数的所有路径。
//路径定义为从树的根结点开始往下一直到叶结点所经过的结点形成一条路径。(注意: 在返回值的list中，数组长度大的数组靠前)
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
	vector<vector<int> > FindPath(TreeNode* root, int expectNumber) {
		vector<vector<int> > ret;
		vector<int> trace;
		if (root)
		{
			dfs(root, expectNumber, ret, trace);
		}
		return ret;
	}
	void dfs(TreeNode* root, int s, vector<vector<int> > &ret, vector<int> &trace)
	{
		trace.push_back(root->val);
		//如果是叶节点，则判断路径和是否和输入值相等
		if (!root->left&&!root->right)
		{
			if (s == root->val)
			{
				ret.push_back(trace);
			}
		}
		//如果不是叶节点，则遍历它的子节点
		if (root->left)
		{
			dfs(root->left, s - root->val, ret, trace);
		}
		if (root->right)
		{
			dfs(root->right, s - root->val, ret, trace);
		}
		//在返回父节点之前，在路径上删除当前结点
		trace.pop_back();
	}
};