#include "stdafx.h"
#include <vector>
#include <string> //to_string
#include <algorithm> //sort
using namespace std;

//����һ�����������飬����������������ƴ�������ų�һ��������ӡ��ƴ�ӳ���������������С��һ����������������{3��32��321}�����ӡ���������������ųɵ���С����Ϊ321323��
class Solution {
public:
	string PrintMinNumber(vector<int> numbers) {
		string res = "";
		sort(numbers.begin(), numbers.end(), Compare);
		for (size_t i = 0; i < numbers.size(); i++)
		{
			res += to_string(numbers[i]);
		}
		return res;
	}
	static bool Compare(int a, int b)
	{
		string A = "";
		string B = "";
		A += to_string(a);
		A += to_string(b);
		B += to_string(b);
		B += to_string(a);
		return A < B;
	}
};