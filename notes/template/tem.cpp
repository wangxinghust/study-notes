template<typename T>
class Rational {
public:
	Rational(const T& numerator = 0, const T & denominator = 1){}
	friend const Rational operator*(const Rational<T>& lhs, const Rational<T>& rhs); // ��һ�� class template �ڣ�template ���ƿɱ�������Ϊ��template ����������ļ��Ա�﷽ʽ
};

template<typename T>
const Rational<T> operator*(const Rational<T>& lhs, const Rational<T>& rhs) {

}

int main() {
	Rational<int> oneHalf(1, 2);
	Rational<int> result = oneHalf * 2;
}