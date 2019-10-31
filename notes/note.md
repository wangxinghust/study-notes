# ѧϰ�ʼ�
## �ļ�I/O
istream& **seekg**(long bytes, ios::seek_dir origin);//�ƶ����ļ�ָ��  
long tellg();//���ص�ǰ���ļ�ָ���λ��

ostream& **seekp**(long bytes, ios::seek_dir origin);//�ƶ�д�ļ�ָ��  
long tellp();//���ص�ǰд�ļ�ָ���λ��

>�ļ�ָ�� p.cpp

```cpp
#include <iostream>
#include <fstream>
using namespace std;
int main() {
	char name[20];
	double price;
	ifstream fin;
	fin.open("price.dat", ios::binary);
	for (size_t i = 0; i < 2; i++)
	{
		fin.read(name, 7);
		fin.read((char*)& price, 8);
		cout << name << "," << price << endl;
	}
	fin.seekg(-15, ios::end);//���ļ�β��ǰ�������أ��ƶ�1�У�1����15���ֽڣ�
	fin.read(name, 7);
	fin.read((char*)& price, 8);//�ض����һ������
	cout << name << "," << price << endl;
	fin.close();
	return 0;
}
```
***
## string�༰�ַ���I/O
�ַ���I/O

* ���԰�**string�����**����**����Դ**�������е��ַ��������������������ʱstring��������һ������������
* �����������
* ���ַ����������������֮��������ݵ�����/��� ����cin�����ݻ�����

C++�����ͨ���ַ�������/��������ṩ���ַ���I/O�Ĺ���  
�ַ�������/������๲��3����
1. �ַ����������� istringstream
2. �ַ���������� ostringstream
3. �ַ�������/������� stringstream
4. #include \<sstream>

## ����Unicode����������
����Unicode������������wiosΪ����
* ��׼I/O������ͨ����������wistream��ͨ���������wostream��ͨ������/�������wiostream
* �ļ�I/O�������ļ���������wifstream���ļ��������wofstream���ļ�����/�������wfstream
* �ַ���I/O�������ַ�����������wistringstream���ַ����������wostringstream���ַ�������/�������wstringstream

Ԥ����Ŀ��ַ�������
```cpp
namespace std{
	wistream wcin;
	wostream wcout;
}
```

## С��
* cin��coutָ��ʵ���Ϸֱ���ͨ�������������Ķ���
* �󲿷ֳ�����Ҫʹ���ļ�����������

## ��10�� C++��׼��
C++��׼��
* ���ڽṹ��������Ʒ������ṩ�ĵ�ϵͳ����
* ����������������Ʒ������ṩ��ϵͳ���

ģ�弼����
* ����ģ��
* ��ģ��

### 10.1 ����ģ��
```
template <���Ͳ����б�>
�������� ������(��ʽ�����б�){
    ������
}
```

������
```cpp
#include <iostream>
using namespace std;

template <typename T> // ���庯��ģ��
T max(T x, T y) {// ʹ�����Ͳ���T��ָ�����������͡��β�x��y������
	return x > y ? x : y;
}

int main(int argc, char* argv[]) {
	cout << max(5, 10) << endl;
	cout << max(5.2, 10.2) << endl;
}
```

* ����ģ��ı���ԭ��  
����ģ���Ǿ������Ͳ����ĺ��������Ͳ����Ǳ�ʾ�������͵Ĳ�������ָ������һ��ʵ���������͡��������ڱ��뵽����ģ��������ʱ������λ�ö�Ӧ��ϵ��ʵ�����������Ƶ������Ͳ�����ָ�����������ͣ�Ȼ���պ���ģ���Զ�����һ�������͵ĺ���������롣
��ͬ����ʵ�εĺ���ģ�������佫���ɲ�ͬ���͵����غ�����
* ����ģ�彫�����������Ͳ�����������ʱ���ֳ�������̬��
* ʹ�ú���ģ����Լ��ٳ���Ա�ı��빤����������������Ŀ�ִ�д��벻����٣�ִ��Ч��Ҳ���䡣

### 10.2 ��ģ��
```
template <���Ͳ����б�>
class ���� // ����������
{
    ���Ա����
}
// ��ʵ�ֲ��֣��������ⶨ��ĺ�����Ա�����밴���µ��﷨��ʽ�����Ƕ���ɺ���ģ��
template <���Ͳ����б�>
�������� ����<���Ͳ������б�> :: ������(��ʽ�����б�)
{ ������ }
```
������

