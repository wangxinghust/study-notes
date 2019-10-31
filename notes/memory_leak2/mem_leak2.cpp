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
	_CrtMemCheckpoint(&s1); // ʹ�õ�ǰ�ڴ�״̬�Ŀ������˽ṹ
	char* str = NULL;
	GetMemory(str, 100);
	_CrtMemCheckpoint(&s2); // �ٴ�ʹ�õ�ǰ�ڴ�״̬�Ŀ������˽ṹ
	if (_CrtMemDifference(&s3, &s1, &s2))
		_CrtMemDumpStatistics(&s2);
	cout << "Memory leak test!\n";
	_CrtDumpMemoryLeaks();// ���ڡ��������������ʾ�ڴ�й©��Ϣ
	return 0;
}