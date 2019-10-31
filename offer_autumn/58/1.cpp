#include <iostream>
#include <unordered_set>
#include <string>
#include <sstream>
using namespace std;

int main() {
	string str;
	getline(cin, str);
	istringstream data(str);
	unordered_set<int> set;
	int x;
	char ch;
	while (data >> x) {
		set.insert(x);
		data >> ch;
	}
	cout << set.size() << endl;
	return 0;
}

// ac