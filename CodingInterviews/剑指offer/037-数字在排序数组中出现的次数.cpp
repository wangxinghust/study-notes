#include "stdafx.h"
#include <vector>
using namespace std;

//ͳ��һ�����������������г��ֵĴ�����
class Solution {
public:
	int GetNumberOfK(vector<int> data, int k) {
		int number=0;
		if(!data.empty())
		{
			int first=GetFirstK(data,k,0,data.size()-1);
			int second=GetSecondK(data,k,0,data.size()-1);
			if(first>-1&&second>-1)
			{
				number=second-first+1;
			}
		}
		return number;
	}
	int GetFirstK(vector<int> data,int k,int start,int end)
	{
		if(start>end)
		{
			return -1;
		}
		int middleIndex=(start+end)/2;
		int middleData=data[middleIndex];
		if(middleData==k)
		{
			if((middleIndex>0&&data[middleIndex-1]!=k)||middleIndex==0)
			{
				return middleIndex;
			}
			else
			{
				end=middleIndex-1;
			}			
		}
		else if(middleData>k)
		{
			end=middleIndex-1;
		}
		else
		{			
			start=middleIndex+1;
		}
		return GetFirstK(data,k,start,end);
	}
	int GetSecondK(vector<int> data,int k,int start,int end)
	{
		if(start>end)
		{
			return -1;
		}
		int middleIndex=(start+end)/2;
		int middleData=data[middleIndex];
		if(middleData==k)
		{
			if((middleIndex<data.size()-1&&data[middleIndex+1]!=k)||middleIndex==data.size()-1)
			{
				return middleIndex;
			}
			else
			{
				start=middleIndex+1;
			}									
		}
		else if(middleData>k)
		{
			end=middleIndex-1;
		}
		else
		{
			start=middleIndex+1;
		}
		return GetSecondK(data,k,start,end);		
	}
};

