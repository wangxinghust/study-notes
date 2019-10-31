#include <vector>
using namespace std;

template<typename T>
int partition(vector<T>& L, int low, int high) {
	int pivotkey = L[low]; // 用作比较值，并暂存
	while (low < high) {
		while (low < high && L[high] >= pivotkey) {
			--high;
		}
		L[low] = L[high]; // 采用替换而不是交换的方式进行操作
		while (low < high && L[low] <= pivotkey) {
			++low;
		}
		L[high] = L[low];
	}
	L[low] = pivotkey; // 恢复备份
	return low; // 返回枢轴所在位置
}

template<typename T>
void Qsort(vector<T>& L, int low, int high) {
	while (low < high) {
		int pivot = partition(L, low, high); // 计算枢轴值
		Qsort(L, low, pivot - 1); // 对低子表递归排序
		low = pivot + 1; // 尾递归
	}
}