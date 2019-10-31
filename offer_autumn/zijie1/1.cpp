#include <iostream>
#include <vector>
using namespace std;
int main() {
	int n;
	cin >> n;
	vector<int> data(n);
	for (int i = 0; i < n; i++) {
		cin >> data[i];
	}
	vector<int> step(n, 0);
	for (int i = 0; i < n; i++) {
		int height = data[i];
		for (int j = i - 1; j >= 0; --j) {
			if (data[j] >= height) {
				++step[j];
				break;
			}
		}
	}
	int result = data[0];
	int maxI = 0;
	for (int i = 1; i < n; i++) {
		if (step[i] > step[maxI]) {
			maxI = i;
			result = data[i];
		}
	}
	cout << result << endl;
	return 0;
}

// µÚÒ»Ìâ ac