#include <iostream>
#include <vector>
#include <numeric>
#include <limits>
#include <algorithm>

using namespace std;


/*������������������ʵ����ĿҪ��Ĺ���
��Ȼ����Ҳ���Բ������������ģ����������ȫ�����Լ����뷨�� ^-^
******************************��ʼд����******************************/
int solution(vector < int > prices, int budget) {
	sort(prices.begin(), prices.end());
	vector<int> dp(budget + 1, prices.size() + 1);
	for (int i = 0; i < prices.size(); i++) {
		for (int j = 1; i + prices[i] * j <= budget; j++) {
			dp[i + prices[i] * j] = min(dp[i + prices[i] * j], dp[i]+j);
		}
	}
	if (dp[budget] == prices.size() + 1) return -1;
	else return dp[budget];
}
/******************************����д����******************************/


int main() {
	int res;

	int _prices_size = 0;
	cin >> _prices_size;
	cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
	vector<int> _prices;
	int _prices_item;
	for (int _prices_i = 0; _prices_i < _prices_size; _prices_i++) {
		cin >> _prices_item;
		cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
		_prices.push_back(_prices_item);
	}


	int _budget;
	cin >> _budget;
	cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');



	res = solution(_prices, _budget);
	cout << res << endl;

	return 0;

}


// ������������ 43%