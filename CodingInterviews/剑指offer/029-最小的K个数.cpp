#include "stdafx.h"
#include <vector>
using namespace std;

//����n���������ҳ�������С��K��������������4,5,1,6,2,7,3,8��8�����֣�����С��4��������1,2,3,4,��

//���ڿ�������Ľⷨ
class Solution {
public:
	vector<int> GetLeastNumbers_Solution(vector<int> input, int k) {
		int len = input.size();
		if (len == 0 || k > len || k <= 0)
		{
			return vector<int>();
		}

		int start = 0;
		int end = len - 1;
		int index = Partition(input, start, end);
		while (index != k - 1)
		{
			if (index > k - 1)
			{
				end = index - 1;
				index = Partition(input, start, end);
			}
			else
			{
				start = index + 1;
				index = Partition(input, start, end);
			}
		}
		vector<int> res(input.begin(), input.begin() + k);
		return res;
	}
	//&������
	int Partition(vector<int>& input, int low, int high)
	{
		int pivotkey;
		pivotkey = input[low];
		while (low < high)
		{
			while (low < high&&input[high] >= pivotkey)
			{
				high--;
			}
			input[low] = input[high];
			while (low < high&&input[low] <= pivotkey)
			{
				low++;
			}
			input[high] = input[low];
		}
		input[low] = pivotkey;
		return low;
	}
};