#include <cstdio>
int main() {
	int val = 5678;
	printf("%x\n", val);
	printf("0x%x\n", val);
	printf("%#x\n", val);
	printf("%#08x\n", val);// ����,��0���
	printf("%8x\n",val);// �ÿո����
	return 0;
}