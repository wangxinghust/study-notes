// 只能在堆上分配对象
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

// 只能在栈上分配对象
class B {
private:
	void* operator new(size_t){}
	void operator delete(void* prt){}
public:
	B(){}
	~B(){}
};