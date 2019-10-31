#include <cstdio>
#include <cstring>

using namespace std;

const int maxn = 1e3 + 5;

int n, m;
int num[maxn][maxn];
int mp[maxn][maxn];
int x, y;
int a1, b1, a2, b2;

int main() {
	memset(num, 0, sizeof(num));
	memset(mp, 0, sizeof(mp));
	scanf("%d", &n);
	for (int i = 0; i < n; i++) {
		scanf("%d%d", &x, &y);
		mp[x][y]++;
	}

	for (int i = 1; i < maxn; i++) {
		for (int j = 1; j < maxn; j++) {
			num[i][j] = num[i - 1][j] + num[i][j - 1] - num[i - 1][j - 1] + mp[i][j];
		}
	}

	scanf("%d", &m);
	for (int i = 0; i < m; i++) {
		scanf("%d%d%d%d", &a1, &b1, &a2, &b2);
		printf("%d\n", num[a2][b2] - num[a2][b1 - 1] - num[a1 - 1][b2] + num[a1 - 1][b1 - 1]);// -1的重要性
	}

	return 0;
}

// 以上ac，考察点在于使用dp去存储数据，查询复杂度为O(1)，而不是每次查询重新计算

//未修改前，已提交 case通过率60%
//#include <iostream>
//#include <cstdio>
//#include <vector>
//
//using namespace std;
//
//int main() {
//	int n, m;
//	vector<vector<int> > position;
//	vector<vector<int> > question;
//	cin >> n;
//	for (int i = 0; i < n; i++) {
//		int x, y;
//		scanf("%d%d", &x, &y);
//		position.push_back(vector<int>{x, y});
//	}
//	cin >> m;
//	for (int i = 0; i < m; i++) {
//		int a1, b1, a2, b2;
//		scanf("%d%d%d%d", &a1, &b1, &a2, &b2);
//		question.push_back(vector<int>{a1, b1, a2, b2});
//	}
//	vector<int> count;
//	for (int i = 0; i < m; i++) {
//		count.push_back(0);
//	}
//	for (int i = 0; i < m; i++) {
//		for (int j = 0; j < n; j++) {
//			if (position[j][0] >= question[i][0] && position[j][0] <= question[i][2] && position[j][1] >= question[i][1] && position[j][1] <= question[i][3]) {
//				count[i]++;
//			}
//		}
//	}
//	for (int i = 0; i < m; i++) {
//		cout << count[i] << endl;
//	}
//	return 0;
//}