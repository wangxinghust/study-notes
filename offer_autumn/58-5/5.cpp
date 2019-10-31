#include <iostream>
#include <unordered_map>
#include <string>
#include <sstream>
using namespace std;

int main() {
	unordered_map<int, int> data;
	int sum = 0;
	int x;
	string line;
	getline(cin, line);
	stringstream ss(line);
	while (ss >> x) {
		++data[x];
		char ch;
		ss >> ch;
	}
	for (auto n : data) {
		sum += (n.second - 1) / (n.first + 1) * (n.first + 1);
		sum += n.first + 1;
	}
	cout << sum << endl;
}

//ac