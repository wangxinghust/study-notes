#include <iostream>
#include <vector>
#include <string>
using namespace std;

int main() {
	int m;
	cin >> m;
	vector<vector<int>> data(m, vector<int>(4, 0));
	vector<vector<int>> copy(m, vector<int>(4, 0));
	vector<string> str(m);
	cin.get();
	for (int i = 0; i < m; i++) {
		getline(cin, str[i]);
	}
	for (int i = 0; i < m; i++) {
		int k = 0;
		int j = 0;
		int index = 0;
		while (j < str[i].length()) {
			if (str[i][j] == ' ') {
				data[i][index++] = stoi(str[i].substr(k, j - k));
				break;
			}
			else if (str[i][j] == '.') {
				data[i][index++] = stoi(str[i].substr(k, j - k));
				k = j + 1;
			}
			j++;
		}
		j++;
		k = 0;
		index = 0;
		while (j <= str[i].length()) {
			if (j == str[i].length() || str[i][j] == '.') {
				copy[i][index++] = stoi(str[i].substr(k, j - k));
				k = j + 1;
			}
			j++;
		}
	}
	
	for (int i = 0; i < m; i++) {
		int j = 0;
		while (j < 4 && data[i][j] == copy[i][j]) {
			j++;
		}
		if (j != 4 && data[i][j] < copy[i][j]) {
			cout << "true\n";
		}
		else {
			cout << "false\n";
		}
	}

	return 0;
}