#include <iostream>
#include <vector>
using namespace std;

void backtracking(int N, vector<int>& data, int step, int index, vector<bool>& end) {
	if (step == data.size()) {
		if (index >= 1 && index <= N) {
			end[index] = true;
			return;
		}
		else {
			return;
		}
	}
	if (index < 1 || index > N) {
		return;
	}
	backtracking(N, data, step + 1, index - data[step], end);
	backtracking(N, data, step + 1, index + data[step], end);
}

int main() {
	int N, M;
	cin >> N >> M;
	vector<int> data(M);
	for (int i = 0; i < M; i++) {
		cin >> data[i];
	}

	int result = 0;
	vector<bool> end(N + 1, false);
	for (int j = 1; j <= N; j++) {
		backtracking(N, data, 0, j, end);
	}
	for (int i = 1; i <= N; i++) {
		if (end[i]) ++result;
	}

	cout << result << endl;
	return 0;
}