#include <iostream>
#include <stdlib.h>
#include <string.h>
#include <string>
#include <unordered_map>

using namespace std;

/**
 * Welcome to vivo !
 */

#define MAX_NUM 100

int solution(int boxs[], int N)
{
	// TODO Write your code here
	unordered_map<int, int> umap;
	for (int i = 0; i < N; i++) {
		++umap[boxs[i]];
	}
	int result = 0;
	for (auto n : umap) {
		if (n.second >= 2) {
			result += n.second * n.second;
		}
	}
	return result;
}

int main()
{
	string str("");
	getline(cin, str);
	int boxs[MAX_NUM];
	int i = 0;
	char* p;
	int count = 0;

	const char* strs = str.c_str();
	p = strtok((char*)strs, " ");
	while (p)
	{
		boxs[i] = atoi(p);
		count++;
		p = strtok(NULL, " ");
		i++;
		if (i >= MAX_NUM)
			break;
	}

	int num = solution(boxs, count);
	cout << num << endl;
	return 0;
}

// 10