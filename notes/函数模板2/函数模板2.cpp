#include <iostream>
using namespace std;
template <typename T> // ����ģ��fun������
T fun(T x, int y);
int main(int argc, char* argv[]) {
	cout << fun(10, 5) << endl;
	cout << fun(10.2, 5) << endl;
}
template <typename T> // ����ģ��fun�Ķ���
T fun(T x, int y) {
	T z; // ����T���͵ı���z
	z = (T)(x + y); // ��x+y�Ľ��ת����T����
	return z;
}