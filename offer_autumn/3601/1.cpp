#include <iostream>
#include <string>
#include <unordered_map>
#include <algorithm>
using namespace std;

//int main() {
//	string str;
//	getline(cin, str);
//	unordered_map<string, int> ma;
//
//	int len = str.size();
//	for (int i = 0; i < len; i++) {
//		for (int j = 1; j <= len - i; j++) {
//			++ma[str.substr(i, j)];
//		}
//	}
//	int result = 1;
//	for (auto m : ma) {
//		result = max(result, m.second);
//	}
//	cout << result << endl;
//	return 0;
//}

int main() {
	vector<int> alpha(26, 0);
	string str;
	getline(cin, str);
	
	for (char ch : str) {
		++alpha[ch - 'a'];
	}
	int result = 0;
	for (auto n : alpha) {
		result = max(result, n);
	}

	cout << result << endl;
}