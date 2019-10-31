#include "stdafx.h"
#include <stack>
using namespace std;

//����ջ�����ݽṹ�����ڸ�������ʵ��һ���ܹ��õ�ջ��������СԪ�ص�min������ʱ�临�Ӷ�ӦΪO��1������

//�ⷨҪ�㣬����һ��minջ������ͬ���洢ջ�е���Сֵ��һͬѹ��͵���
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