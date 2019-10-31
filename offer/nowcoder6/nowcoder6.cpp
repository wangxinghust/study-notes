#include <bits/stdc++.h>

using namespace std;

const int maxn = 1e6 + 5;
const int mod = 1e9 + 7;
int vis[maxn];

int main() {
	// 每个数都可以分解为若干素数的乘积
	int n;
	// scanf_s("%d", &n);
	n = 10;
	long long ans = 1;
	// 遍历每一个素数
	for (int i = 2; i <= n; i++) {
		// 略过合数
		if (vis[i]) continue;
		// 对此素数，标记之后相应的合数
		for (int j = i + i; j <= n; j += i) 
			vis[j] = 1;
		int tmp = n, cnt = 0;
		// 计算i的多少次方<=n
		while (tmp >= i) 
			tmp /= i, cnt++;
		ans = ans * (cnt + 1) % mod;
	}
	printf("%lld\n", ans);
	return 0;
}