// ֻ���ڶ��Ϸ������
class A {
protected:
	A(){}
	~A(){}
public:
	static A* create() {
		return new A();
	}
	void destory() {
		delete this;
	}
};

// ֻ����ջ�Ϸ������
class B {
private:
	void* operator new(size_t){}
	void operator delete(void* prt){}
public:
	B(){}
	~B(){}
};