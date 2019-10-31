#include <iostream>
#include <vector>
#include <sstream>
#include <queue>
using namespace std;

int shortPath(vector<vector<int>>& data, queue<pair<int, int>>& q, pair<int, int> start, pair<int, int> end, vector<vector<bool>>& visit) {
	int step = 0;
	while (!q.empty()) {
		int len = q.size();
		for (int i = 0; i < len; i++) {
			auto p = q.front();
			int x = p.first, y = p.second;
			if (data[x][y] == 3) return step;
			if (x >= 0 && (data[x][y] == 0 || data[x][y] == 3)) {

			}
		}
		++step;
	}
}

int main() {
	vector<vector<int>> data;

	string line;

	while (getline(cin, line)) {
		int num;
		istringstream record(line);
		vector<int> tmp;
		while (record >> num) {
			tmp.push_back(num);
		}
		data.push_back(tmp);
	}

	int rows = data.size(), cols = rows == 0 ? 0 : data[0].size();

	pair<int, int> start, end;
	for (int i = 0; i < rows; i++) {
		for (int j = 0; j < cols; j++) {
			if (data[i][j] == 2) {
				start.first = i;
				start.second = j;
			}
			else if (data[i][j] == 3) {
				end.first = i;
				end.second = j;
			}
		}
	}

	queue<pair<int, int>> q;
	q.push(start);
	vector<vector<bool>> visit(rows, vector<bool>(cols, false));




	return 0;
}

// 输入为 2表示起点，3表示终点，0表示空地，1表示墙
//2 0 0 1
//0 1 0 1
//1 0 0 0
//3 0 1 0

// 输出最短路径
//7

// bfs可解，类似leetcode 994