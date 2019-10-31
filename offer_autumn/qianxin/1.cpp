#include <iostream>
#include <vector>
#include <numeric>
#include <limits>
#include <algorithm>

using namespace std;


/*������������������ʵ����ĿҪ��Ĺ���
��Ȼ����Ҳ���Բ������������ģ����������ȫ�����Լ����뷨�� ^-^
******************************��ʼд����******************************/
int smallestRange(vector<int>& data,int k) {
	if (data.size() == 1) return 0;
	sort(data.begin(), data.end());
	if (data.size() == 2) {
		if (data[1] - data[0] <= k) {
			return data[1] - data[0];
		} else if (data[1] - data[0] < 2 * k) {
			return min(2 * k + data[0] - data[1], data[1] - data[0]);
		}
		return data[1] - data[0] - 2 * k;
	}
	int res = data[data.size() - 1] - data[0];
	for (int i = 0; i < data.size() - 1; i++) {
		int a = data[i], b = data[i + 1];
		int up = max(data[data.size() - 1] - k, a + k);
		int down = min(data[0] + k, b - k);
		res = min(res, up - down);
	}
	return res;
}
/******************************����д����******************************/


int main() {
	int res;
	int k;
	cin >> k;
	vector<int> data;
	int x;
	while (cin >> x) {
		data.push_back(x);
	}

	res = smallestRange(data,k);
	cout << res << endl;

	return 0;

}
