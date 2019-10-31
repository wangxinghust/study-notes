#include <iostream>
using namespace std;

template <typename T> // 定义函数模板
T max(T x, T y) {// 使用类型参数T来指定函数的类型、形参x和y的类型
	return x > y ? x : y;
}

int main(int argc, char* argv[]) {
	cout << max(5, 10) << endl;
	cout << max(5.2, 10.2) << endl;
}