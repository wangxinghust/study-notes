#include <iostream>
#include <vector>
#include <string>
using namespace std;

vector<string> numDecodings(string s) {
	int n = s.size();
	vector<vector<string>> dp(n + 1);
	dp[n].push_back("");
	for (int i = n - 1; i >= 0; i--) {
		if (s[i] != '0') {
			char ch = 'A' + s[i] - '1';
			for (string str : dp[i + 1]) {				
				dp[i].push_back(ch + str);
			}
			if (i < n - 1 && (s[i] == '1' || s[i] == '2' && s[i + 1] < '7')) {
				int offset = 10 * (s[i] - '0') + (s[i + 1] - '0');
				char ch2 = 'A' + offset - 1;
				for (string str : dp[i + 2]) {
					dp[i].push_back(ch2 + str);
				}
			}
		}
	}
	return dp[0];
}

int main() {
	string str;
	getline(cin, str);
	vector<string> result = numDecodings(str);
	for (string str : result) {
		cout << str << endl;
	}
	return 0;
}

// µÚ4Ìâ ac