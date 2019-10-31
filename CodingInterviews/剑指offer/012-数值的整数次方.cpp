#include "stdafx.h"
using namespace std;


//�����ݽⷨ
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
			curr *= curr;//����
			exponent >>= 1;//����һλ
		}
		return tag>0 ? res : (1 / res);//��ָ�� ������䵹��
	}
};