#include "stdafx.h"
#include <vector>
using namespace std;

//����һ���������飬�жϸ������ǲ���ĳ�����������ĺ�������Ľ��������������Yes, �������No���������������������������ֶ�������ͬ��

//�ⷨ˼· �������������У��ݹ��ж������������Ƿ��Ƕ���������
class Solution {
public:
	bool VerifySquenceOfBST(vector<int> sequence) {
		if (sequence.empty())
		{
			return false;
		}
		int root = sequence[sequence.size() - 1];
		int i = 0;
		vector<int> left, right;
		while ((i < sequence.size()-1)&&(sequence[i]<=root))
		{
			left.push_back(sequence[i]);
			++i;
		}
		while ((i < sequence.size() - 1) && (sequence[i] >= root))
		{
			right.push_back(sequence[i]);
			++i;
		}
		if (i < sequence.size() - 1)
		{
			return false;
		}
		bool leftSequence = true;
		if (!left.empty())
		{
			leftSequence = VerifySquenceOfBST(left);
		}
		bool rightSequence = true;
		if (!right.empty())
		{
			rightSequence = VerifySquenceOfBST(right);
		}
		return (leftSequence&&rightSequence);
	}
};