#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int main() {
	int rows, cols;
	cin >> rows >> cols;
	vector<vector<int>> data(rows, vector<int>(cols));
	for (int i = 0; i < rows; i++) {
		for (int j = 0; j < cols; j++) {
			cin >> data[i][j];
		}
	}

	for (int j = 1; j < cols; j++) {
		data[0][j] += data[0][j - 1];
	}
	for (int i = 1; i < rows; i++) {
		data[i][0] += data[i - 1][0];
	}
	for (int i = 1; i < rows; i++) {
		for (int j = 1; j < cols; j++) {
			data[i][j] += min(data[i - 1][j], data[i][j - 1]);
		}
	}

	cout << data[rows - 1][cols - 1] << endl;
	return 0;
}

// ac