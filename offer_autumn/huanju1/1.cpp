#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int main() {
	int value;
	cin >> value;
	int n;
	cin >> n;
	vector<int> size(n);
	for (int i = 0; i < n; i++) {
		cin >> size[i];
	}
	vector<int> satisfy(n);
	for (int i = 0; i < n; i++) {
		cin >> satisfy[i];
	}
	vector<vector<int>> dp(n + 1, vector<int>(value, 0));
	for (int i = 1; i <= n; i++) {
		for (int j = 1; j <= value; j++) {
			if (size[i] > j) {
				dp[i][j] = dp[i - 1][j];
			}
			else {
				dp[i][j] = max(dp[i - 1][j], dp[i - 1][j - size[i]] + satisfy[i]);
			}
		}
	}
	cout << dp[n][value] << endl;
	return 0;
}

// 貌似两题通过的用例都很少