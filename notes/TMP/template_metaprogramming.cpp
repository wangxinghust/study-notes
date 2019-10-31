// 入门例子
#include <iostream>
template<unsigned n>
struct Factorial {
	enum { value = n * Factorial<n - 1>::value };
};

template<>
struct Factorial<0> {
	enum { value = 1 };
};

int main() {
	std::cout << Factorial<5>::value; // 编译期间即计算出来
	std::cout << std::endl;
	std::cout << Factorial<10>::value;
}