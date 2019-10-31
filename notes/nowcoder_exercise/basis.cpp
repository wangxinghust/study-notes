#include<stdio.h>
int main()
{
	int s = 0, n;
	for (n = 0; n < 4; n++)
	{
		switch (n) {
		default:s += 4;
		case 1:s += 1; break;
		case 2:s += 2; break;
		case 3:s += 3;
		}
	}
	printf("%d\n", s);
}

//default语句执行完后没有break，于是往下执行s+=1，因而执行了两遍s+=1
//一般default语句写在switch中的末尾