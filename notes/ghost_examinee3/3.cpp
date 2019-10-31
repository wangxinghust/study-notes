#include <iostream>
using namespace std;
class Base {
protected:
	int x;
public:
	Base() {
		x = 0;
	}
	Base(int xx) {
		x = xx;
	}
	void operator++() {
		x = x + 1;
	}
	void operator++(int) {
		x = x + 1;
	}
};