#include <string>
#include <iostream>
#include <iomanip>
using namespace std;

double probability(int red, int blue) {
	// 总的球数不到3个，拿不到红球必输
	if (red + blue < 3) {
		return (double)red / (blue + red);
	}
	// 剩余不到俩蓝球，则拿不到蓝球，必然输
	if (blue <= 1) {
		return (double)red / (blue + red);
	}
	double result = 0.0;
	// 取出红球
	result += (double)red / (blue + red);
	// 分支条件，声明一个变量来保存分支结果
	double tmp = 1.0;
	// A取蓝球
	tmp *= (double)blue / (blue + red);
	--blue;
	// B取蓝球
	tmp *= (double)blue / (blue + red);
	--blue;
	// 开分支，C取蓝球
	if (blue > 0) {
		result += tmp * blue / (blue + red) * probability(red, blue - 1);
	}
	// 开分支，C取红球，红球只剩一个，C取红球，那A必输
	if (red > 1) {
		result += tmp * red / (blue + red) * probability(red - 1, blue);
	}
	return result;
}

int main() {
	int red, blue;
	cin >> red >> blue;
	double result = 0.0;
	int i = 0;
	cout << fixed << setprecision(5) << probability(red, blue) << endl;
	return 0;
}

// 只能跑通45的测试用例