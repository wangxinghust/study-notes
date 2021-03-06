#include "stdafx.h"
#include <vector>
#include <map>
using namespace std;

//��������һ�����ֳ��ֵĴ����������鳤�ȵ�һ�룬���ҳ�������֡���������һ������Ϊ9������{1,2,3,2,2,2,5,4,2}����������2�������г�����5�Σ��������鳤�ȵ�һ�룬������2����������������0��
class Solution {
public:
	int MoreThanHalfNum_Solution(vector<int> numbers) {
		if (numbers.empty())
		{
			return 0;
		}
		else
		{
			size_t half = numbers.size() / 2;
			map<int, size_t> number_count;
			for (size_t i = 0; i < numbers.size(); i++)
			{
				++number_count[numbers[i]];
			}
			for (const auto &n : number_count)
			{
				if (n.second > half)
				{
					return n.first;
				}
			}
			return 0;
		}
	}
};