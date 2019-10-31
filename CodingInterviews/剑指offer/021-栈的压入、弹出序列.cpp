#include "stdafx.h"
#include <stack>
#include <vector>
using namespace std;

//输入两个整数序列，第一个序列表示栈的压入顺序，请判断第二个序列是否可能为该栈的弹出顺序。
//假设压入栈的所有数字均不相等。例如序列1, 2, 3, 4, 5是某栈的压入顺序，
//序列4, 5, 3, 2, 1是该压栈序列对应的一个弹出序列，但4, 3, 5, 1, 2就不可能是该压栈序列的弹出序列。（注意：这两个序列的长度是相等的）

class Solution {
public:
	bool IsPopOrder(vector<int> pushV, vector<int> popV) {
		//空值判断
		if (pushV.empty() || popV.empty())
		{
			return false;
		}
		//临时栈
		stack<int> tmp;
		int i = 0, j = 0;
		while (i < pushV.size())
		{
			//按压入顺序往栈里增加一个
			tmp.push(pushV[i++]);
			//循环判断栈顶和弹出序列是否值相等
			while (j < popV.size() && !tmp.empty() && tmp.top() == popV[j])
			{
				//相等则弹出栈中元素，弹出序列index+1
				tmp.pop();
				j++;
			}
		}
		return tmp.empty();
	}
};