#include <iostream>
int main() {
	char chr = 127;
	int sum = 200;
	chr += 1;
	sum += chr;
	std::cout << sum << std::endl;
	return 0;
}