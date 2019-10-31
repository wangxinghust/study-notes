#define _CRTDBG_MAP_ALLOC
#include <stdlib.h>
#include <crtdbg.h>

#include <iostream>
using namespace std;

void GetMemory(char* p, int num) {
	p = (char*)malloc(sizeof(char) * num);
}

int main() {
	char* str = NULL;
	GetMemory(str, 100);
	cout << "Memory leak test!\n";
	_CrtDumpMemoryLeaks();
	return 0;
}