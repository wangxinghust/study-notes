//ʹ���쳣�� �����͵��쳣�����ṩ������쳣��Ϣ���쳣������

#include <iostream>
using namespace std;
class Error // �쳣��Error
{
public:
	int errCode; // �쳣����
	char errMsg[40]; // �쳣��Ϣ
	Error(int code,const char* msg) // ���캯��
	{
		errCode = code; strcpy(errMsg, msg);
	}
	void ShowError() // ��ʾ�쳣����ϸ��Ϣ
	{
		cout << errCode << "," << errMsg << endl;
	}
};
int Div(int n) // ��100 �� n
{
	if (n <= 0) // ����쳣�����n<=0���������쳣���
	{
		Error err(-1, "����reshuffleʱ����Ϊ������"); // �����쳣��Error�Ķ���err
		throw (err); // �׳��쳣����err��Ȼ���˳���ǰ������ִ��
	}
	// ���û���쳣����ִ�����µ�������������
	return (100 / n);
}
int main()
{
	int N; // �������N������������������
	cin >> N;
	try
	{
		int result = Div(N); // ���ú���Div���г�������
		cout << "100��" << N << "=" << result << endl; // ��ʾ100 �� N�Ľ��
	}
	catch (Error e) // ��׽Error����쳣�����������e�������쳣����
	{
		e.ShowError(); // ���û���ʾ����׽���쳣����e����ϸ��Ϣ
	}
	return 0;
}