#include <string>
#include <iostream>
#include <vector>
using namespace std;
int main(int argc, char* argv[]) {
	string ip1, ip2, son;
	cin >> ip1 >> ip2 >> son;
	vector<int> n1(4), n2(4), n3(4);
	int j = 0;
	for (int i = 0; i < 4; ++i) {
		int tmp = 0;
		for (; j < ip1.length() && ip1[j] != '.'; ++j) {
			tmp = tmp * 10 + (ip1[j] - '0');			
		}
		++j;
		n1[i] = tmp;
	}
	j = 0;
	for (int i = 0; i < 4; ++i) {
		int tmp = 0;
		for (; j < ip2.length() && ip2[j] != '.'; ++j) {
			tmp = tmp * 10 + (ip2[j] - '0');
		}
		++j;
		n2[i] = tmp;
	}
	j = 0;
	for (int i = 0; i < 4; ++i) {
		int tmp = 0;
		for (; j < son.length() && son[j] != '.'; ++j) {
			tmp = tmp * 10 + (son[j] - '0');
		}
		++j;
		n3[i] = tmp;
	}
	vector<int> multi1(4), multi2(4);
	for (int i = 0; i < 4; ++i) {
		multi1[i] = n1[i] & n3[i];
		multi2[i] = n2[i] & n3[i];
	}
	bool b = true;
	for (int i = 0; i < 4; ++i) {
		if (multi1[i] != multi2[i]) {
			b = false;
			break;
		}
	}
	cout << b << " " << multi1[0] << "." << multi1[1] << "." << multi1[2] << "." << multi1[3] << endl;
}