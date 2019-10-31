//使用异常类 类类型的异常可以提供更多的异常信息和异常处理功能

#include <iostream>
using namespace std;
class Error // 异常类Error
{
public:
	int errCode; // 异常代码
	char errMsg[40]; // 异常信息
	Error(int code,const char* msg) // 构造函数
	{
		errCode = code; strcpy(errMsg, msg);
	}
	void ShowError() // 显示异常的详细信息
	{
		cout << errCode << "," << errMsg << endl;
	}
};
int Div(int n) // 求100 ÷ n
{
	if (n <= 0) // 检查异常：如果n<=0，则属于异常情况
	{
		Error err(-1, "输入reshuffle时必须为正整数"); // 定义异常类Error的对象err
		throw (err); // 抛出异常对象err，然后退出当前函数的执行
	}
	// 如果没有异常，则执行如下的正常处理流程
	return (100 / n);
}
int main()
{
	int N; // 定义变量N，保存键盘输入的人数
	cin >> N;
	try
	{
		int result = Div(N); // 调用函数Div进行除法运算
		cout << "100÷" << N << "=" << result << endl; // 显示100 ÷ N的结果
	}
	catch (Error e) // 捕捉Error类的异常，并定义参数e来接收异常对象
	{
		e.ShowError(); // 向用户显示所捕捉到异常对象e的详细信息
	}
	return 0;
}