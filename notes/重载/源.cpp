#include <iostream>
using namespace std;

class A {
public:
	void f() {
		cout << "1" << endl;
	}
	void f() const {
		cout << "2" << endl;
	}
};

int main(int argc, char* argv[]) {
	A a;
	const A b;
	a.f();
	b.f();
	return 0;
}