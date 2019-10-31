#include <string>
#include <iostream>
#include <vector>
using namespace std;

bool delimi(string s, string delimiter, pair<string, string>& result) {
	if (s.empty()) return false;
	int index = s.find_first_of(delimiter);
	if (index == -1) return false;
	string key = s.substr(0, index);
	string value = s.substr(index + 1);
	if (!key.empty() && !value.empty())
		result = { key,value };
	return true;
}

int main() {
	string data;
	getline(cin, data);
	int index1 = data.find_first_not_of(' ');
	int index2 = data.find_first_of(' ', index1);
	string pair_delimiter = data.substr(index1, index2 - index1);

	int index3 = data.find_first_not_of(' ', index2);
	int index4 = data.find_first_of(' ', index3);

	if (index4 == -1) {
		cout << 0 << endl;
		return 0;
	}

	string delimiter = data.substr(index3, index4 - index3);

	int index5 = data.find_first_not_of(' ', index4);
	data = data.substr(index5);
	vector<pair<string, string>> result;
	while (!data.empty()) {
		int pos = data.find_first_of(pair_delimiter);
		if (pos != -1) {
			string tmp = data.substr(0, pos);
			pair<string, string> p;
			if (delimi(tmp, delimiter, p))
				result.push_back(p);
			data = data.substr(pos + 1);
		}
		else {
			pair<string, string> p;
			if (delimi(data, delimiter, p))
				result.push_back(p);
			data = "";
		}
	}
	cout << result.size() << endl;
	for (pair<string, string> p : result) {
		cout << p.first << " " << p.second << endl;
	}

	return 0;
}

//ac