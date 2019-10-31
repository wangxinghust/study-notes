//时间限制：C / C++语言 1000MS；其他语言 3000MS
//内存限制：C / C++语言 65536KB；其他语言 589824KB
//题目描述：
//合唱队的N名学生站成一排且从左到右编号为1到N，其中编号为i的学生身高为Hi。现在将这些学生分成若干组（同一组的学生编号连续），并让每组学生从左到右按身高从低到高进行排列，使得最后所有学生同样满足从左到右身高从低到高（中间位置可以等高），那么最多能将这些学生分成多少组？

#include <iostream>
#include <vector>
using namespace std;
int main() {
	int N;
	cin >> N;
	vector<int> height(N);
	for (int i = 0; i < N; i++) {
		cin >> height[i];
	}

	int index = 0;
	int res = 0;
	while (index < N) {
		if (index + 1 == N || (height[index + 1] != height[index] + 1 && height[index + 1] != height[index] - 1)) {
			++res;
			++index;
			continue;
		}
		if (height[index + 1] == height[index] + 1) {
			while (index + 1 < N && height[index + 1] == height[index] + 1) {
				++index;
			}
			++index;
			++res;
		}
		else {
			while (index + 1 < N && height[index + 1] == height[index] - 1) {
				++index;
			}
			++index;
			++res;
		}
	}

	cout << res << endl;

	return 0;
}

// 好像有点类似 leetcode 581题
// 感觉用排序的方法解比较好理解，与leetcode相比，同时还需维护一个max值，max值与排序数组的值相等时，说明可以分组了
// 排序一波，找没有出现在正确位置的数
// 举例
// 2 6 4 8 10 9 15
// 2 4 6 8 9 10 15
// 2/4 6/8/9 10/15