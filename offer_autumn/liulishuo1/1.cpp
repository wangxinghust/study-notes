#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;
int main() {
	int n;
	cin >> n;
	int a, b;
	cin >> a >> b;
	vector<pair<int, int>> data;
	for (int i = 0; i < n; i++) {
		int x, y;
		cin >> x >> y;
		data.push_back({ x,y });
	}
	sort(data.begin(), data.end(), [](auto i, auto j) {
		return i.first - i.second < j.first - j.second;
		});
	int result = 0;
	int i = 0;
	for (; i < a; i++) {
		result += data[i].first;
	}
	for (; i < n; i++) {
		result += data[i].second;
	}
	cout << result << endl;
	return 0;
}