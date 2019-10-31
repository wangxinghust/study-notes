#include <vector>
using namespace std;

template<typename T>
int partition(vector<T>& L, int low, int high) {
	int pivotkey = L[low]; // �����Ƚ�ֵ�����ݴ�
	while (low < high) {
		while (low < high && L[high] >= pivotkey) {
			--high;
		}
		L[low] = L[high]; // �����滻�����ǽ����ķ�ʽ���в���
		while (low < high && L[low] <= pivotkey) {
			++low;
		}
		L[high] = L[low];
	}
	L[low] = pivotkey; // �ָ�����
	return low; // ������������λ��
}

template<typename T>
void Qsort(vector<T>& L, int low, int high) {
	while (low < high) {
		int pivot = partition(L, low, high); // ��������ֵ
		Qsort(L, low, pivot - 1); // �Ե��ӱ�ݹ�����
		low = pivot + 1; // β�ݹ�
	}
}