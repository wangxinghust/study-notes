#include "stdafx.h"
#include <string>
using namespace std;

//��һ���ַ���(0<=�ַ�������<=10000��ȫ������ĸ���)���ҵ���һ��ֻ����һ�ε��ַ�,����������λ��, ���û���򷵻� -1����Ҫ���ִ�Сд��
class Solution {
public:
	int FirstNotRepeatingChar(string str) {
		if (str.empty())
		{
			return -1;
		}
		int hash[256] = { 0 };
		int i = 0;
		while (str[i] != '\0')
		{
			hash[str[i]]++;
			++i;
		}
		i = 0;
		//第二遍遍历的依旧是字符串
		while (str[i] != '\0')
		{
			if (1 == hash[str[i]])
			{
				return i;
			}
			++i;
		}
		return -1;
	}
};