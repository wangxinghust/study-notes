#include <iostream>
using namespace std;

// 求100/n
int Div(int n) {
	// 检查异常：如果n<=0，则属于异常情况
	if (n <= 0) {
		// 异常处理流程：抛出异常，然后退出当前函数的执行
		throw(-1);
	}
	// 如果没有异常，则执行如下的正常处理流程
	return (100 / n);
}

int main(int argc, char* argv[]) {
	// 定义变量N，保存键盘输入的人数
	int N;
	cin >> N;
	try {
		// 调用函数Div进行除法运算
		int result = Div(N);
		// 显示100 ÷ N 的结果
		cout << "100÷" << N << "=" << result << endl;
	}
	// 捕获int型异常
	catch(int x){
		// 向用户显示错误信息
		cout << "输入人数时必须为正整数" << endl;
		cout << "异常的详细信息" << x << endl;
	}
	// 捕获任意类型的异常
	catch (...) {
		// 向用户显示错误信息
		cout << "发生了其他异常" << endl;
	}
	return 0;
}