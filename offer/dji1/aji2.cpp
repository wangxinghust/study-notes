#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;
struct food {
	double good;
	int price;
	int contend;
	int num;
};
int main(int argc, char* argv[]) {
	int N, T;
	while (cin >> N) {
		cin >> T;
		vector<food> data(N);
		for (int i = 0; i < N; i++) {
			cin >> data[i].price >> data[i].contend >> data[i].num;
			data[i].good = (double)data[i].contend / (double)data[i].price;
		}
		sort(data.begin(), data.end(), [](food a, food b) {
			if (a.good == b.good) {
				return a.price < b.price;
			}
			return a.good > b.good;
			});
		int max = 0;
		int index = 0;
		while (T > 0 && index < N) {
			if (T / data[index].price <= data[index].num) {
				int n = T / data[index].price;
				max += n * data[index].contend;
				T -= n * data[index].price;
				index++;
			}
			else {
				max += data[index].contend * data[index].num;
				T -= data[index].price * data[index].num;
				index++;
			}
		}
		cout << max << endl;
	}
}