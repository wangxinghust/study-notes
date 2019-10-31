#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int main() {
	int n, s;
	cin >> n >> s;
	vector<int> data(n);
	for (int i = 0; i < n; i++) {
		cin >> data[i];
	}
	int left = 0, right = 0, len = 0, sum = 0;
	while (left < n) {
		while (right < n) {
			sum += data[right++];
			if (sum <= s) {
				len = max(len, right - left);
			} else {
				break;
			}
		}
		sum -= data[left++];
	}

	cout << len << endl;
	return 0;
}

//ac