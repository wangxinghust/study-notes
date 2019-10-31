#include <iostream>
#include <map>
#include <vector>
#include <algorithm>
using namespace std;
int main(int argc, char* argv[]) {
	int N;
	while (cin >> N) {
		int P, C;
		cin >> P >> C;
		vector<vector<int>> path(P, vector<int>(3));
		for (int i = 0; i < P; i++) {
			cin >> path[i][0] >> path[i][1] >> path[i][2];
		}
		vector<int> minP(N,INT_MAX);
		minP[0] = 0;
		for (int i = 0; i < P; i++) {
			minP[path[i][1]] = min(minP[path[i][1]], minP[path[i][0]] + path[i][2]);
		}
		int sum = 0;
		for (int i = 0; i < C; i++) {
			int tmp;
			cin >> tmp;
			sum += minP[tmp];
		}
		cout << sum << endl;
	}
	return 0;
}