#include <iostream>

// 判断系统是大端还是小端：通过联合体，因为联合体的所有成员都是从低端地址开始存放
int fun1() {
	union test {
		int i;
		char c;
	};
	test t;
	t.i = 1;
	return (t.c == 1);
}

int main() {
	if (fun1) {
		std::cout << "本机是大端\n";
	}
	else {
		std::cout << "本机是小端\n";
	}
}