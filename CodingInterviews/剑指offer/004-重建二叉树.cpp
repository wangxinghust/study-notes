#include "stdafx.h"
#include <vector>
using std::vector;

/*
Definition for binary tree
*/
struct TreeNode {
	int val;
	TreeNode *left;
	TreeNode *right;
	TreeNode(int x) : val(x), left(NULL), right(NULL) {}
};

//输入某二叉树的前序遍历和中序遍历的结果，请重建出该二叉树。假设输入的前序遍历和中序遍历的结果中都不含重复的数字。
//例如输入前序遍历序列{1,2,4,7,3,5,6,8}和中序遍历序列{4,7,2,1,5,3,8,6}，则重建二叉树并返回。

class Solution {
public:
	TreeNode* reConstructBinaryTree(vector<int> pre, vector<int> vin) {
		if (pre.empty() || vin.empty()){
			return nullptr;
		}
		vector<int> left_pre, right_pre, left_vin, right_vin;
		//创建根节点
		TreeNode* head = new TreeNode(pre[0]);
		//找根节点
		int root;
		for (int unsigned i = 0; i < vin.size(); i++)
		{
			if (vin[i] == pre[0]){
				root = i;
				break;
			}
		}
		//构建左子树vector
		for (int i = 0; i < root; i++)
		{
			left_vin.push_back(vin[i]);
			left_pre.push_back(pre[i + 1]);
		}
		//构建右子树vector
		for (int unsigned i = root+1; i < pre.size(); i++)
		{
			right_vin.push_back(vin[i]);
			right_pre.push_back(pre[i]);
		}
		head->left = reConstructBinaryTree(left_pre, left_vin);
		head->right = reConstructBinaryTree(right_pre, right_vin);
		return head;
	}
};