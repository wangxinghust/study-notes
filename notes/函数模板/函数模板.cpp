#include <iostream>
using namespace std;

template <typename T> // ���庯��ģ��
T max(T x, T y) {// ʹ�����Ͳ���T��ָ�����������͡��β�x��y������
	return x > y ? x : y;
}

int main(int argc, char* argv[]) {
	cout << max(5, 10) << endl;
	cout << max(5.2, 10.2) << endl;
}