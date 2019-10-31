#include "stdafx.h"
#include <vector>
using namespace std;

//����һ�����󣬰��մ���������˳ʱ���˳�����δ�ӡ��ÿһ�����֣����磬
//�����������4 X 4���� 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 �����δ�ӡ������1,2,3,4,8,12,16,15,14,13,9,5,6,7,11,10.
class Solution {
public:
	vector<int> printMatrix(vector<vector<int> > matrix) {
		vector<int> result;
		if (matrix.empty())
		{
			return result;
		}
		else
		{
			int indexRowStart = 0;
			int indexColumnStart = 0;
			int indexRowEnd = matrix.size() - 1;
			int indexColumnEnd = matrix[0].size() - 1;
			int num = (indexRowEnd + 1)*(indexColumnEnd + 1);
			int i = 0;
			int indexRow;
			int indexColumn;
			while ((indexRowStart <= indexRowEnd) && (indexColumnStart <= indexColumnEnd))
			{
				for (indexRow = indexRowStart,indexColumn=indexColumnStart; indexColumn<=indexColumnEnd; indexColumn++)
				{
					result.push_back(matrix[indexRow][indexColumn]);
				}
				indexRowStart++;
				if (indexRowEnd < indexRowStart)
				{
					return result;
				}
				else
				{
					for (indexRow = indexRowStart, indexColumn = indexColumnEnd; indexRow <= indexRowEnd; indexRow++)
					{
						result.push_back(matrix[indexRow][indexColumn]);
					}
					indexColumnEnd--;
				}
				if (indexColumnEnd < indexColumnStart)
				{
					return result;
					
				}
				else
				{
					for (indexRow = indexRowEnd, indexColumn = indexColumnEnd; indexColumn >= indexColumnStart; indexColumn--)
					{
						result.push_back(matrix[indexRow][indexColumn]);
					}
					indexRowEnd--;
				}
				if (indexRowEnd < indexRowStart)
				{
					return result;
				}
				else
				{
					for (indexRow = indexRowEnd, indexColumn = indexColumnStart; indexRow >= indexRowStart; indexRow--)
					{
						result.push_back(matrix[indexRow][indexColumn]);
					}
					indexColumnStart++;
				}
			}
		}
		//����result�������������֧�ṹһ��������������費��Ҫ����ֵ
		return result;
	}
};