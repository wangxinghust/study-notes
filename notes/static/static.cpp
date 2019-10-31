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

// 静态类方法调用有两种方式： 
// 类名：：静态方法名
// 实例化对象．静态方法名