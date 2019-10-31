#define _CRTDBG_MAP_ALLOC
#include <stdlib.h>
#include <crtdbg.h>

#include <iostream>
using namespace std;

_CrtMemState s1, s2, s3;

void GetMemory(char* p, int num) {
	p = (char*)malloc(sizeof(char) * num);
}

int main() {
	_CrtMemCheckpoint(&s1); // 使用当前内存状态的快照填充此结构
	char* str = NULL;
	GetMemory(str, 100);
	_CrtMemCheckpoint(&s2); // 再次使用当前内存状态的快照填充此结构
	if (_CrtMemDifference(&s3, &s1, &s2))
		_CrtMemDumpStatistics(&s2);
	cout << "Memory leak test!\n";
	_CrtDumpMemoryLeaks();// 将在“输出”窗口中显示内存泄漏信息
	return 0;
}