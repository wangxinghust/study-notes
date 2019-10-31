//ʱ�����ƣ�C / C++���� 1000MS���������� 3000MS
//�ڴ����ƣ�C / C++���� 65536KB���������� 589824KB
//��Ŀ������
//�ϳ��ӵ�N��ѧ��վ��һ���Ҵ����ұ��Ϊ1��N�����б��Ϊi��ѧ�����ΪHi�����ڽ���Щѧ���ֳ������飨ͬһ���ѧ�����������������ÿ��ѧ�������Ұ���ߴӵ͵��߽������У�ʹ���������ѧ��ͬ�������������ߴӵ͵��ߣ��м�λ�ÿ��Եȸߣ�����ô����ܽ���Щѧ���ֳɶ����飿

#include <iostream>
#include <vector>
using namespace std;
int main() {
	int N;
	cin >> N;
	vector<int> height(N);
	for (int i = 0; i < N; i++) {
		cin >> height[i];
	}

	int index = 0;
	int res = 0;
	while (index < N) {
		if (index + 1 == N || (height[index + 1] != height[index] + 1 && height[index + 1] != height[index] - 1)) {
			++res;
			++index;
			continue;
		}
		if (height[index + 1] == height[index] + 1) {
			while (index + 1 < N && height[index + 1] == height[index] + 1) {
				++index;
			}
			++index;
			++res;
		}
		else {
			while (index + 1 < N && height[index + 1] == height[index] - 1) {
				++index;
			}
			++index;
			++res;
		}
	}

	cout << res << endl;

	return 0;
}

// �����е����� leetcode 581��
// �о�������ķ�����ȽϺ���⣬��leetcode��ȣ�ͬʱ����ά��һ��maxֵ��maxֵ�����������ֵ���ʱ��˵�����Է�����
// ����һ������û�г�������ȷλ�õ���
// ����
// 2 6 4 8 10 9 15
// 2 4 6 8 9 10 15
// 2/4 6/8/9 10/15