#include <iostream>
using namespace std;
int main() {
	int num;
	cin >> num;
	int count = 0;
	for (int i = 1; i <= num; i++) {
		int up = 2 * num + i - i * i;
		if (up <= 0) break;
		int down = 2 * i;
		if (up % down == 0) {
			++count;
		}
	}
	cout << count << endl;
	return 0;
}

//90
// leetcode 829. Consecutive Numbers Sum