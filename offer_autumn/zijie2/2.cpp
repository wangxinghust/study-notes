#include <iostream>
#include <string>
#include <vector>
using namespace std;

int getValue(string str) {
	if (str == ">") {
		return -1;
	}
	else if (str == "<") {
		return -2;
	}
	else {
		return stoi(str);
	}
}

int getScore(vector<int> data) {
	int i = 0;
	if (data[i] == -2) return 0;
	bool forward = true;
	int pre = 0;
	vector<bool> destory(data.size(), false);
	int score = 0;
	while (i >= 0 && i < data.size()) {
		if (destory[i]) {
			if (forward) ++i;
			else --i;
		}
		else {
			if (data[i] == -1) {
				if (pre == -1 || pre == -2) {
					destory[i] = true;
					continue;
				}
				forward = true;
				pre = -1;
			}
			else if (data[i] == -2) {
				if (pre == -1 || pre == -2) {
					destory[i] = true;
					continue;
				}
				forward = false;
				pre = -2;
			}
			else {
				score += data[i];
				--data[i];
				pre = data[i];
				if (data[i] == 0) {
					destory[i] = true;
				}
			}
			if (forward) ++i;
			else --i;
		}
	}
	return score;
}

int main() {
	int n, m, q;
	cin >> n >> m >> q;
	vector<int> data;
	string str;
	cin.get();
	getline(cin, str);
	int start = 0;
	for (int i = 0; i <= str.size(); i++) {
		if (i == str.size() || str[i] == ' ') {
			string tmp = str.substr(start, i - start);
			data.push_back(getValue(tmp));
			start = i + 1;
		}
	}
	vector<pair<int, int>> index(q);
	for (int i = 0; i < q; i++) {
		cin >> index[i].first >> index[i].second;
	}
	for (int i = 0; i < q; i++) {
		int left = index[i].first - 1;
		int right = index[i].second - 1;
		vector<int> tmp(data.begin() + left, data.begin() + right + 1);
		cout << getScore(tmp) << endl;
	}
	return 0;
}

// 第三题 能过测试用例 提交0