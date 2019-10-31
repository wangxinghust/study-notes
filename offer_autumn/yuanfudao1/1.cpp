#include <iostream>
#include <vector>
using namespace std;
int main() {
	int n, m;
	cin >> n >> m;
	vector<vector<int>> data(n, vector<int>(m));
	for (int i = 0; i < n; i++) {
		for (int j = 0; j < m; j++) {
			cin >> data[i][j];
		}
	}

	int startRow = 0, startCol = 0, endRow = n - 1, endCol = m - 1;
	while (startRow <= endRow & startCol <= endCol) {
		for (int i = startRow; i <= endRow; i++) {
			cout << data[i][startCol]<<" ";
		}
		++startCol;
		for (int j = startCol; j <= endCol; j++) {
			cout << data[endRow][j] << " ";
		}
		--endRow;
		for (int i = endRow; i >= startRow; i--) {
			cout << data[i][endCol] << " ";
		}
		--endCol;
		for (int j = endCol; j >= startCol; j--) {
			cout << data[startRow][j] << " ";
		}
		++startRow;
	}
	return 0;
}

//90