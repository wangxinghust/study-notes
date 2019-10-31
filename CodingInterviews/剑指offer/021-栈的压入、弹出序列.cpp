#include "stdafx.h"
#include <stack>
#include <vector>
using namespace std;

//���������������У���һ�����б�ʾջ��ѹ��˳�����жϵڶ��������Ƿ����Ϊ��ջ�ĵ���˳��
//����ѹ��ջ���������־�����ȡ���������1, 2, 3, 4, 5��ĳջ��ѹ��˳��
//����4, 5, 3, 2, 1�Ǹ�ѹջ���ж�Ӧ��һ���������У���4, 3, 5, 1, 2�Ͳ������Ǹ�ѹջ���еĵ������С���ע�⣺���������еĳ�������ȵģ�

class Solution {
public:
	bool IsPopOrder(vector<int> pushV, vector<int> popV) {
		//��ֵ�ж�
		if (pushV.empty() || popV.empty())
		{
			return false;
		}
		//��ʱջ
		stack<int> tmp;
		int i = 0, j = 0;
		while (i < pushV.size())
		{
			//��ѹ��˳����ջ������һ��
			tmp.push(pushV[i++]);
			//ѭ���ж�ջ���͵��������Ƿ�ֵ���
			while (j < popV.size() && !tmp.empty() && tmp.top() == popV[j])
			{
				//����򵯳�ջ��Ԫ�أ���������index+1
				tmp.pop();
				j++;
			}
		}
		return tmp.empty();
	}
};