#include <iostream>
#include <queue>
#include <vector>
#include <sstream>

using namespace std;

struct Node {
	int val;
	Node* left;
	Node* right;
	Node(int val_) :val(val_), left(NULL), right(NULL) {}
};

bool isNum(string str) {
	stringstream sin(str);
	int d;
	char c;
	if (!(sin >> d))
		return false;
	if (sin >> c)
		return false;

	return true;
}

int s2int(const string& s) {
	stringstream ss;
	ss << s;
	int ret;
	ss >> ret;
	return ret;
}

vector<string> split(const string& s, const string& delmiter) {
	vector<string> result;
	typedef string::size_type string_size;
	string_size i = 0;

	while (i != s.size()) {
		int flag = 0;
		while (i != s.size() && flag == 0) {
			flag = 1;
			for (string_size x = 0; x < delmiter.size(); ++x) {
				if (s[i] == delmiter[x]) {
					++i;
					flag = 0;
					break;
				}
			}
		}

		flag = 0;
		string_size j = i;
		while (j != s.size() && flag == 0) {
			for (string_size x = 0; x < delmiter.size(); ++x) {
				if (s[j] == delmiter[x]) {
					flag = 1;
					break;
				}
			}
			if (flag == 0)
				++j;
		}//end while
		if (i != j) {
			result.push_back(s.substr(i, j - i));
			i = j;
		}
	}
	return result;
}

Node* createBTree(vector<string>& v, int index) {
	Node* node = NULL;

	if (index < v.size()) {
		if (isNum(v[index]) == false) {
			return NULL;
		}
		node = new Node(s2int(v[index]));
		node->left = createBTree(v, index * 2 + 1);
		node->right = createBTree(v, index * 2 + 2);
		return node;
	}
	return node;
}

int levelOrder(Node* root) {
	//ÇëÍê³É´úÂë
	queue<Node*> q;
	int level = 1, maxLevel = 1;
	double average = 0.0;
	if (root) {
		q.push(root);
		average = root->val;
	}
	
	while (!q.empty()) {
		level++;
		int size = q.size();
		double avergeTmp = 0;
		for (int i = 0; i < size; i++) {
			Node* tmp = q.front();
			q.pop();
			if (tmp->left) {
				q.push(tmp->left);
				avergeTmp += tmp->left->val;
			}
			if (tmp->right) {
				q.push(tmp->right);
				avergeTmp += tmp->right->val;
			}
		}
		if (average <= avergeTmp / (double)q.size()) {
			maxLevel = level;
		}
	}
	return maxLevel;
}

int main() {
	string inString;
	int len = 0;
	cin >> inString;
	//vector<string> res = split(inString, " ");
	vector<string> res;
	if (isNum(inString)) {
		len = s2int(inString);
	}
	for (int i = 0; i < len; i++) {
		cin >> inString;
		res.push_back(inString);
	}
	/*
	for (int i = 0; i < res.size(); i++) {
		cout<<res[i]<<"	";
	}
	cout<<endl;
	*/
	Node* root = createBTree(res, 0);

	int ret = levelOrder(root);
	cout << ret << endl;
	return 0;
}

// 60