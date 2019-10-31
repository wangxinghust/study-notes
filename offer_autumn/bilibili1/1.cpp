#include <iostream>
#include <vector>
#include <string>
#include <algorithm>
using namespace std;
int main() {
	string word1, word2;
	getline(cin, word1);
	getline(cin, word2);

	vector<vector<int>> dp(word1.size() + 1, vector<int>(word2.size() + 1, 0));

	for (int i = 0; i < dp.size(); i++) {
		for (int j = 0; j < dp[0].size(); j++) {
			if (i == 0) {
				dp[i][j] = j;
			}
			else if (j == 0) {
				dp[i][j] = i;
			}
		}
	}

	for (int i = 1; i < dp.size(); i++) {
		for (int j = 1; j < dp[0].size(); j++) {
			if (word1[i - 1] == word2[j - 1]) {
				dp[i][j] = dp[i - 1][j - 1];
			}
			else {
				dp[i][j] = 1 + min(dp[i - 1][j - 1], min(dp[i - 1][j], dp[i][j - 1]));
			}
		}
	}

	cout << dp[word1.size()][word2.size()] << endl;
	return 0;
}

// ac
// leetcode 72. Edit Distance