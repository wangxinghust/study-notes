#include <iostream>
#include <iomanip>
using namespace std;
int main() {
	double result = 1.04;
	double result2 = 1.05;
	int i = 0;
	cout << fixed << setprecision(1) << result << endl << result2 << endl;
	return 0;
}