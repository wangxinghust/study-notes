#include "stdafx.h"
using namespace std;

//用递归 有个超大的n会溢出 用迭代的方式 或者动态规划
class Solution {
public:
	int Fibonacci(int n) {
		if (n == 0){
			return 0;
		}
		else if (n == 1){
			return 1;
		}
		else{
			int number1 = 0, number2 = 1, result=0;
			for (int i = 2; i <= n; i++)
			{
				result = number1 + number2;
				number1 = number2;
				number2 = result;
			}
			return result;
		}
	}
};