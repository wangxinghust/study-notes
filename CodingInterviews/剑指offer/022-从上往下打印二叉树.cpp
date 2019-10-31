#include "stdafx.h"
#include <vector>
#include <deque>
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
	vector<int> PrintFromTopToBottom(TreeNode* root) {
		vector<int> result;
		if (root == nullptr)
		{
			return result;
		}
		deque<TreeNode*> dequeTreeNode;
		dequeTreeNode.push_back(root);
		while (!dequeTreeNode.empty())
		{
			TreeNode *data = dequeTreeNode.front();
			result.push_back(data->val);
			dequeTreeNode.pop_front();
			if (data->left)
			{
				dequeTreeNode.push_back(data->left);
			}
			if (data->right)
			{
				dequeTreeNode.push_back(data->right);
			}
		}
		return result;
	}
};