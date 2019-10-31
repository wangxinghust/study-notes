template<typename T>
class Rational {
public:
	Rational(const T& numerator = 0, const T & denominator = 1){}
	friend const Rational operator*(const Rational<T>& lhs, const Rational<T>& rhs); // 在一个 class template 内，template 名称可被用来作为“template 和其参数”的简略表达方式
};

template<typename T>
const Rational<T> operator*(const Rational<T>& lhs, const Rational<T>& rhs) {

}

int main() {
	Rational<int> oneHalf(1, 2);
	Rational<int> result = oneHalf * 2;
}