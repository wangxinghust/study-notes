#include "stdafx.h"
#include <vector>
using std::vector;

class Solution {
public:
	//替换空格
	/*请实现一个函数，将一个字符串中的每个空格替换成“%20”。例如，当字符串为We Are Happy.则经过替换之后的字符串为We%20Are%20Happy。
	*/

	void replaceSpace(char* str, int length) {
		if (str == nullptr || length <= 0)
		{
			return;
		}
		int originalLength = 0;
		int numberBlank = 0;
		int i = 0;
		while (str[i] != '\0')
		{
			++originalLength;
			if (str[i] == ' ')
			{
				++numberBlank;
			}
			++i;
		}
		int newLength = originalLength + numberBlank * 2;
		if (newLength > length)
		{
			return;
		}
		int indexOriginal = originalLength;
		int indexNew = newLength;
		while (indexNew > indexOriginal && indexOriginal >= 0)
		{
			if (str[indexOriginal] == ' ')
			{
				str[indexNew--] = '0';
				str[indexNew--] = '2';
				str[indexNew--] = '%';
			}
			else
			{
				str[indexNew--] = *(str + indexOriginal);
			}
			--indexOriginal;
		}
	}
};