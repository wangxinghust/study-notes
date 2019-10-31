#include <iostream>
#include <vector>
#include <string>
#include <unordered_set>
using namespace std;

unordered_set<int> s;
bool isTarget(int n) {
	if (n == 1) {
		return true;
	}
	while (n != 1) {
		int sum = 0;
		while (n) {
			sum = (n % 10) * (n % 10);// 这儿代码写错了，+=写成=了
			n /= 10;
		}
		if (sum == 1) {
			return true;
		}
		else if (s.find(sum) != s.end()) {
			return false;
		}
		else {
			s.insert(sum);
		}
		n = sum;
	}
	return true;
}

int main() {
	int m;
	cin >> m;
	vector<int> data(m);
	for (int i = 0; i < m; i++) {
		cin >> data[i];
	}
	for (int i = 0; i < m; i++) {
		s.clear();
		if (isTarget(data[i])) {
			cout << "true\n";
		}
		else {
			cout << "false\n";
		}
	}
	return 0;
}