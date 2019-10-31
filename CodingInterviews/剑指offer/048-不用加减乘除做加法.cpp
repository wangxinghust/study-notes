#include "stdafx.h"
using namespace std;

class Solution {
public:
    int Add(int num1, int num2)
    {
        int sum,carry;
        do
        {
            //不考虑进位
            sum=num1^num2;
            //计算进位
            carry=(num1&num2)<<1;

            //为下次循环做准备
            num1=sum;
            num2=carry;
        } while (carry!=0);//没有进位产生则无需计算
        return sum;
    }
};