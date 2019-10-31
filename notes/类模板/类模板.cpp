#include <iostream>
using namespace std;
template <typename T> // ��ģ��A
class A { // ����������
private:
	T a1;
	int a2;
public:
	A(T p1, int p2) { // ���캯��
		a1 = p1;
		a2 = p2;
	}
	T Sum() { // �����ݳ�Ա�ĺ�
		return (T)(a1 + a2);
	}
	void Show() { // ��ʾ���ݳ�Ա
		cout << a1 << "," << a2 << endl;
	}
};
// ����ʵ�ֲ���

template <typename T> //��ģ��B
class B { // ����������
private:
	T a1;
	int a2;
public:
	B(T p1, int p2); // ���캯��
	T Sum(); // �����ݳ�Ա�ĺ�
	void Show(); // ��ʾ���ݳ�Ա
};
// ��ʵ�ֲ���: �谴����ģ����﷨��ʽ����
template <typename T>
B<T>::B(T p1, int p2) { // ���캯��
	a1 = p1;
	a2 = p2;
}
template <typename T>
T B<T>::Sum() { // �����ݳ�Ա�ĺ�
	return (T)(a1 + a2);
}
template <typename T>
void B<T>::Show() { // ��ʾ���ݳ�Ա
	cout << a1 << "," << a2 << endl;
}

// ��ģ��ļ̳�����
// ����Base
template <typename T>
class Base {
private:
	T a;
public:
	Base(T x) {
		a = x;
	}
	void Show() {
		cout << "a=" << a << ",";
	}
};

// ������ ���м̳���ģ��Base��������ʱʵ����
class Derived :public Base<double> {
private:
	int b; // �������ݳ�Ա
public:
	// ע�������๹�캯����д��
	Derived(double p1, int p2) :Base<double>(p1) {
		b = p2;
	}
	void Show() { // ���ǻ���ͬ������
		cout << "b=" << b << endl;
	}
};

// ������Derived2�����м̳���ģ��Base����������Ϊ��ģ��
template <typename T, typename TT> // �������Ͳ���TT
class Derived2 :public Base<T> {
private:
	TT b; // �������ݳ�Ա
public:
	// ע�������๹�캯����д��
	Derived2(T p1, TT p2) :Base<T>(p1) {
		b = p2;
	}
	void Show() {
		Base<T>::Show(); // ���û���ͬ������Show
		cout << "b=" << b << endl;
	}
};

int main(int argc, char* argv[]) {
	// ����ģ��A������󣬲�����ĳ��Ա
	A<double> o1(10.5, 6); // double�Ͷ���o1
	o1.Show(); // ��ʾ�� 10.5,6
	cout << o1.Sum() << endl; // ��ʾ:16.5

	A<int> o2(10, 6); // int�Ͷ���o2
	o2.Show(); //��ʾ��10,6
	cout << o2.Sum() << endl; // ��ʾ��16

	printf("\n");

	// ����ģ��B������󣬲�����ĳ��Ա
	B<double> o3(10.5, 6);
	o3.Show();
	cout << o3.Sum() << endl;
	B<int> o4(10, 6);
	o4.Show();
	cout << o4.Sum() << endl;

	Derived obj(10.5, 6); // ����������Derived�Ķ���obj
	obj.Show(); // ��ʾ�����a=10.5��b=6

	// ʹ��������ģ��Derived2�������obj2
	Derived2<double, int> obj2(10.5, 6);
	obj.Show(); // ��ʾ�����a=10.5��b=6

	Base<double>* obj3 = &obj2;
	printf("asdf");
	obj3->Show();// ͨ���麯��ʵ�ֶ�̬

	return 0;
}