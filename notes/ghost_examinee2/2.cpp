#include <iostream>
using namespace std;
class A {
public:
	A() { cout << "0"; }
	virtual ~A() { cout << "1"; };
};
class B :public A {
public:
	B() {
		cout << "2";
		buf = new char[10];
	}
	virtual ~B() {
		delete[]buf;
		cout << "3";
	}
private:
	char* buf;
};

void main() {
	A a;
	B b;
	a = b;
}