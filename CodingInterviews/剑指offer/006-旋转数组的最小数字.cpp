#include "stdafx.h"
#include <vector>
using std::vector;

class Solution {
public:
	int minNumberInRotateArray(vector<int> rotateArray) {
		if (rotateArray.empty()){
			return 0;
		}
		else{
			int min = rotateArray[0];
			for (size_t i = 0; i < rotateArray.size(); i++)
			{
				if (rotateArray[i] < min){
					return rotateArray[i]; 
				}
			}
			return min;
		}
	}
};

//改进是用二分查找的方法