#include <vector>
#include <iostream>
#include <queue>
#include <stack>
using namespace std;

struct TreeNode {
	int val;
	TreeNode* left;
	TreeNode* right;
	TreeNode(int x) :val(x), left(nullptr), right(nullptr) {}
};

int main() {
	int n;
	cin >> n;
	vector<int> data(n);
	for (int i = 0; i < n; i++) {
		cin >> data[i];
	}
	queue<TreeNode*> t;
	TreeNode* root = new TreeNode(data[0]);
	t.push(root);
	int i = 1;
	while (i < n && !t.empty()) {
		TreeNode* left = new TreeNode(data[i]);
		t.push(left);
		++i;
		TreeNode* right = new TreeNode(data[i]);
		++i;
		t.push(right);
		TreeNode* p = t.front();
		t.pop();
		p->left = left;
		p->right = right;
	}

	stack<TreeNode*> s;
	while (root != nullptr || !s.empty()) {
		if (root != nullptr) {
			s.push(root);
			root = root->left;
		}
		else {
			root = s.top();
			cout << root->val << endl;
			s.pop();
			root = root->right;
		}
	}

	return 0;
}