#include "stdafx.h"
#include <vector>
#include <algorithm>
#include <string>
using namespace std;

//输入一个字符串,按字典序打印出该字符串中字符的所有排列。例如输入字符串abc,则打印出由字符a,b,c所能排列出来的所有字符串abc,acb,bac,bca,cab和cba。
//输入一个字符串,长度不超过9(可能有字符重复),字符只包括大小写字母。
class Solution {
public:
	vector<string> Permutation(string str) {
		vector<string> array;
		if (str.empty())
		{
			return array;
		}
		Permutation(array, str, 0);
		//按字典序排序
		sort(array.begin(), array.end());
		return array;
	}
	void Permutation(vector<string> &array, string str, int begin)
	{
		//递归终止判断
		if (begin == str.size() - 1)
		{
			array.push_back(str);
		}
		else 
		{
			for (int i = begin; i < str.size(); i++)
			{
				//有重复字符时，跳过
				if (i != begin && str[i] == str[begin])
				{
					continue;
				}
				//交换后遍历
				swap(str[i], str[begin]);
				Permutation(array, str, begin + 1);
				//恢复到交换之前
				swap(str[i], str[begin]);
			}
		}
	}
};