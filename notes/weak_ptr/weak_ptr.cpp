#include <memory>
#include <iostream>
using namespace std;
class B;
class A {
public:
	shared_ptr<B> pb_;
	~A() {
		cout << "A delete\n";
	}
};
class B {
public:
	shared_ptr<A> pa_;
	~B() {
		cout << "B delete\n";
	}
};

void fun(){
	shared_ptr<B> pb(new B());
	shared_ptr<A> pa(new A());
	//pb->pa_ = pa;// 注释掉这两行后可以成功释放资源
	//pa->pb_ = pb;
	cout << pb.use_count() << endl;
	cout << pa.use_count() << endl;
}

int main(int argc, char* argv[]) {
	fun();
	return 0;
}

// 未能调用析构函数 导致资源没能释放