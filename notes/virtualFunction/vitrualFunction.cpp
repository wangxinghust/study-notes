#include <iostream>
using namespace std;

class A
{
public:
    virtual void fun1();
    void fun2();
};
void A::fun1(){ cout<<"Base class A:virtual fun1() called."<<endl;}
void A::fun2(){ cout<<"Base class A:non-virtual fun2() called."<<endl;}

class B:public A
{
public:
    virtual void fun1();//重写基类的虚函数fun1
    void fun2();
};
void B::fun1(){cout<<"Derived class B::virtual fun1() called."<<endl;}
void B::fun2(){cout<<"Derived class B::non-virtual fun2() called."<<endl;}

int main(){
    A aObj;
    B bObj;

    aObj.fun1();
    aObj.fun2();
	cout << "-------" << endl;
    bObj.fun1();
	bObj.fun2();
	cout << "-------" << endl;
	
	A &raObj=aObj;
	raObj.fun1();
	raObj.fun2();
	cout << "-------" << endl;
	A &rbObj=bObj;
	rbObj.fun1();
	rbObj.fun2();
	cout << "-------" << endl;
	A *paObj = &aObj;
	paObj->fun1();
	paObj->fun2();
	cout << "-------" << endl;
	A *pbObj = &bObj;
	pbObj->fun1();
	pbObj->fun2();

	system("pause");
    return 0;
}