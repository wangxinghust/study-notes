//Ìí¼Ócpp²âÊÔÎÄ¼ş

#include <iostream>
#include <unordered_map>
#include <string>
#include <vector>
using namespace std;
int main() {
	vector<char> alphas = { 'a','b','c','d' };
	string str = "tbcacbdata";

	unordered_map<char, int> dict;
	for (int i = 0; i < alphas.size(); i++) {
		++dict[alphas[i]];
	}
	unordered_map<char, int> slidingWindow;
	int formed = 0, n = dict.size();
	int left = 0, right = 0;
	while (right < str.size()) {
		while (right < str.size() && formed < n) {
			if (right < str.size()) {
				++slidingWindow[str[right]];
			}
			if (dict.find(str[right]) != dict.end() && slidingWindow[str[right]] == 1) {
				++formed;
			}
			++right;
		}
		if (formed == n) {
			while (left < str.size()) {
				--slidingWindow[str[left]];
				if (dict.find(str[left]) != dict.end() && slidingWindow[str[right]] == 0) {
					--formed;
					++left;
					break;
				} else {
					++left;
				}
			}
			int len = str.substr(left - 1, right - left + 1).size();
		}
	}

	return 0;
}