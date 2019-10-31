#include <iostream>
using namespace std;
template <typename T> // 类模板A
class A { // 类声明部分
private:
	T a1;
	int a2;
public:
	A(T p1, int p2) { // 构造函数
		a1 = p1;
		a2 = p2;
	}
	T Sum() { // 求数据成员的和
		return (T)(a1 + a2);
	}
	void Show() { // 显示数据成员
		cout << a1 << "," << a2 << endl;
	}
};
// 无类实现部分

template <typename T> //类模板B
class B { // 类声明部分
private:
	T a1;
	int a2;
public:
	B(T p1, int p2); // 构造函数
	T Sum(); // 求数据成员的和
	void Show(); // 显示数据成员
};
// 类实现部分: 需按函数模板的语法形式定义
template <typename T>
B<T>::B(T p1, int p2) { // 构造函数
	a1 = p1;
	a2 = p2;
}
template <typename T>
T B<T>::Sum() { // 求数据成员的和
	return (T)(a1 + a2);
}
template <typename T>
void B<T>::Show() { // 显示数据成员
	cout << a1 << "," << a2 << endl;
}

// 类模板的继承派生
// 基类Base
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

// 派生类 公有继承类模板Base，派生类时实例化
class Derived :public Base<double> {
private:
	int b; // 新增数据成员
public:
	// 注意派生类构造函数的写法
	Derived(double p1, int p2) :Base<double>(p1) {
		b = p2;
	}
	void Show() { // 覆盖基类同名函数
		cout << "b=" << b << endl;
	}
};

// 派生类Derived2：公有继承类模板Base，派生类仍为类模板
template <typename T, typename TT> // 新增类型参数TT
class Derived2 :public Base<T> {
private:
	TT b; // 新增数据成员
public:
	// 注意派生类构造函数的写法
	Derived2(T p1, TT p2) :Base<T>(p1) {
		b = p2;
	}
	void Show() {
		Base<T>::Show(); // 调用基类同名函数Show
		cout << "b=" << b << endl;
	}
};

int main(int argc, char* argv[]) {
	// 用类模板A定义对象，并访问某成员
	A<double> o1(10.5, 6); // double型对象o1
	o1.Show(); // 显示： 10.5,6
	cout << o1.Sum() << endl; // 显示:16.5

	A<int> o2(10, 6); // int型对象o2
	o2.Show(); //显示：10,6
	cout << o2.Sum() << endl; // 显示：16

	printf("\n");

	// 用类模板B定义对象，并访问某成员
	B<double> o3(10.5, 6);
	o3.Show();
	cout << o3.Sum() << endl;
	B<int> o4(10, 6);
	o4.Show();
	cout << o4.Sum() << endl;

	Derived obj(10.5, 6); // 定义派生类Derived的对象obj
	obj.Show(); // 显示结果：a=10.5，b=6

	// 使用派生类模板Derived2定义对象obj2
	Derived2<double, int> obj2(10.5, 6);
	obj.Show(); // 显示结果：a=10.5，b=6

	Base<double>* obj3 = &obj2;
	printf("asdf");
	obj3->Show();// 通过虚函数实现多态

	return 0;
}