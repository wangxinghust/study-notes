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
	thread t0(&love::sayloveyou);//����̬����
	t0.join();
	thread t1(&love::saylove, loveadapter, "one");// ������
	t1.join();
	thread t2(&love::saylove, &loveadapter, "two");// ��ָ��Ҳ��
	t2.join();
	thread t3(bind(&love::saylove, loveadapter, "three"));//bind�鴫����Ҳ��
	t3.join();
	thread t4(bind(&love::saylove, &loveadapter, "four"));//bind�ﴫָ��Ҳ��
	t4.join();
	return 0;
}