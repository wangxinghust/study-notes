#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

//void dfs(vector<float>& p, int n, int step, int start, float divide) {
//	if (step <= n) {
//		// Ϊʲô�أ����������ô���ӷ���
//		p[start] += (1.0 - p[start]) * divide;
//		dfs(p, n, step + 1, start - 1, divide * 0.5);
//		dfs(p, n, step + 1, start + 1, divide * 0.5);
//	}
//}
//int main(int argc, char* argv[]) {
//	int n;
//	cin >> n;
//	vector<float> p(2 * n + 1, 0);
//	dfs(p, n, 0, n, 1.0);
//	float ans = 0;
//	for (int i = 0; i < n; i++) {
//		ans += p[i];
//	}
//	ans += 1;
//	for (int i = n + 1; i <= 2 * n; i++) {
//		ans += p[i];
//	}
//	printf("%0.1f", ans);
//	return 0;
//}


// ţ�͸�������dp�ķ������󣬵��ǲ�̫�����

// �п����������ģ������ʵ�

int main() {
	int n;
	while (cin >> n) {
		double ans = 0;
		for (int i = 0; i < 600000; i++) { // ͳ��600000��Σ�1λС���ľ����ǿ��Ա�֤��
			int l = 0, r = 0, p = 0; // l����Ⱦ�����ˣ�r����Ⱦ����Ҷˣ�p�����������˶��ٲ���Ϊ��ʱ�����������ߵ�
			for (int j = 0; j < n; j++) {
				if (rand() & 1) { // ���������������
					p++;
					r = max(r, p);
				} else {
					p--;
					l = min(l, p);
				}
			}
			ans += (r - l + 1);
		}
		printf("%.1lf", ans / 600000);
	}
	return 0;
}