ʹ����ģ�嶨�����ʱ��Ҫ��ȷ�������Ͳ�����ָ����ʵ���������͡�
```cpp
#include <iostream>
using namespace std;
 template <typename T> // ��ģ��A
 class A { // ����������
 private:
	 T a1;
	 int a2;
 public:
	 A(T p1, int p2) { // ���캯��
		 a1 = p1;
		 a2 = p2;
	 }
	 T Sum() { // �����ݳ�Ա�ĺ�
		 return (T)(a1 + a2);
	 }
	 void Show() { // ��ʾ���ݳ�Ա
		 cout << a1 << "," << a2 << endl;
	 }
 };
 // ����ʵ�ֲ���

 template <typename T> //��ģ��B
 class B { // ����������
 private:
	 T a1;
	 int a2;
 public:
	 B(T p1, int p2); // ���캯��
	 T Sum(); // �����ݳ�Ա�ĺ�
	 void Show(); // ��ʾ���ݳ�Ա
 };
 // ��ʵ�ֲ���: �谴����ģ����﷨��ʽ����
 template <typename T>
 B<T>::B(T p1, int p2) { // ���캯��
	 a1 = p1;
	 a2 = p2;
 }
 template <typename T>
 T B<T>::Sum() { // �����ݳ�Ա�ĺ�
	 return (T)(a1 + a2);
 }
 template <typename T>
 void B<T>::Show() { // ��ʾ���ݳ�Ա
	 cout << a1 << "," << a2 << endl;
 }


 int main(int argc, char* argv[]) {
	 // ����ģ��A������󣬲�����ĳ��Ա
	 A<double> o1(10.5, 6); // double�Ͷ���o1
	 o1.Show(); // ��ʾ�� 10.5,6
	 cout << o1.Sum() << endl; // ��ʾ:16.5

	 A<int> o2(10, 6); // int�Ͷ���o2
	 o2.Show(); //��ʾ��10,6
	 cout << o2.Sum() << endl; // ��ʾ��16

	 printf("\n");

	 // ����ģ��B������󣬲�����ĳ��Ա
	 B<double> o3(10.5, 6);
	 o3.Show();
	 cout << o3.Sum() << endl;
	 B<int> o4(10, 6);
	 o4.Show();
	 cout << o4.Sum() << endl;
	 return 0;
 }
```
��ģ��ı���ԭ��
* ����ʱ����ģ�������Ͳ����󶨵�ĳ�������������͵Ĺ��̣�
��Ϊ��ģ���ʵ������ʵ���������ɵ����Ϊ��ģ���ʵ���ࡣ
ʵ������һ����ͨ���࣬���������������
* ��ģ���Ǿ������Ͳ������ࡣ���Ͳ����Ǳ�ʾ�������͵Ĳ�����
��ָ������һ��ʵ���������͡��������ڱ��뵽ʹ����ģ�嶨��
�������ʱ�������Ȱ�����������ʵ���������Ͷ���ģ�����ʵ������
����һ��ʵ���ࡣ���գ���������ʹ��ʵ��������������Ҫ�Ķ���

ʹ��typedef������ʾ��ʵ������ģ��
```cpp
int main(int argc, char* argv[]){
    typedef A<double> DoubleA; // ʵ������ģ��A������ʵ����DoubleA
    DoubleA o1(10.5,6); // ������DoubleA�Ķ���o1
    o1.Show(); // ��ʾ��10.5,6
    cout<<o1.Sum()<<endl; // ��ʾ��16.5
    
    typedef A<int> IntA;
    IntA o2(10,6);
    o2.Show();
    cout<<o2.Sum()<<endl;
    return 0;
}
```

## 10.3 C++��׼��
C++��׼��Ҳ����Ϊ��׼ģ���(Standard Template Library,STL)

10���๦��
1. ����֧��(Language Support)��
2. ͨ�ù���(General Utilities)��
3. ����/���(Input/Output)��
4. �ַ���(string)��
5. ���(Diagnostics)��
6. ����(Container)�ࡢ������(Iterator)���ͺ��㷨(Algorithm)
7. ��ֵ(Numerics)��
8. ���ػ�(Locale)��

