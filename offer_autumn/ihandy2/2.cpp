#include <iostream>
#include <vector>
#include <unordered_map>
using namespace std;

struct Node {
	int key;
	int area;
	int conti_area;
	Node(int x, int y, int z) :key(x), area(y), conti_area(z) {}
};

int main() {
	int m, n;
	cin >> m >> n;
	vector<vector<int>> data(m, vector<int>(n));
	unordered_map<int, int> area;
	for (int i = 0; i < m; i++) {
		for (int j = 0; j < n; j++) {
			cin >> data[i][j];
			++area[data[i][j]];
		}
	}
	unordered_map<int, int> conti_area;
	vector<vector<int>> dp(m + 1, vector<int>(n + 1, 0));
	for (int i = 1; i < m + 1; i++) {
		if (data[i - 1][0] == data[i][0]) {
			dp[i][0] = dp[i - 1][0] + 1;
		}
		else {
			dp[i][0] = 1;
		}
	}
	for (int j = 1; j < n + 1; j++) {
		if (data[0][j - 1] == data[0][j]) {
			dp[0][j] = dp[0][j - 1] + 1;
		}
		else {
			dp[0][j] = 1;
		}
	}
}