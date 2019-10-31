#include "stdafx.h"
#include <vector>
using namespace std;

class Solution {
private:
	void dfs(int threshold, int rows, int cols, bool *flag, int curx, int cury,int &res)
	{
		if (curx < 0 || curx >= rows || cury < 0 || cury >= cols)
		{
			return;
		}
		if (flag[curx*cols+cury])
		{
			return;
		}
		if (check(curx, cury, threshold))
		{
			res++;
			flag[curx*cols+cury] = true;
			dfs(threshold, rows, cols, flag, curx - 1, cury, res);
			dfs(threshold, rows, cols, flag, curx + 1, cury, res);
			dfs(threshold, rows, cols, flag, curx, cury - 1, res);
			dfs(threshold, rows, cols, flag, curx, cury + 1, res);
		}
	}
	bool check(int curx, int cury, int threshold)
	{
		int sum = 0;
		while (curx != 0)
		{
			sum += curx % 10;
			curx /= 10;
		}
		while (cury != 0)
		{
			sum += cury % 10;
			cury /= 10;
		}
		return sum <= threshold;
	}
public:
	int movingCount(int threshold, int rows, int cols)
	{
		int res = 0;
		bool *flag = new bool[rows*cols];
		memset(flag, false, rows*cols);
		dfs(threshold, rows, cols, flag, 0, 0, res);
		return res;
	}
};