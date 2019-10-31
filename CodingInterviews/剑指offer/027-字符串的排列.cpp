#include "stdafx.h"
#include <vector>
#include <algorithm>
#include <string>
using namespace std;

//����һ���ַ���,���ֵ����ӡ�����ַ������ַ����������С����������ַ���abc,���ӡ�����ַ�a,b,c�������г����������ַ���abc,acb,bac,bca,cab��cba��
//����һ���ַ���,���Ȳ�����9(�������ַ��ظ�),�ַ�ֻ������Сд��ĸ��
class Solution {
public:
	vector<string> Permutation(string str) {
		vector<string> array;
		if (str.empty())
		{
			return array;
		}
		Permutation(array, str, 0);
		//���ֵ�������
		sort(array.begin(), array.end());
		return array;
	}
	void Permutation(vector<string> &array, string str, int begin)
	{
		//�ݹ���ֹ�ж�
		if (begin == str.size() - 1)
		{
			array.push_back(str);
		}
		else 
		{
			for (int i = begin; i < str.size(); i++)
			{
				//���ظ��ַ�ʱ������
				if (i != begin && str[i] == str[begin])
				{
					continue;
				}
				//���������
				swap(str[i], str[begin]);
				Permutation(array, str, begin + 1);
				//�ָ�������֮ǰ
				swap(str[i], str[begin]);
			}
		}
	}
};