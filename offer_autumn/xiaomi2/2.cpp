#include <iostream>
#include <vector>
#include <numeric>
#include <limits>
#include <string>

using namespace std;


/*������������������ʵ����ĿҪ��Ĺ���
��Ȼ����Ҳ���Բ������������ģ����������ȫ�����Լ����뷨�� ^-^
******************************��ʼд����******************************/
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
/******************************����д����******************************/


int main() {
	string res;

	string _input;
	getline(cin, _input);

	res = solution(_input);
	cout << res << endl;

	return 0;

}