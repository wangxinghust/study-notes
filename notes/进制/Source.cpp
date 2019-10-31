#include <cstdio>
int main() {
	int val = 5678;
	printf("%x\n", val);
	printf("0x%x\n", val);
	printf("%#x\n", val);
	printf("%#08x\n", val);// 对齐,用0填充
	printf("%8x\n",val);// 用空格填充
	return 0;
}