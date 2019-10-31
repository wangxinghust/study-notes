#include <iostream>
#include <string>
using namespace std;

int main() {
	string str;
	getline(cin, str);
	int left = 0, right = 0;
	while (left < str.length()) {
		for (int i = left; i <= right; i++) {
			int tmp = str.find_last_of(str[i]);
			right = tmp > right ? tmp : right;
		}
		cout << right - left + 1 << " ";
		left = right + 1;
		right = left;
	}
	return 0;
}

//AC

// »¬¶¯´°¿Ú