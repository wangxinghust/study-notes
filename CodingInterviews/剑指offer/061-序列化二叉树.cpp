#include "stdafx.h"
#include <string>
#include <deque>
using namespace std;


struct TreeNode {
	int val;
	struct TreeNode* left;
	struct TreeNode* right;
	TreeNode(int x) :
		val(x), left(NULL), right(NULL) {
	}
};
//请实现两个函数，分别用来序列化和反序列化二叉树
class Solution {
public:
	//Error	C4996	 'strdup': The POSIX name for this item is deprecated. Instead, use the ISO C and C++ conformant name: _strdup. See online help for details.
	//添加strup函数来解决上述报错
	char* strdup(const char* src) {
		char* dst = (char*)malloc(strlen(src) + 1);  // Space for length plus nul
		if (dst == NULL) return NULL;          // No memory
		//strcpy(dst, src);                      // Copy the characters
		strcpy_s(dst, strlen(src + 1), src);
		return dst;                            // Return the new string
	}

	char* Serialize(TreeNode* root) {
		string s;
		if (!root)
			return NULL;
		deque<TreeNode*> q;
		q.push_back(root);
		//sequence traversal by deque
		while (!q.empty()) {
			int n = q.size();
			for (int i = 0; i < n; ++i) {
				//if it is a leaf node, store two null pointers
				if (q.front()) {
					q.push_back(q.front()->left);
					q.push_back(q.front()->right);
					//to_string(): Convert numerical value to string
					s += to_string(q.front()->val) + ' ';
				}
				else {
					s += "# ";
				}
				q.pop_front();
			}
		}
		//c_str(): Get C string equivalent
		//strdup(): It tries to allocate enough memory to hold the old string (plus a '\0' character to mark the end of the string).
		char* chr = strdup(s.c_str());
		return  chr;
	}
	TreeNode* Deserialize(char* str) {
		if (!str)
			return nullptr;
		int k = 0;
		auto ret = nextNode(str, k);
		deque<TreeNode*> q;
		q.push_back(ret);
		//also sequence traversal by deque
		while (!q.empty()) {
			int n = q.size();
			for (int i = 0; i < n; ++i) {
				//store to take
				q.front()->left = nextNode(str, k);
				q.front()->right = nextNode(str, k);
				if (q.front()->left)
					q.push_back(q.front()->left);
				if (q.front()->right)
					q.push_back(q.front()->right);
				q.pop_front();
			}
		}
		return ret;
	}
	TreeNode* nextNode(char* str, int& i) {
		string s;
		//not to the end & not blank
		while (str[i] != '\0' && str[i] != ' ') {
			//if '#', return nullptr
			if (str[i] == '#') {
				i += 2;
				return nullptr;
			}
			//get the value of the node
			s += str[i];
			i++;
		}
		if (str[i] == ' ')
			i++;
		if (!s.empty())
			//stoi(): Convert string to integer
			return new TreeNode(stoi(s));
		return nullptr;
	}
};