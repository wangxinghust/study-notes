#include <cstdio>
class AA {
public:
	int a;
	static void print() {
		std::printf("AA\n");
	}
};

int main() {
	AA x;
	//x.print();
	AA::print();
	return 0;
}

// ��̬�෽�����������ַ�ʽ�� 
// ����������̬������
// ʵ�������󣮾�̬������