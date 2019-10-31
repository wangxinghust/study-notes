#include <iostream>
#include <vector>
using namespace std;

void backtracking(vector<vector<int>>& map, int x, int y, int step) {
	if (x < 0 || x >= map.size() || y < 0 || y >= map[0].size() || map[x][y] == -1) {
		return;
	}
	if (map[x][y] == 0 || map[x][y] > step) {
		map[x][y] = step;
	}
	else {
		return;
	}
	backtracking(map, x + 1, y, step + 1);
	backtracking(map, x - 1, y, step + 1);
	backtracking(map, x, y + 1, step + 1);
	backtracking(map, x, y - 1, step + 1);
}

int main() {
	int n, m, k;
	cin >> n >> m >> k;
	vector<vector<int>> map(n, vector<int>(m, 0));
	for (int i = 0; i < k; i++) {
		int x, y;
		cin >> x >> y;
		map[x][y] = -1;
	}
	if (map[n - 1][m - 1] == -1) {
		cout << 0 << endl;
		return 0;
	}
	backtracking(map, 0, 0, 0);
	cout << map[n - 1][m - 1] << endl;
	return 0;
}