#include <iostream>
using namespace std;
class Base { public: ~Base() { cout << "1"; } };
char fun() { Base b; throw('2'); return '3'; }
void main() {
	try { cout << fun(); }
	catch (char c) { cout << c; }
}