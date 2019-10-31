#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;
int main() {
	int n;
	cin >> n;
	vector<int> data(n);
	for (int i = 0; i < n; i++) {
		cin >> data[i];
	}

	if (data.size() <= 2) return data.size();

	vector<int> toLeft(n);
	for (int i = 0; i < n; i++) {
		int j = i - 1;
		for (; j >= 0; j--) {
			if (data[j] >= data[j + 1])
				break;
		}
		toLeft[i] = i - j - 1;
	}
	vector<int> toRight(n);
	for (int i = 0; i < n; i++) {
		int j = i + 1;
		for (; j < n; j++) {
			if (data[j] <= data[j + 1])
				break;
		}
		toRight[i] = j - i - 1;
	}

	int maxLen = max(1 + toRight[0], 1 + toLeft[data.size() - 1]);
	for (int i = 1; i < data.size() - 1; i++) {
		if (data[i - 1] <= data[i + 1] - 2) {
			maxLen = max(maxLen, toLeft[i] + toRight[i]);
		} else {
			maxLen = max(1 + toRight[i], 1 + toLeft[i]);
		}
	}
	cout << maxLen << endl;
	return 0;
}