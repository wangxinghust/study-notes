#include "stdafx.h"

class Solution {
public:
	//backtracking algorithm
	bool hasPath(char* matrix, int rows, int cols, char* str)
	{
		//determines whether it is empty
		if (str == NULL || rows <= 0 || cols <= 0)
		{
			return false;
		}
		//used to mark whether or not it has been accessed
		bool *isOk = new bool[rows*cols]();
		//find a starting point
		for (int i = 0; i < rows; i++)
		{
			for (int j = 0; j < cols; j++)
			{
				if (isHsaPath(matrix, rows, cols, str, isOk, i, j))
				{
					return true;
				}
			}
		}
		//if cannot find, then return false
		return false;
	}
	bool isHsaPath(char *matrix, int rows, int cols, char *str, bool *isOk, int curx,int cury)
	{
		//match to complete
		if (*str == '\0')
		{
			return true;
		}
		//check whether the subscript is in bounds
		if (curx < 0 || curx >= rows || cury < 0 || cury >= cols)
		{
			return false;
		}
		//check whether or not it has been accessed, and compare values to see if they are equal
		if (isOk[curx*cols + cury] || *str != matrix[curx*cols + cury])
		{
			return false;
		}
		//tags it has been accessed
		isOk[curx*cols + cury] = true;
		//test in four directions
		bool sign = isHsaPath(matrix, rows, cols, str + 1, isOk, curx - 1, cury) 
			|| isHsaPath(matrix, rows, cols, str + 1, isOk, curx + 1, cury) 
			|| isHsaPath(matrix, rows, cols, str + 1, isOk, curx, cury - 1) 
			|| isHsaPath(matrix, rows, cols, str + 1, isOk, curx, cury + 1);
		//when test failed, release the tag
		isOk[curx*cols + cury] = false;
		return sign;
	}
};