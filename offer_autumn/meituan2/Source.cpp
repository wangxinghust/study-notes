#include <iostream>
#include <string>
#include <vector>
#include <map>
#include <algorithm>
using namespace std;

int main() {

	string str;
	getline(cin, str);

	vector<string> data;
	int start = 0;
	while (start < str.length()) {
		int i = start;
		for (; i <= str.length(); i++) {
			if (str[i] == ' ' || i == str.length()) {
				data.push_back(str.substr(start, i - start));
				break;
			}
		}
		start = i + 1;
	}
	for (int i = 0; i < data.size() - 1; i++) {
		int len = min(data[i].size(), data[i + 1].size());
		// ÍùÏÂ±È½Ï
		for (int j = 0; j < len; j++) {
			if (data[i][j] == data[i + 1][0]) {
				if (data[i][1] == data[i + 1][1]) {

				}
			}
		}		
	}
	return 0;
}