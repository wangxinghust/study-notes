#include "stdafx.h"
#include <vector>
using namespace std;


//���Ʋ�������
class Solution {
public:
	void reOrderArray(vector<int> &array) {
		vector<int> oddArray;
		vector<int> evenArray;
		for (size_t i = 0; i < array.size(); i++)
		{

			array[i] & 1 ? oddArray.push_back(array[i]) : evenArray.push_back(array[i]);//λ���� ��ż�ж�
		}
		for (size_t i = 0; i < oddArray.size(); i++)
		{
			array[i] = oddArray[i];
		}
		for (size_t i = 0; i < evenArray.size(); i++)
		{
			array[i + oddArray.size()] = evenArray[i];
		}
	}
};