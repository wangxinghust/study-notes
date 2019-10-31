#include "stdafx.h"
#include <vector>
using std::vector;

//��ά�����еĲ���
/*
��һ����ά�����У�ÿ��һά����ĳ�����ͬ����
ÿһ�ж����մ����ҵ�����˳������
ÿһ�ж����մ��ϵ��µ�����˳������
�����һ������������������һ����ά�����һ���������ж��������Ƿ��и�������
*/

class Solution {
public:
	bool Find(int target, vector<vector<int> > array) {
		int row = array.size() - 1;
		int unsigned column = 0;
		while (row >= 0 && column < array[0].size())
		{
			if (target == array[row][column])
			{
				return true;
			}
			else if (target < array[row][column])
			{
				--row;
			}
			else {
				++column;
			}
		}
		return false;
	}
};