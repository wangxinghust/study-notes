#include <iostream>
#include <vector>
#include <string>
#include <unordered_set>
using namespace std;


int main() {
	string t, s;
	getline(cin, t);
	getline(cin, s);
	int start = 0;
	int counter = 0;
	int num = s.length() / 2 + 1;
	int index = 0;

	while (start < t.length()) {
		int i = start;
		for (; i <= t.length(); i++) {
			if (i == t.length()) {
				cout<< t.substr(start);
				break;
			}
			else if (t[i] == ' ') {
				counter++;
				if (counter % 4 == 0) {
					cout << t.substr(start, i - start + 1);
					if (index < num) {
						cout << s[2 * index] << " ";
						index++;
					}
					break;
				}
				
			}
		}
		start = i + 1;
	}

	if (index < num) {
		cout << " " << s.substr(2 * index) << endl;
	}
	return 0;
}