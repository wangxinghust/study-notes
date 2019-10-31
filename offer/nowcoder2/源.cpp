#include <cstdio>
#include <algorithm>

using namespace std;

const int maxn = 1e3 + 5;

int n, m, k, x, y;
int dp[maxn];

int main() {
	scanf("%d%d%d", &n, &m, &k);
	n++;
	for (int i = 1; i <= n; i++) {
		dp[i] = i * k;
	}

	while (m--) {
		scanf("%d%d", &x, &y);
		for (int i = 1; i <= n; i++) {
			if (i - y > 0) {
				dp[i] = min(dp[i], dp[i - y] + x);
			}
			else {
				dp[i] = min(dp[i], x);
			}
		}
	}

	printf("%d\n", dp[n]);

	return 0;
}