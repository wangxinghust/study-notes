#include "stdafx.h"
#include <string.h> /* strlen */
#include <math.h>
#include <stdlib.h>  /* atoi */
using namespace std;

//���1~13��������1���ֵĴ���,�����100~1300��������1���ֵĴ�����Ϊ�����ر�����һ��1~13�а���1��������1��10��11��12��13��˹�����6��,
//���Ƕ��ں�����������û���ˡ�ACMerϣ�����ǰ����,������������ձ黯,���Ժܿ���������Ǹ�����������1���ֵĴ�������1 �� n ��1���ֵĴ�������

//TODO:�����ԡ���ָoffer��������д
class Solution {
public:
	int NumberOf1Between1AndN_Solution(int n)
	{
		if (n <= 0)
		{
			return 0;
		}
		char strN[50];
		//Microsoft�Ƽ�ʹ��sprintf_s���sprintf
		sprintf_s(strN, "%d", n);
		return NumberOf1(strN);
	}
	int NumberOf1(const char* strN)
	{
		if (!strN || *strN<'0' || *strN>'9' || *strN == '\0')
		{
			return 0;
		}
		int first = *strN - '0';
		unsigned int length = static_cast<unsigned int>(strlen(strN));
		if (length == 1 && first == 0)
		{
			return 0;
		}
		if (length == 1 && first > 0)
		{
			return 1;
		}
		int numFirstDigit = 0;
		if (first > 1)
		{
			numFirstDigit = static_cast<int>(pow(10, length - 1));
		}
		else if (first == 1)
		{
			//atoi() Parses the C-string str interpreting its content as an integral number, which is returned as a value of type int.
			numFirstDigit = atoi(strN + 1) + 1;
		}
		int numOtherDigits = static_cast<int>(first * (length - 1)*pow(10, length - 2));
		int numRecursive = NumberOf1(strN + 1);
		return numFirstDigit + numOtherDigits + numRecursive;
	}
};