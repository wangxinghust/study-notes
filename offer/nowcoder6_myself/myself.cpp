#include <iostream>
using namespace std;
int main(int argc, char* argv[]) {
	int n;
	cin >> n;
	int count = 1;
	//从后往前遍历，依次设置为N，直到i=2，i=1无需求解，只能为Y
	for (int i = n; i >= 2; i--) {
		int tmp = 1;

		//当第i个数设置为N时，后面能与之整除的数只能设置为N，其他位可设置为Y或N，即乘2

		//for (int j = i + 1; j <= n; j++) {
			//	if (j % i != 0) tmp *= 2;
			//	//防止溢出
			//	tmp %= 1000000007;
		//}

		//修改以提升效率
		//n-i表示j之后有多少个数，(n-i)/i表示能被i整除的数有多少个,相减即为 可以设置为YorN的位的数量
		int size = n - i - (n - i) / i;
		for (int k = 0; k < size; k++) {
			tmp = tmp << 1;//与 tmp*=2 一样；直接写 tmp<<k 会溢出
			//防止溢出
			tmp %= 1000000007;
		}

		count += tmp;
		//防止溢出
		count %= 1000000007;
	}
	cout << count;
	return 0;
}

//错的地方在于2设置为N后，后面除了2的倍数不能设置为Y，其他数也依赖于前面是否有设置为N的，比如3设置为N了，那么6也只能为N了