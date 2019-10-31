#include <iostream>
#include <string>
#include <vector>
using namespace std;
int main(int argc, char* argv[]) {
	int N, K;
	cin >> N >> K;
	string str;
	cin >> str;
	vector<char> ret(N, '0');
	ret[N - 1] = str[N + K - 2] == '0' ? '0' : '1';
	for (int i = N - 2; i >= 0; i--) {
		ret[i] = str[i + K - 1] == str[i + K] ? '0' : '1';
		if (i <= N - K - 1) {
			ret[i] = ret[i] == ret[i + K] ? '0' : '1';
		}
	}
	string res(ret.begin(), ret.end());
	cout << res << endl;
	return 0;
}