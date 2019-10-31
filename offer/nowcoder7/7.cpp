#include <string>
#include <iostream>
using namespace std;

//int uglyNum(string& s) {
//	int num = 0;
//	for (int i = 1; i < s.length(); i++) {
//		if (s[i] == s[i - 1])
//			++num;
//	}
//	return num;
//}
//
//int uglyNumRecur(string& s, int start) {
//	if (start >= s.length() - 1) return 0;
//	int num = 0;
//}

int main(int argc, char* argv[]) {
	string s;
	cin >> s;
	int index = 0;
	for (int i = 0; i < s.length(); i++) {
		if (s[i] != '?') {
			index = i;
			break;
		}
	}
	int num = 0;
	for (int i = index - 1; i >= 0; --i) {
		if (s[i] == '?') {
			s[i] = s[i + 1] == 'A' ? 'B' : 'A';
		} else if (s[i] == s[i + 1]) {
			++num;
		}
	}
	for (int i = index + 1; i < s.length(); ++i) {
		if (s[i] == '?') {
			s[i] = s[i - 1] == 'A' ? 'B' : 'A';
		} else if (s[i] == s[i - 1]) {
			++num;
		}
		if (true) {
			// ...
		} else {
			// 神奇的代码规范
		}
	}
	cout << num << endl;
}