#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int main() {
	int n;
	cin >> n;
	vector<int> data(n);
	for (int i = 0; i < n; i++) {
		cin >> data[i];
	}

	vector<int> left2right(n,1);
	vector<int> right2left(n,1);
	for (int i = 1; i < n; i++) {
		if (data[i] > data[i - 1]) {
			left2right[i] = left2right[i - 1] + 1;
		}
	}
	for (int i = n - 2; i >= 0; i--) {
		if (data[i] > data[i + 1]) {
			right2left[i] = right2left[i + 1] + 1;
		}
	}

	int sum = 0;
	for (int i = 0; i < n; i++) {
		sum += max(left2right[i], right2left[i]);
	}
	cout << sum << endl;
	return 0;
}

// ac