#include <iostream>
#include <vector>
#include <numeric>
#include <limits>
#include <string>
#include <algorithm>

using namespace std;


/*请完成下面这个函数，实现题目要求的功能
当然，你也可以不按照下面这个模板来作答，完全按照自己的想法来 ^-^
******************************开始写代码******************************/
string find_longest_num_str(string input) {
	int left = 0, right = 0, maxLen = 0, maxLeft = input.size(), maxRight = input.size();
	while (left < input.size()) {
		while (left < input.size() && (input[left] > '9' || input[left] < '0')) {
			++left;
		}
		right = left;
		while (right < input.size() && (input[right] >= '0' && input[right] <= '9')) {
			++right;
		}
		if (maxLen < right - left) {
			maxLeft = left;
			maxRight = right;
			maxLen = right - left;
		}
		left = right;
	}

	string res = "";
	if (maxLeft < input.size()) {
		for (int i = maxLeft; i < maxRight; i++) {
			res += input[i];
		}
	}
	return res;
}
/******************************结束写代码******************************/


int main() {
	string res;

	string _input;
	getline(cin, _input);

	res = find_longest_num_str(_input);
	cout << res.size() << "/" << res << endl;

	return 0;

}
