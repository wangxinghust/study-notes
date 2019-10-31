#include <iostream>
#include <memory>

template<typename T>
class SmartPointer {
private:
	T* _ptr;
	size_t* _count;
	void releaseCount() {
		if (_ptr) {
			(*_count)--;
			if ((*_count) == 0) {
				delete _ptr;
				delete _count;
			}
		}
	}
public:
	// 构造函数
	SmartPointer(T* ptr = nullptr) :_ptr(ptr) {
		if (_ptr) {
			_count = new size_t(1);
		}
		else {
			_count = new size_t(0);
		}
	}
	// 拷贝构造函数
	SmartPointer(const SmartPointer& ptr) {
		if (this != &ptr) {
			this->_ptr = ptr._ptr;
			this->_count = ptr._count;
			(*this->_count)++;
		}
	}
	// 重载赋值操作符
	SmartPointer& operator=(const SmartPointer& ptr) {
		if (this->_ptr == ptr._ptr) {
			return *this;
		}
		releaseCount();
		this->_ptr = ptr._ptr;
		this->_count = ptr._count;
		(*this->_count)++;
		return *this;
	}
	// 重载操作符
	T& operator*() {
		assert(this->_ptr == nullptr);
		return *(this->_ptr);
	}
	// 重载操作符
	T* operator->() {
		assert(this->_ptr == nullptr);
		return this->_ptr;
	}
	~SmartPointer() {
		(*this->_count)--;
		if (*this->_count == 0) {
			delete this->_ptr;
			delete this->_count;
		}
	}
	size_t use_count() {
		return *this->_count;
	}
};

int main() {

	SmartPointer<int> sp(new int(10));
	SmartPointer<int> sp2(sp);
	SmartPointer<int> sp3(new int(20));
	sp2 = sp3;
	std::cout << sp.use_count() << std::endl;
	std::cout << sp2.use_count() << std::endl;
	std::cout << sp3.use_count() << std::endl;

	return 0;
}