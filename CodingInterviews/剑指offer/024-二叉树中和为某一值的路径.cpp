#include "stdafx.h"
#include <vector>
using namespace std;

//����һ�Ŷ������ĸ��ڵ��һ����������ӡ���������н��ֵ�ĺ�Ϊ��������������·����
//·������Ϊ�����ĸ���㿪ʼ����һֱ��Ҷ����������Ľ���γ�һ��·����(ע��: �ڷ���ֵ��list�У����鳤�ȴ�����鿿ǰ)
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
		//�����Ҷ�ڵ㣬���ж�·�����Ƿ������ֵ���
		if (!root->left&&!root->right)
		{
			if (s == root->val)
			{
				ret.push_back(trace);
			}
		}
		//�������Ҷ�ڵ㣬����������ӽڵ�
		if (root->left)
		{
			dfs(root->left, s - root->val, ret, trace);
		}
		if (root->right)
		{
			dfs(root->right, s - root->val, ret, trace);
		}
		//�ڷ��ظ��ڵ�֮ǰ����·����ɾ����ǰ���
		trace.pop_back();
	}
};