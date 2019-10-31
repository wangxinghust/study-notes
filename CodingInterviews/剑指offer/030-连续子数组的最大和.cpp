#include "stdafx.h"
#include <vector>
using namespace std;

//HZż������Щרҵ������������Щ�Ǽ����רҵ��ͬѧ����������鿪����,���ַ�����:
//�ڹ��ϵ�һάģʽʶ����,������Ҫ��������������������,������ȫΪ������ʱ��,����ܺý����
//����,��������а�������,�Ƿ�Ӧ�ð���ĳ������,�������Աߵ��������ֲ����أ�
//����:{6,-3,-2,7,-15,1,2,2},����������������Ϊ8(�ӵ�0����ʼ,����3��Ϊֹ)��
//��һ�����飬��������������������еĺͣ���᲻�ᱻ������ס��(�������ĳ���������1)
class Solution {
public:
	int FindGreatestSumOfSubArray(vector<int> array) {
		if (array.empty())
		{
			return 0;
		}
		int sumTmp = 0;
		int sumMax = 0;
		for (size_t i = 0; i < array.size(); i++)
		{
			//�ۼ�Ϊ��ʱ����0�������ۼ�
			sumTmp += array[i];
			if (sumTmp < 0)
			{
				sumTmp = 0;
			}
			if (sumTmp > sumMax)
			{
				sumMax = sumTmp;
			}
		}
		//�������ȫ�Ǹ�������sumMax==0�������������е����ֵ��ֵ��sumMax����
		if (sumMax == 0)
		{
			sumMax = array[0];
			for (size_t i = 0; i < array.size(); i++)
			{
				if (array[i] > sumMax)
				{
					sumMax = array[i];
				}
			}
		}
		return sumMax;
	}
};