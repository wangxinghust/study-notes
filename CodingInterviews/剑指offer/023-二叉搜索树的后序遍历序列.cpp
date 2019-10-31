#include "stdafx.h"
#include <vector>
using namespace std;

//输入一个整数数组，判断该数组是不是某二叉搜索树的后序遍历的结果。如果是则输出Yes, 否则输出No。假设输入的数组的任意两个数字都互不相同。

//解法思路 划分左右子序列，递归判断左右子序列是否是二叉搜索树
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