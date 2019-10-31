#include <iostream>
#include <vector>
using namespace std;

int main(int argc, char* argv[]) {
	int N = 0;
	cin >> N;
	vector<string> numStr;
	for (int i = 0; i < N; ++i) {
		cin >> numStr[i];
	}
	int boundary[4] = { 0,N - 1,0,N - 1 };
	cout << 4 << endl;
}


//´ð°¸²Î¿¼leetcode 221Ìâ