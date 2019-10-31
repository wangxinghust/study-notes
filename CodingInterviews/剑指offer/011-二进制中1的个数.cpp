#include "stdafx.h"
#include <iostream>
using namespace std;

class Solution {
public:


	//常规解法
	int  NumberOf2(int n) {
		int count = 0;
		unsigned int flag = 1;
		while (flag){
			if (flag&n){
				++count;
			}
			flag = flag << 1;
		}
		return count;
	}

	int NumberOf1(int n){
		int count = 0;
		while (n){
			++count;
			n = (n - 1)&n;
		}
		return count;
	}
};