## 10.4 C++���Ե��쳣�������
�������ɷ�Ϊ3�ࣺ
* �﷨����
* �������(�߼�����)
* ����ʱ����

C++������Գ�������ʱ���������ר�ŵ��쳣������ƣ���try-catch����

C++��׼��Ϊ�쳣��������ṩ���ֲ�ͬ���ܵ��쳣��

�����쳣������ƣ���ͬʱ�漰�����������뱻������
* ���������������쳣�������쳣��Ӧ�����쳣�������ϼ��������������쳣
* ����ı��淽����ͨ���ض��ĺ�������ֵ(���������)����ʾ��ͬ���쳣���
* ��������ͨ����鱻�������ķ���ֵ��������ʱ�Ƿ�������쳣�������쳣��Ҳ��Ҫ����Ӧ���쳣����
* ����Ǻ����༶���ã�������������Ҫ������Ե��ϼ����������쳣

�����쳣��
1. void fun() throw(A,B,C); // ����fun����ֻ���׳�A��B��C��3�����͵��쳣
2. void fun() throw(); // ����fun�����׳��κ����͵��쳣
3. void fun(); // ����fun���ܻ��׳��κ����͵��쳣

C++��׼���е��쳣��exception
```cpp
class exception
{
private: char *msg ; // �����쳣��Ϣ�����ݳ�Ա
public:
    exception(); // ���캯��
    exception( const char * );
    exception( const exception & );
    exception & operator=(const exception & ); // ���ظ�ֵ�����
    virtual ~exception(); // ��������
    virtual const char *what(); // ������Ա�������쳣��Ϣ
} ;
```
������ʹ�ñ�׼�쳣��exception��
```cpp
#include <iostream>
#include <exception>
using namespace std;
int Div( int n ) // ��100 �� n
{
    if ( n <= 0 ) // ����쳣�����n<=0���������쳣���
    {
    exception err( ����������ʱ����Ϊ�������� ); // ����exception��Ķ���err
    throw ( err ); // �׳��쳣����err��Ȼ���˳���ǰ������ִ��
    }
    // ���û���쳣����ִ�����µ�������������
    return ( 100 / n ) ;
}
int main( )
{
    int N; // �������N������������������
    cin >> N;
    try
    {
        int result = Div( N ); // ���ú���Div���г�������
        cout << "100��" << N << "=" << result << endl; // ��ʾ100 �� N�Ľ��
    }
    catch ( exception &e ) // ��׽exception����쳣�������������ò���e�������쳣����
    {
        cout << e.what( ) << endl; // ���û���ʾ����׽���쳣����e����ϸ��Ϣ
    }
    return 0;
}
```

## 10.5 ���ݼ��ϼ��䴦���㷨
* ���ݼ���
    * ������(Data Item)�������������ݼ��͵���С��λ�� ��Ԫ��
    * ����Ԫ��(Data Element)������Ԫ�����ɶ���������ڹ�����ϵ������������ɡ� ��
    * ���ݼ���(Data Set)�����ݼ����ɶ����������Ԫ������ɡ� ��

������sort

```cpp
template <typename RandomAccessIterator>
void sort(RandomAccessIterator first,RandomAccessIterator last);

template <typename RandomAccessIterator>
void sort(RandomAccessIterator first,RandomAccessIterator last,Compare comp);
```

�б���list

�б���list��һ�������࣬���Դ洢һά�����������С��б��е�����Ԫ�ض�����ͬһ���������͡���������vector��ȣ��б�list���������ص㣺
* �б���ڲ��洢�ṹ���������������ڲ��洢�ṹ�����顣
* �б���ÿ��Ԫ�ص��ڴ�ռ��Ƕ�������ģ��������������洢�ġ�
* �б��ʺ��ڴ洢��Ƶ�����ɾ�������ݼ��ϣ��������ʺ��ڴ洢Ԫ��������Թ̶������ݼ��ϣ����������ʺ�Ƶ�������ɾ��Ԫ�ء�
* �б�ĵ�����������˫����������������ĵ�����������������ʵ���������ʹ���±����Ԫ�أ���
* �б���list��һ����ģ�壬��ʹ�ø���ģ�嶨�����ͬ�������͵��б����

