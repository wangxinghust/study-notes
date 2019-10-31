#include <iostream>
#include <string>
using namespace std;
int main() {
	string data;
	getline(cin, data);
	string result = "";
	int left = 0;
	for (int i = 0; i < data.size(); i++) {
		if (data[i] == '(') ++left;
		else if (data[i] == ')') --left;
		else {
			if (left == 0) {
				if (data[i] == '<') {
					if(!result.empty())
					result.pop_back();
				}
				else {
					result += data[i];
				}
			}
		}
	}
	cout << result << endl;
	return 0;
}