#include <iostream>

// �ж�ϵͳ�Ǵ�˻���С�ˣ�ͨ�������壬��Ϊ����������г�Ա���ǴӵͶ˵�ַ��ʼ���
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
		std::cout << "�����Ǵ��\n";
	}
	else {
		std::cout << "������С��\n";
	}
}