```cpp
#include <iostream>
#include <list>
#include <algorithm>
using namespace std;
int main()
{
    list <int> il; // ����1��int���б�il
    // ���4���б�Ԫ�أ���ֵ����Ϊ��3, 7, 9, 5
    il.push_back( 3 ); il.push_back( 7 ); il.push_back( 9 ); il.push_back( 5 );
    il.sort( ); // ���б�il���������б���list�Դ���������Աsort
    // ��ʾ�����Ľ��
    list <int> :: iterator lit; // ����1���б��������������lit������˫���������
    for ( lit = il.begin( ); lit != il.end( ); lit++ ) // ͨ������������lit�����б�
    cout << *lit << ", "; // ��ʾ�б�����
    cout << endl; // �б���������ʾ�����3, 5, 7, 9,
    return 0;
}
```

������set

������set��һ�������࣬���Դ洢һά�����������С�������set���������ص㣺

* �����е�����Ԫ�ض�����ͬһ���������͡�
* �򼯺��в����Ԫ�����ǻᱻ��ĳ�ּ�ֵ�Զ�����
* ��ͨ���ȽϺ�����ָ�������ֵ��
* ������ÿ��Ԫ�صļ�ֵ����Ψһ�ģ�������ͬ����ֵ�ظ���Ԫ�ػᱻ�Զ�������
* ���ϵĵ�����������˫���������
* ������set��һ����ģ�壬��ʹ�ø���ģ�嶨�����ͬ�������͵ļ��϶���
* ʹ�ü��������������Ӧ��������ͷ�ļ�\<set\>

```cpp
#include <iostream>
#include <set>
#include <algorithm>
using namespace std;
int main()
{
    set <int> is; // ����1��int�ͼ���is
    // ����4������Ԫ�أ���ֵ����Ϊ��3, 7, 9, 5
    is.insert( 3 ); is.insert( 7 ); is.insert( 9 ); is.insert( 5 );
    is.insert( 3 ); // �ظ�Ԫ�أ��ظ��ļ���Ԫ�ؽ��Զ�������
    // ��ʾ�����е�Ԫ��
    set <int> :: iterator sit; // ����1�������������������sit������˫���������
    for ( sit = is.begin( ); sit != is.end( ); sit++ ) // ͨ������������sit��������
    cout << *sit << ", "; // ��ʾ��������
    cout << endl; // ���ϻ��Զ�������ʾ�����3, 5, 7, 9,
    return 0;
}
```

ӳ����map

ӳ����map��һ���ʺϴ洢����������-ֵ���������ݵ������ࡣӳ����map���������ص㣺

* ����-ֵ���������ݰ����������ݣ�һ����Ϊ��������һ����Ϊ��ֵ�������磺������, 92����������, 86��������������һ�֡�����-���������͵ļ�ֵ�ԣ����������ǡ������������ǡ�ֵ��
* ��ӳ���в����Ԫ�����Ǳ����������Զ������������Ա��ڽ��Ŀ��ٲ���
* ӳ����ÿ��Ԫ�صġ���������Ψһ�ģ�������ͬ�����롰�����ظ���Ԫ��ʱ����Ԫ�ؽ�������Ԫ��
* ӳ��ĵ�����������˫�������
* ӳ����map��һ����ģ�壬��ʹ�ø���ģ�嶨�����ͬ�������͵�ӳ�����
* ʹ��ӳ�������������Ӧ��������ͷ�ļ�\<map\>

```cpp
#include <iostream>
#include <map>
#include <string>
using namespace std;
int main()
{
    map <string, int> sim; // ����1��string-int��ӳ��sim
    // ����3��ӳ��Ԫ�أ���ֵ����Ϊ������-92, ����-86, ����-95
    sim["����"] = 92; sim["����"] = 86; sim["����"] = 95;
    sim["����"] = 100; // �ظ�Ԫ�أ��������ظ���ӳ��Ԫ�ؽ��Զ�����֮ǰ����Ԫ��
    map <string, int> :: iterator mit; // ����1��ӳ���������������mit������˫���������
    for (mit = sim.begin( ); mit != sim.end( ); mit++) // ͨ������������mit����ӳ��
    cout << mit->first << ", " << mit->second << endl; // ��ʾ����first����ֵ��second��
    return 0;
}
```