#include <iostream>
using namespace std;

// ��100/n
int Div(int n) {
	// ����쳣�����n<=0���������쳣���
	if (n <= 0) {
		// �쳣�������̣��׳��쳣��Ȼ���˳���ǰ������ִ��
		throw(-1);
	}
	// ���û���쳣����ִ�����µ�������������
	return (100 / n);
}

int main(int argc, char* argv[]) {
	// �������N������������������
	int N;
	cin >> N;
	try {
		// ���ú���Div���г�������
		int result = Div(N);
		// ��ʾ100 �� N �Ľ��
		cout << "100��" << N << "=" << result << endl;
	}
	// ����int���쳣
	catch(int x){
		// ���û���ʾ������Ϣ
		cout << "��������ʱ����Ϊ������" << endl;
		cout << "�쳣����ϸ��Ϣ" << x << endl;
	}
	// �����������͵��쳣
	catch (...) {
		// ���û���ʾ������Ϣ
		cout << "�����������쳣" << endl;
	}
	return 0;
}