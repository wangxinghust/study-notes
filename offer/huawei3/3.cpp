#include <iostream>
#include <vector>
using namespace std;

void countSteps(int n, int m, vector<vector<int> > nums, int x, int y, int z, int w, int limit, vector<vector<bool> > visited, long long& count)
{
	if (x < 0 || x >= n || y < 0 || y >= m || visited[x][y] || nums[x][y] <= limit)
	{
		return;
	}
	visited[x][y] = true;
	if (x == z && y == w)
	{
		++count;
		return;
	}
	countSteps(n, m, nums, x + 1, y, z, w, nums[x][y], visited, count);
	countSteps(n, m, nums, x - 1, y, z, w, nums[x][y], visited, count);
	countSteps(n, m, nums, x, y + 1, z, w, nums[x][y], visited, count);
	countSteps(n, m, nums, x, y - 1, z, w, nums[x][y], visited, count);
}



int main()
{
	int n, m;
	cin >> n >> m;
	vector<vector<int> > nums;
	vector<vector<bool> >visited;
	for (int i = 0; i < n; ++i)
	{
		vector<int> numsRow;
		vector<bool> visitedRow;
		for (int j = 0; j < m; ++j)
		{
			int tmp;
			cin >> tmp;
			numsRow.push_back(tmp);
			visitedRow.push_back(false);
		}
		nums.push_back(numsRow);
		visited.push_back(visitedRow);
		cin.get();
	}
	int x, y, z, w;
	cin >> x >> y >> z >> w;

	long long count = 0;
	visited[x][y] = true;
	countSteps(n, m, nums, x + 1, y, z, w, nums[x][y], visited, count);
	countSteps(n, m, nums, x - 1, y, z, w, nums[x][y], visited, count);
	countSteps(n, m, nums, x, y + 1, z, w, nums[x][y], visited, count);
	countSteps(n, m, nums, x, y - 1, z, w, nums[x][y], visited, count);
	count %= 1000000000;
	cout << count;
	return 0;
}