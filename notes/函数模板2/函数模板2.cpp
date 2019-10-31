#include <iostream>
using namespace std;
template <typename T> // 函数模板fun的声明
T fun(T x, int y);
int main(int argc, char* argv[]) {
	cout << fun(10, 5) << endl;
	cout << fun(10.2, 5) << endl;
}
template <typename T> // 函数模板fun的定义
T fun(T x, int y) {
	T z; // 定义T类型的变量z
	z = (T)(x + y); // 将x+y的结果转换成T类型
	return z;
}