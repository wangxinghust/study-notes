#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;

int main(int argc, char* argv[]) {
	int m, n;
	cin >> m >> n;
	vector<int> t(n);
	for (int i = 0; i < n; ++i) {
		cin >> t[i];
	}
	sort(t.begin(), t.end());
	int l = n % m;
	int time = 0;
	if (l == 0) {
		for (int i = 0; i * m < n; i++) {
			time += t[i * m + m - 1];
		}
	}
	else {
		for (int i = 0; i * m < n; i++) {
			time += t[i * m + l - 1];
		}
	}
	cout << time << endl;
}