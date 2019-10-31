#include <iostream>
#include <vector>
using namespace std;

int main() {
	int n, m;
	cin >> n >> m;
	vector<pair<int, int>> data;
	for (int i = 0; i < m; i++) {
		int n1, n2;
		cin >> n1 >> n2;
		data.push_back({ n1,n2 });
	}

	vector<int> num(2 * n + 1, 0);
	vector<bool> visit(2 * n + 1, false);
	bool end = true;
	while (end) {
		end = false;
		for (auto d : data) {
			if (!visit[d.first] && !visit[d.second]) {
				end = true;
				++num[d.first];
				++num[d.second];
			}
		}
		int max = 0;
		int max_index = 0;
		for (int i = 0; i < num.size(); i++) {
			if (num[i] > max) {
				max = num[i];
				max_index = i;
			}
		}
		visit[max_index] = true;

		num.clear();
	}

	int sum = 0;
	for (int i = 1; i < 2 * n + 1; i++) {
		if (visit[i]) {
			sum++;
		}
	}
	cout << sum << endl;
	for (int i = 1; i < 2 * n + 1; i++) {
		if (visit[i]) {
			cout << i << endl;
		}
	}

	return 0;
}


//ʱ�����ƣ�C / C++���� 1000MS���������� 3000MS
//�ڴ����ƣ�C / C++���� 65536KB���������� 589824KB
//��Ŀ������
//ĳУ�ڻ����������˼࿼�ƶȣ���������ѧ���ǲ��Ծ��ģ����������������������ѷ���ͬһ����������Ǿͻύ���������ס����һ�������в�����������������������Ѵ��ڣ�ѧУϣ��ͨ�����һ����ѧ���ķ�����������һ���⡣
//
//��������Ϊ�����������ޣ����ϣ��һ�����������µ�ѧ�������ܶ࣬����Ҫ������ҵ�ѧ�������������٣����������������������٣����ֵ�����С�ķ�����
//
//�����һ������������n��m���ֱ��ʾ��n��������n��Ů������m�����ѹ�ϵ��
//
//(1 <= n <= 500, 1 <= m <= 100000)
//
//������m�У�ÿ��������������x��y����ʾ��x�������͵�y��Ů�������ѡ������ı�ž�Ϊ[1, n]��Ů���ı��Ϊ[n + 1, 2n]��
//�����һ�а���һ������a����ʾ������Ҫ������ҵ�������
//
//����ڶ�����a����������a����Ҫ������ҵ��˵ı�ţ�Ҫ���������٣����ֵ�����С��
//
//
//��������
//2 2
//3 1
//1 4
//�������
//1
//1