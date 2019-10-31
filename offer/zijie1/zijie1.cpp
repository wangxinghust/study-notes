#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;
int main(int argc, char* argv[]) {
	int N;
	cin >> N;
	vector<int> clock(N);
	for (int i = 0; i < N; i++) {
		int hh, mm;
		cin >> hh >> mm;
		clock[N - i - 1] = hh * 60 + mm;
	}
	sort(clock.begin(), clock.end());
	int timeCost;
	cin >> timeCost;
	int hhEnd, mmEnd;
	cin >> hhEnd >> mmEnd;
	int index = N - 1;
	for (; index >= 0; index--) {
		if (clock[index] + timeCost <= hhEnd * 60 + mmEnd)
			break;
	}
	cout << clock[index] / 60 << " " << clock[index] % 60 << endl;
	return 0;
}