#include <string>
#include <memory>

class Date;
class Address; // 声明式，应当放入.h文件中

class Person {
public:
	virtual ~Person();
	virtual std::string name() const = 0;
	virtual std::string birthDate() const = 0;
	virtual std::string address() const = 0;
	// 其他

	// 为这种class创建对象，通常调用一种特殊函数，此函数扮演“真正被具现化”的那个derived classes 的构造函数角色，
	// 这样的函数通常称为 factory（工厂）函数或 virtual 构造函数，返回指针，指向动态分配的对象，而该对象支持 Interface class 的接口
	static std::shared_ptr<Person> create(const std::string& name, const Date& birthday, const Address& addr);
	// 其他
};

class RealPerson : public Person {
public:
	RealPerson(const std::string& name,const Date& birthday,const Address& addr):theName(name),theBirthDate(birthday),theAddress(addr){}
	virtual ~RealPerson(){}
	std::string name() const;
	std::string birthDate() const;
	std::string address() const;
private:
	std::string theName;
	Date theBirthDate;
	Address theAddress;
};

int main() {
	std::string name;
	Date dateOfBirth;
	Address address;
	
	std::shared_ptr<Person> pp(Person::create(name, dateOfBirth, address));
}