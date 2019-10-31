#include <iostream>
#include <cstdio>
#include <cstdlib>
#include <vector>
#include <algorithm>

using namespace std;

/*
* Welcome to vivo !
*/

int getCountOfApp(const char* input) {
	if (NULL == input) {
		return 0;
	}
	int cnt = 0;
	for (int i = 0; input[i] != 0; ++i) {
		if (input[i] == ',') {
			++cnt;
		}
	}
	return cnt / 2;
}

//id start from 0
int getPositionOfApp(const char* input, const int id) {
	int cntOfComma = id * 2 + 1;
	int i = 0;
	for (; input[i] != 0 && cntOfComma != 0; ++i) {
		if (input[i] == ',') {
			--cntOfComma;
		}
	}
	while (input[--i] != ' ' && input[i] != '#');
	return i + 1;
}

#define APP_MAX 1000
#define DP_MAX 2048
int disks[APP_MAX];
int mems[APP_MAX];
int users[APP_MAX];
int dp[DP_MAX * DP_MAX];

int solution(const char* input) {
	const int countOfApp = getCountOfApp(input);
	if (0 == countOfApp) {
		return 0;
	}
	int res = 0;

	int disk = 0;
	int mem = 0;

	sscanf(input, "%d %d", &disk, &mem);

	for (int i = 0; i < countOfApp; ++i) {
		const int pos = getPositionOfApp(input, i);
		sscanf(input + pos, "%d,%d,%d", &disks[i], &mems[i], &users[i]);
	}

	// TODO Write your code here!
	vector<vector<vector<int>>> dp2(countOfApp + 1, vector<vector<int>>(disk + 1, vector<int>(mem + 1, 0)));
	for (int i = 1; i < countOfApp + 1; i++) {
		for (int j = 1; j < disk + 1; j++) {
			for (int k = 1; k < mem + 1; k++) {
				if (j - disks[i - 1] >= 0 && k - mems[i - 1] >= 0) {
					dp2[i][j][k] = max(dp2[i - 1][j][k], dp2[i - 1][j - disks[i - 1]][k - mems[i - 1]] + users[i - 1]);
				}
				else {
					dp2[i][j][k] = dp2[i - 1][j][k];
				}
			}
		}
	}
	res = dp2[countOfApp][disk][mem];

	return res;
}

int main(int argc, char* args[])
{
	char input[10000];
	cin.getline(input, 10000);
	cout << solution(input) << endl;
}

// ac