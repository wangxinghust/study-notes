#include "stdafx.h"
using namespace std;


//快速幂解法
class Solution {
public:
	double Power(double base, int exponent) {
		double res = 1, curr = base, tag = 1;
		if (exponent < 0)
		{
			if (base == 0){
				return 0;
			}
			exponent = -exponent;
			tag = -1;
		}
		else if (exponent == 0){
			return 1;
		}
		while (exponent){
			if ((exponent & 1) == 1)
			{
				res *= curr;
			}
			curr *= curr;//翻倍
			exponent >>= 1;//右移一位
		}
		return tag>0 ? res : (1 / res);//负指数 则输出其倒数
	}
};