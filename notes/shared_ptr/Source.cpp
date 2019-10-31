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
	// ���캯��
	SmartPointer(T* ptr = nullptr) :_ptr(ptr) {
		if (_ptr) {
			_count = new size_t(1);
		}
		else {
			_count = new size_t(0);
		}
	}
	// �������캯��
	SmartPointer(const SmartPointer& ptr) {
		if (this != &ptr) {
			this->_ptr = ptr._ptr;
			this->_count = ptr._count;
			(*this->_count)++;
		}
	}
	// ���ظ�ֵ������
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
	// ���ز�����
	T& operator*() {
		assert(this->_ptr == nullptr);
		return *(this->_ptr);
	}
	// ���ز�����
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