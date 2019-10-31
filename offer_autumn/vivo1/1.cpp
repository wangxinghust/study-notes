#include<iostream>
#include<string>
#include <stack>
using namespace std;

/**
 * Welcome to vivo !
 */

int solution(string str)
{
	int sum = 0;

	// TODO Write your code here
	stack<char> st;
	for (int i = 0; i < str.size(); i++) {
		if (str[i] == '(') {
			++sum;
		}
		else if (str[i] == ')') {
			--sum;
		}
		else break;
	}

	return sum;
}

int main()
{
	string str("");
	getline(cin, str);

	int sum = solution(str);
	cout << sum << endl;
	return 0;
}

//ac