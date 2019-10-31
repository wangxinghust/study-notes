#include <iostream>
#include <vector>
#include <string>
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
	if (x == map.size() - 1) {
		backtracking(map, 0, y, step + 1);
	}
	else {
		backtracking(map, x + 1, y, step + 1);
	}
	if (x == 0) {
		backtracking(map, map.size() - 1, y, step + 1);
	}
	else {
		backtracking(map, x - 1, y, step + 1);
	}
	if (y == map[0].size() - 1) {
		backtracking(map, x, 0, step + 1);
	}
	else {
		backtracking(map, x, y + 1, step + 1);
	}
	if (y == 0) {
		backtracking(map, x, map[0].size() - 1, step + 1);
	}
	else {
		backtracking(map, x, y - 1, step + 1);
	}	
}

int main() {
	int n;
	cin >> n;
	vector<vector<int>> map(n, vector<int>(n, 0));
	int startX, startY, endX, endY;
	for (int i = 0; i < n; i++) {
		string str;
		getline(cin, str);
		for (int j = 0; j < n; j++) {
			if (str[j] == '.') continue;
			else if (str[j] == '#') map[i][j] = -1;
			else if (str[j] == 'S') {
				startX = i;
				startY = j;
			}
			else if (str[j] == 'E') {
				endX = i;
				endY = j;
			}
		}
	}
	backtracking(map, startX, startY, 0);
	if (map[endX][endY] == 0) {
		cout << -1 << endl;
	}
	else {
		cout << map[endX][endY] << endl;
	}
	return 0;
}