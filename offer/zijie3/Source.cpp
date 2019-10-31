#include <iostream>
#include <vector>
using namespace std;
int main(int argc, char* argv[]) {
	int N;
	cin >> N;
	vector<int> year(N);
	for (int i = 0; i < N; i++) {
		cin >> year[i];
	}
	int money = 100;
	int sum = 100;
	for (int i = 1; i < N; i++) {
		if (year[i] > year[i - 1]) {
			money += 100;
		}
		else {
			money -= 100;
			money = money >= 100 ? money : 100;
		}
		sum += money;
	}
	cout << sum << endl;
	return 0;
}