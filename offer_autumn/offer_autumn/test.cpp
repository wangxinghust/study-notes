#include <cstdio>
#include <vector>
#include <iostream>

using namespace std;
vector<int>g[10];
int ans = 0;
void dfs(int x) {
	if (g[x].size() == 0) {
		ans++;
		return;
	}
	for (int i = 0; i < g[x].size(); ++i) {
		dfs(g[x][i]);
	}
}
int main() {
	int n, x;
	scanf_s("%d", &n);
	for (int i = 2; i <= n; ++i) {
		scanf_s("%d", &x);
		g[x].push_back(i);
	}
	dfs(1);
	cout << ans << endl;
	return 0;
}