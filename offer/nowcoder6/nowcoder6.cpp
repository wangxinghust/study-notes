#include <bits/stdc++.h>

using namespace std;

const int maxn = 1e6 + 5;
const int mod = 1e9 + 7;
int vis[maxn];

int main() {
	// ÿ���������Էֽ�Ϊ���������ĳ˻�
	int n;
	// scanf_s("%d", &n);
	n = 10;
	long long ans = 1;
	// ����ÿһ������
	for (int i = 2; i <= n; i++) {
		// �Թ�����
		if (vis[i]) continue;
		// �Դ����������֮����Ӧ�ĺ���
		for (int j = i + i; j <= n; j += i) 
			vis[j] = 1;
		int tmp = n, cnt = 0;
		// ����i�Ķ��ٴη�<=n
		while (tmp >= i) 
			tmp /= i, cnt++;
		ans = ans * (cnt + 1) % mod;
	}
	printf("%lld\n", ans);
	return 0;
}