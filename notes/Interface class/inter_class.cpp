#include <string>
#include <memory>

class Date;
class Address; // ����ʽ��Ӧ������.h�ļ���

class Person {
public:
	virtual ~Person();
	virtual std::string name() const = 0;
	virtual std::string birthDate() const = 0;
	virtual std::string address() const = 0;
	// ����

	// Ϊ����class��������ͨ������һ�����⺯�����˺������ݡ����������ֻ������Ǹ�derived classes �Ĺ��캯����ɫ��
	// �����ĺ���ͨ����Ϊ factory�������������� virtual ���캯��������ָ�룬ָ��̬����Ķ��󣬶��ö���֧�� Interface class �Ľӿ�
	static std::shared_ptr<Person> create(const std::string& name, const Date& birthday, const Address& addr);
	// ����
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