#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

//void dfs(vector<float>& p, int n, int step, int start, float divide) {
//	if (step <= n) {
//		// 为什么呢？这个概率怎么个加法呢
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


// 牛客给的是用dp的方法来求，但是不太好理解

// 有看到用随机化模拟求概率的

int main() {
	int n;
	while (cin >> n) {
		double ans = 0;
		for (int i = 0; i < 600000; i++) { // 统计600000万次，1位小数的精度是可以保证的
			int l = 0, r = 0, p = 0; // l代表染红的左端，r代表染红的右端，p代表向右走了多少步，为负时，代表向左走的
			for (int j = 0; j < n; j++) {
				if (rand() & 1) { // 随机生成向左向右
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