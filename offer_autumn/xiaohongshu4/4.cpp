#include <cstdint>
#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

bool compare(pair<int, int> a, pair<int, int> b) {
	if (a.first == b.first) return a.second < b.second;
	return a.first < b.first;
}

int main() {
	int n;
	cin >> n;
	vector<pair<int, int>> dataXi(n);
	vector<pair<int, int>> dataHi(n);
	for (int i = 0; i < n; i++) {
		int x, y;
		cin >> x >> y;
		dataXi[i] = { x,y };
		dataHi[i] = { y,x };
	}
	sort(dataXi.begin(), dataXi.end(), compare);
	sort(dataHi.begin(), dataHi.end(), compare);
	int indexXi = 0, indexHi = 0;
	int maxXi = 0, maxHi = 0;
	int result = 0;
	while (indexXi < n && indexHi < n) {
		while (indexXi < n && dataXi[indexXi].second < maxHi) {
			++indexXi;
		}
		while (indexHi < n && dataHi[indexHi].second < maxXi) {
			++indexHi;
		}

		if (indexXi < n && indexHi < n && dataXi[indexXi].first == dataHi[indexHi].second && dataXi[indexXi].second == dataHi[indexHi].first) {
			++result;
			maxXi = dataXi[indexXi].first;
			maxHi = dataHi[indexHi].first;
			++indexXi;
			++indexHi;
		}
		else if (indexXi < n && indexHi < n) {
			int lenXi = n;
			for (int i = indexXi; i < n; i++) {
				if (dataXi[i].first == dataHi[indexHi].second && dataXi[i].second == dataHi[indexHi].first) {
					lenXi = i - indexXi;
					break;
				}
			}
			int lenYi = n;
			for (int i = indexHi; i < n; i++) {
				if (dataXi[indexXi].first == dataHi[i].second && dataXi[indexXi].second == dataHi[i].first) {
					lenYi = i - indexHi;
					break;
				}
			}
			if (lenXi <= lenYi && lenXi != n) {
				++result;
				indexXi += lenXi;
				maxXi = dataXi[indexXi].first;
				maxHi = dataHi[indexHi].first;
				++indexXi;
				++indexHi;
			}
			else if (lenXi > lenYi) {
				++result;
				indexHi += lenYi;
				maxXi = dataXi[indexXi].first;
				maxHi = dataHi[indexHi].first;
				++indexXi;
				++indexHi;
			}
		}
	}
	cout << result << endl;
	return 0;
}

//倒卖战利品
//时间限制：C / C++语言 3000MS；其他语言 5000MS
//内存限制：C / C++语言 65536KB；其他语言 589824KB
//题目描述：
//在游戏中，击败魔物后，薯队长获得了N件宝物，接下来得把这些宝物卖给宝物回收员来赚点小钱。
//这个回收员有个坏毛病，每次卖给他一件宝物后，之后他就看不上比这件宝物差的宝物了。
//在这个世界中，衡量宝物的好坏有两个维度，稀有度X和实用度H，回收员在回收一个宝物A后，
//下一个宝物的稀有度和实用度都不能低于宝物A。那么薯队长如何制定售卖顺序，才能卖给回收员宝物总个数最多。

//***输入
//第一行一个正整数N。
//接下来N行。每行两个整数分别表示X 和 H
//X1 H1
//X2 H2
//…
//XN HN
//输入限制：
//对于70% 的数据：
//0 < N < 10 ^ 4
//0 < Xi < 10 ^ 6
//0 < Hi < 10 ^ 6
//对于100 % 的数据：
//0 < N < 10 ^ 6
//0 < Xi < 10 ^ 6
//0 < Hi < 10 ^ 6

//***输出
//一个整数，表示最多可以卖出的宝物数

//***输入
//4
//3 2
//1 1
//1 3
//2 2

//***输出
//3

//***提示
//1. 将宝物2(1, 1)卖出
//2. 将宝物4(2, 2)卖出
//3. 将宝物1(3, 2)卖出