#include <string>
#include <iostream>
#include <iomanip>
using namespace std;

double probability(int red, int blue) {
	// �ܵ���������3�����ò����������
	if (red + blue < 3) {
		return (double)red / (blue + red);
	}
	// ʣ�಻�����������ò������򣬱�Ȼ��
	if (blue <= 1) {
		return (double)red / (blue + red);
	}
	double result = 0.0;
	// ȡ������
	result += (double)red / (blue + red);
	// ��֧����������һ�������������֧���
	double tmp = 1.0;
	// Aȡ����
	tmp *= (double)blue / (blue + red);
	--blue;
	// Bȡ����
	tmp *= (double)blue / (blue + red);
	--blue;
	// ����֧��Cȡ����
	if (blue > 0) {
		result += tmp * blue / (blue + red) * probability(red, blue - 1);
	}
	// ����֧��Cȡ���򣬺���ֻʣһ����Cȡ������A����
	if (red > 1) {
		result += tmp * red / (blue + red) * probability(red - 1, blue);
	}
	return result;
}

int main() {
	int red, blue;
	cin >> red >> blue;
	double result = 0.0;
	int i = 0;
	cout << fixed << setprecision(5) << probability(red, blue) << endl;
	return 0;
}

// ֻ����ͨ45�Ĳ�������