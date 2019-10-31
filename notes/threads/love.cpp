#include <iostream>
#include <thread>
#include <functional>
using namespace std;

class love {
public:
	void saylove(string name);
	static void sayloveyou();
};

void love::saylove(string name) {
	cout << "I love" << name << "!" << endl;
}
void love::sayloveyou() {
	cout << "I love you!" << endl;
}

int main() {
	love loveadapter;
	thread t0(&love::sayloveyou);//传静态函数
	t0.join();
	thread t1(&love::saylove, loveadapter, "one");// 传对象
	t1.join();
	thread t2(&love::saylove, &loveadapter, "two");// 传指针也行
	t2.join();
	thread t3(bind(&love::saylove, loveadapter, "three"));//bind组传对象也行
	t3.join();
	thread t4(bind(&love::saylove, &loveadapter, "four"));//bind里传指针也行
	t4.join();
	return 0;
}