#include <iostream>
#include <vector>
using namespace std;
int main(int argc, char* argv[]) {
	int N, A, X;
	while (cin >> N) {
		cin >> A >> X;
		vector<int> bug(N);
		for (int i = 0; i < N; i++) {
			cin >> bug[i];
		}
		int sum = 0;
		for (int i = 0; i < N; i++) {
			sum += bug[i];
		}
		if (60 * (A * X + 8 - X) < sum) {
			cout << 0 << endl;
			continue;
		}
		if (60 * A * X >= sum) {
			int time = sum % A == 0 ? sum / A : sum / A + 1;
			cout << time << endl;
		}
		else {
			int time = X * 60 + sum - A * X * 60;
			cout << time << endl;			
		}
	}
	return 0;
}