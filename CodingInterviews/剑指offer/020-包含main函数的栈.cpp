#include "stdafx.h"
#include <stack>
using namespace std;

//定义栈的数据结构，请在该类型中实现一个能够得到栈中所含最小元素的min函数（时间复杂度应为O（1））。

//解法要点，声明一个min栈，用来同步存储栈中的最小值，一同压入和弹出
class Solution {
public:
	stack<int> m_data, m_min;
	void push(int value) {
		m_data.push(value);
		if (m_min.empty() || value < m_min.top())
		{
			m_min.push(value);
		}
		else
		{
			m_min.push(m_min.top());
		}
	}
	void pop() {
		m_data.pop();
		m_min.pop();
	}
	int top() {
		return m_data.top();
	}
	int min() {
		return m_min.top();
	}
};