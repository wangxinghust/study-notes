#include <cstdint>
#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

bool compare(pair<int, int> a, pair<int, int> b) {
	if (a.first == b.first) return a.second < b.second;
	return a.first < b.first;
}

int main() {
	int n;
	cin >> n;
	vector<pair<int, int>> dataXi(n);
	vector<pair<int, int>> dataHi(n);
	for (int i = 0; i < n; i++) {
		int x, y;
		cin >> x >> y;
		dataXi[i] = { x,y };
		dataHi[i] = { y,x };
	}
	sort(dataXi.begin(), dataXi.end(), compare);
	sort(dataHi.begin(), dataHi.end(), compare);
	int indexXi = 0, indexHi = 0;
	int maxXi = 0, maxHi = 0;
	int result = 0;
	while (indexXi < n && indexHi < n) {
		while (indexXi < n && dataXi[indexXi].second < maxHi) {
			++indexXi;
		}
		while (indexHi < n && dataHi[indexHi].second < maxXi) {
			++indexHi;
		}

		if (indexXi < n && indexHi < n && dataXi[indexXi].first == dataHi[indexHi].second && dataXi[indexXi].second == dataHi[indexHi].first) {
			++result;
			maxXi = dataXi[indexXi].first;
			maxHi = dataHi[indexHi].first;
			++indexXi;
			++indexHi;
		}
		else if (indexXi < n && indexHi < n) {
			int lenXi = n;
			for (int i = indexXi; i < n; i++) {
				if (dataXi[i].first == dataHi[indexHi].second && dataXi[i].second == dataHi[indexHi].first) {
					lenXi = i - indexXi;
					break;
				}
			}
			int lenYi = n;
			for (int i = indexHi; i < n; i++) {
				if (dataXi[indexXi].first == dataHi[i].second && dataXi[indexXi].second == dataHi[i].first) {
					lenYi = i - indexHi;
					break;
				}
			}
			if (lenXi <= lenYi && lenXi != n) {
				++result;
				indexXi += lenXi;
				maxXi = dataXi[indexXi].first;
				maxHi = dataHi[indexHi].first;
				++indexXi;
				++indexHi;
			}
			else if (lenXi > lenYi) {
				++result;
				indexHi += lenYi;
				maxXi = dataXi[indexXi].first;
				maxHi = dataHi[indexHi].first;
				++indexXi;
				++indexHi;
			}
		}
	}
	cout << result << endl;
	return 0;
}

//����ս��Ʒ
//ʱ�����ƣ�C / C++���� 3000MS���������� 5000MS
//�ڴ����ƣ�C / C++���� 65536KB���������� 589824KB
//��Ŀ������
//����Ϸ�У�����ħ�����ӳ������N������������ð���Щ���������������Ա��׬��СǮ��
//�������Ա�и���ë����ÿ��������һ�������֮�����Ϳ����ϱ���������ı����ˡ�
//����������У���������ĺû�������ά�ȣ�ϡ�ж�X��ʵ�ö�H������Ա�ڻ���һ������A��
//��һ�������ϡ�жȺ�ʵ�öȶ����ܵ��ڱ���A����ô��ӳ�����ƶ�����˳�򣬲�����������Ա�����ܸ�����ࡣ

//***����
//��һ��һ��������N��
//������N�С�ÿ�����������ֱ��ʾX �� H
//X1 H1
//X2 H2
//��
//XN HN
//�������ƣ�
//����70% �����ݣ�
//0 < N < 10 ^ 4
//0 < Xi < 10 ^ 6
//0 < Hi < 10 ^ 6
//����100 % �����ݣ�
//0 < N < 10 ^ 6
//0 < Xi < 10 ^ 6
//0 < Hi < 10 ^ 6

//***���
//һ����������ʾ�����������ı�����

//***����
//4
//3 2
//1 1
//1 3
//2 2

//***���
//3

//***��ʾ
//1. ������2(1, 1)����
//2. ������4(2, 2)����
//3. ������1(3, 2)����