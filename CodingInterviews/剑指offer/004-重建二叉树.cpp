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

//����ĳ��������ǰ���������������Ľ�������ؽ����ö����������������ǰ���������������Ľ���ж������ظ������֡�
//��������ǰ���������{1,2,4,7,3,5,6,8}�������������{4,7,2,1,5,3,8,6}�����ؽ������������ء�

class Solution {
public:
	TreeNode* reConstructBinaryTree(vector<int> pre, vector<int> vin) {
		if (pre.empty() || vin.empty()){
			return nullptr;
		}
		vector<int> left_pre, right_pre, left_vin, right_vin;
		//�������ڵ�
		TreeNode* head = new TreeNode(pre[0]);
		//�Ҹ��ڵ�
		int root;
		for (int unsigned i = 0; i < vin.size(); i++)
		{
			if (vin[i] == pre[0]){
				root = i;
				break;
			}
		}
		//����������vector
		for (int i = 0; i < root; i++)
		{
			left_vin.push_back(vin[i]);
			left_pre.push_back(pre[i + 1]);
		}
		//����������vector
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