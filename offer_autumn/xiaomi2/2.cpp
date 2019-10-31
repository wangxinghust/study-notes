#include <iostream>
#include <vector>
#include <numeric>
#include <limits>
#include <string>

using namespace std;


/*请完成下面这个函数，实现题目要求的功能
当然，你也可以不按照下面这个模板来作答，完全按照自己的想法来 ^-^
******************************开始写代码******************************/
string solution(string input) {
	auto index = input.find_first_of('(');
	if (index == string::npos) return input;
	string root = input.substr(0, index);
	int i = index + 1;
	int bracket = 0;
	for (; i < input.size(); i++) {
		if (input[i] == '(') bracket++;
		else if (input[i] == ')') bracket--;
		else if (input[i] == ',' && bracket == 0) break;
	}
	//if(i==input.size())
	string left = solution(input.substr(2, i - 2));
	string right = solution(input.substr(i + 1, input.size() - 2 - i));
	string result = left + root + right;
	return result;
}
/******************************结束写代码******************************/


int main() {
	string res;

	string _input;
	getline(cin, _input);

	res = solution(_input);
	cout << res << endl;

	return 0;

}