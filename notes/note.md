# 学习笔记
## 文件I/O
istream& **seekg**(long bytes, ios::seek_dir origin);//移动读文件指针  
long tellg();//返回当前读文件指针的位置

ostream& **seekp**(long bytes, ios::seek_dir origin);//移动写文件指针  
long tellp();//返回当前写文件指针的位置

>文件指针 p.cpp

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
	fin.seekg(-15, ios::end);//从文件尾向前（即往回）移动1行（1行有15个字节）
	fin.read(name, 7);
	fin.read((char*)& price, 8);//重读最后一行数据
	cout << name << "," << price << endl;
	fin.close();
	return 0;
}
```
***
## string类及字符串I/O
字符串I/O

* 可以把**string类对象**当做**数据源**，将其中的字符串输入给其它变量，这时string类对象就是一个输入数据流
* 做输出数据流
* 在字符串对象和其他变量之间进行数据的输入/输出 类似cin的数据缓冲区

C++流类库通过字符串输入/输出流类提供了字符串I/O的功能  
字符串输入/输出流类共有3个：
1. 字符串输入流类 istringstream
2. 字符串输出流类 ostringstream
3. 字符串输入/输出流类 stringstream
4. #include \<sstream>

## 基于Unicode编码的流类库
基于Unicode编码的流类库以wios为基类
* 标准I/O。包括通用输入流类wistream、通用输出流类wostream、通用输入/输出流类wiostream
* 文件I/O。包括文件输入流类wifstream、文件输出流类wofstream、文件输入/输出流类wfstream
* 字符串I/O。包括字符串输入流类wistringstream、字符串输出流类wostringstream、字符串输入/输出流类wstringstream

预定义的宽字符流对象
```cpp
namespace std{
	wistream wcin;
	wostream wcout;
}
```

## 小结
* cin、cout指令实际上分别是通用输入输出流类的对象
* 大部分程序都需要使用文件来保存数据

## 第10章 C++标准库
C++标准库
* 基于结构化程序设计方法所提供的的系统函数
* 基于面向对象程序设计方法所提供的系统类库

模板技术：
* 函数模板
* 类模板

### 10.1 函数模板
```
template <类型参数列表>
函数类型 函数名(形式参数列表){
    函数体
}
```

举例：
```cpp
#include <iostream>
using namespace std;

template <typename T> // 定义函数模板
T max(T x, T y) {// 使用类型参数T来指定函数的类型、形参x和y的类型
	return x > y ? x : y;
}

int main(int argc, char* argv[]) {
	cout << max(5, 10) << endl;
	cout << max(5.2, 10.2) << endl;
}
```

* 函数模板的编译原理  
函数模板是具有类型参数的函数。类型参数是表示数据类型的参数，可指代任意一种实际数据类型。编译器在编译到函数模板调用语句时，根据位置对应关系从实参数据类型推导出类型参数所指代的数据类型，然后按照函数模板自动生成一个该类型的函数定义代码。
不同类型实参的函数模板调用语句将生成不同类型的重载函数。
* 函数模板将根据数据类型参数化，调用时呈现出参数多态性
* 使用函数模板可以减少程序员的编码工作量，但所编译出的可执行代码不会减少，执行效率也不变。

### 10.2 类模板
```
template <类型参数列表>
class 类名 // 类生命部分
{
    类成员生命
}
// 类实现部分：所有类外定义的函数成员，必须按如下的语法形式将他们定义成函数模板
template <类型参数列表>
函数类型 类名<类型参数名列表> :: 函数名(形式参数列表)
{ 函数体 }
```
举例：

使用类模板定义对象时需要明确给出类型参数所指代的实际数据类型。
```cpp
#include <iostream>
using namespace std;
 template <typename T> // 类模板A
 class A { // 类声明部分
 private:
	 T a1;
	 int a2;
 public:
	 A(T p1, int p2) { // 构造函数
		 a1 = p1;
		 a2 = p2;
	 }
	 T Sum() { // 求数据成员的和
		 return (T)(a1 + a2);
	 }
	 void Show() { // 显示数据成员
		 cout << a1 << "," << a2 << endl;
	 }
 };
 // 无类实现部分

 template <typename T> //类模板B
 class B { // 类声明部分
 private:
	 T a1;
	 int a2;
 public:
	 B(T p1, int p2); // 构造函数
	 T Sum(); // 求数据成员的和
	 void Show(); // 显示数据成员
 };
 // 类实现部分: 需按函数模板的语法形式定义
 template <typename T>
 B<T>::B(T p1, int p2) { // 构造函数
	 a1 = p1;
	 a2 = p2;
 }
 template <typename T>
 T B<T>::Sum() { // 求数据成员的和
	 return (T)(a1 + a2);
 }
 template <typename T>
 void B<T>::Show() { // 显示数据成员
	 cout << a1 << "," << a2 << endl;
 }


 int main(int argc, char* argv[]) {
	 // 用类模板A定义对象，并访问某成员
	 A<double> o1(10.5, 6); // double型对象o1
	 o1.Show(); // 显示： 10.5,6
	 cout << o1.Sum() << endl; // 显示:16.5

	 A<int> o2(10, 6); // int型对象o2
	 o2.Show(); //显示：10,6
	 cout << o2.Sum() << endl; // 显示：16

	 printf("\n");

	 // 用类模板B定义对象，并访问某成员
	 B<double> o3(10.5, 6);
	 o3.Show();
	 cout << o3.Sum() << endl;
	 B<int> o4(10, 6);
	 o4.Show();
	 cout << o4.Sum() << endl;
	 return 0;
 }
```
类模板的编译原理：
* 编译时将类模板中类型参数绑定到某个具体数据类型的过程，
称为类模板的实例化。实例化所生成的类称为类模板的实例类。
实例类是一个普通的类，可以用来定义对象。
* 类模板是具有类型参数的类。类型参数是表示数据类型的参数，
可指代任意一种实际数据类型。编译器在编译到使用类模板定义
对象语句时，将首先按照所给定的实际数据类型对类模板进行实例化，
生成一个实例类。最终，编译器是使用实例类来定义所需要的对象。

使用typedef类型显示地实例化类模板
```cpp
int main(int argc, char* argv[]){
    typedef A<double> DoubleA; // 实例化类模板A，生成实例类DoubleA
    DoubleA o1(10.5,6); // 定义类DoubleA的对象o1
    o1.Show(); // 显示：10.5,6
    cout<<o1.Sum()<<endl; // 显示：16.5
    
    typedef A<int> IntA;
    IntA o2(10,6);
    o2.Show();
    cout<<o2.Sum()<<endl;
    return 0;
}
```

## 10.3 C++标准库
C++标准库也被称为标准模板库(Standard Template Library,STL)

10大类功能
1. 语言支持(Language Support)类
2. 通用工具(General Utilities)类
3. 输入/输出(Input/Output)类
4. 字符串(string)类
5. 诊断(Diagnostics)类
6. 容器(Container)类、迭代器(Iterator)类型和算法(Algorithm)
7. 数值(Numerics)类
8. 本地化(Locale)类

## 10.4 C++语言的异常处理机制
程序错误可分为3类：
* 语法错误
* 语义错误(逻辑错误)
* 运行时错误

C++语言针对程序运行时错误设计了专门的异常处理机制，即try-catch机制

C++标准库为异常处理机制提供多种不同功能的异常类

运用异常处理机制，将同时涉及到主调函数与被调函数
* 被调函数负责发现异常。发现异常后应处理异常，并向上级主调函数报告异常
* 常规的报告方法是通过特定的函数返回值(即错误代码)来表示不同的异常情况
* 主调函数通过检查被调函数的返回值来检查调用时是否出现了异常，发现异常后也需要做相应的异常处理
* 如果是函数多级调用，主调函数还需要逐级向各自的上级函数报告异常

声明异常：
1. void fun() throw(A,B,C); // 函数fun能且只能抛出A、B或C共3种类型的异常
2. void fun() throw(); // 函数fun不会抛出任何类型的异常
3. void fun(); // 函数fun可能会抛出任何类型的异常

C++标准库中的异常类exception
```cpp
class exception
{
private: char *msg ; // 保存异常信息的数据成员
public:
    exception(); // 构造函数
    exception( const char * );
    exception( const exception & );
    exception & operator=(const exception & ); // 重载赋值运算符
    virtual ~exception(); // 析构函数
    virtual const char *what(); // 函数成员：返回异常信息
} ;
```
举例，使用标准异常类exception：
```cpp
#include <iostream>
#include <exception>
using namespace std;
int Div( int n ) // 求100 ÷ n
{
    if ( n <= 0 ) // 检查异常：如果n<=0，则属于异常情况
    {
    exception err( “输入人数时必须为正整数” ); // 定义exception类的对象err
    throw ( err ); // 抛出异常对象err，然后退出当前函数的执行
    }
    // 如果没有异常，则执行如下的正常处理流程
    return ( 100 / n ) ;
}
int main( )
{
    int N; // 定义变量N，保存键盘输入的人数
    cin >> N;
    try
    {
        int result = Div( N ); // 调用函数Div进行除法运算
        cout << "100÷" << N << "=" << result << endl; // 显示100 ÷ N的结果
    }
    catch ( exception &e ) // 捕捉exception类的异常，并定义其引用参数e来接收异常对象
    {
        cout << e.what( ) << endl; // 向用户显示所捕捉到异常对象e的详细信息
    }
    return 0;
}
```

## 10.5 数据集合及其处理算法
* 数据集合
    * 数据项(Data Item)。数据项是数据集和的最小单位。 单元格
    * 数据元素(Data Element)。数据元素是由多个具有内在关联关系的数据项所组成。 行
    * 数据集合(Data Set)。数据集合由多个并列数据元素所组成。 表

排序函数sort

```cpp
template <typename RandomAccessIterator>
void sort(RandomAccessIterator first,RandomAccessIterator last);

template <typename RandomAccessIterator>
void sort(RandomAccessIterator first,RandomAccessIterator last,Compare comp);
```

列表类list

列表类list是一种容器类，可以存储一维有序数据序列。列表中的所有元素都属于同一个数据类型。与向量类vector相比，列表list具有如下特点：
* 列表的内部存储结构是链表，而向量的内部存储结构是数组。
* 列表中每个元素的内存空间是独立分配的，而向量是连续存储的。
* 列表适合于存储需频繁添加删除的数据集合，而向量适合于存储元素总数相对固定的数据集合，即向量不适合频繁地添加删除元素。
* 列表的迭代器类型是双向迭代器，而向量的迭代器类型是随机访问迭代器（可使用下标访问元素）。
* 列表类list是一个类模板，可使用该类模板定义出不同数据类型的列表对象

```cpp
#include <iostream>
#include <list>
#include <algorithm>
using namespace std;
int main()
{
    list <int> il; // 定义1个int型列表il
    // 添加4个列表元素，数值依次为：3, 7, 9, 5
    il.push_back( 3 ); il.push_back( 7 ); il.push_back( 9 ); il.push_back( 5 );
    il.sort( ); // 对列表il进行排序。列表类list自带排序函数成员sort
    // 显示排序后的结果
    list <int> :: iterator lit; // 定义1个列表类的容器迭代器lit（属于双向迭代器）
    for ( lit = il.begin( ); lit != il.end( ); lit++ ) // 通过容器迭代器lit遍历列表
    cout << *lit << ", "; // 显示列表内容
    cout << endl; // 列表排序后的显示结果：3, 5, 7, 9,
    return 0;
}
```

集合类set

集合类set是一种容器类，可以存储一维无序数据序列。集合类set具有如下特点：

* 集合中的所有元素都属于同一个数据类型。
* 向集合中插入的元素总是会被按某种键值自动排序。
* 可通过比较函数来指定排序键值。
* 集合中每个元素的键值都是唯一的，不能相同。键值重复的元素会被自动丢弃。
* 集合的迭代器类型是双向迭代器。
* 集合类set是一个类模板，可使用该类模板定义出不同数据类型的集合对象。
* 使用集合类需包含其相应的类声明头文件\<set\>

```cpp
#include <iostream>
#include <set>
#include <algorithm>
using namespace std;
int main()
{
    set <int> is; // 定义1个int型集合is
    // 插入4个集合元素，数值依次为：3, 7, 9, 5
    is.insert( 3 ); is.insert( 7 ); is.insert( 9 ); is.insert( 5 );
    is.insert( 3 ); // 重复元素：重复的集合元素将自动被丢弃
    // 显示集合中的元素
    set <int> :: iterator sit; // 定义1个集合类的容器迭代器sit（属于双向迭代器）
    for ( sit = is.begin( ); sit != is.end( ); sit++ ) // 通过容器迭代器sit遍历集合
    cout << *sit << ", "; // 显示集合内容
    cout << endl; // 集合会自动排序，显示结果：3, 5, 7, 9,
    return 0;
}
```

映射类map

映射类map是一种适合存储被称作“键-值”类型数据的容器类。映射类map具有如下特点：

* “键-值”类型数据包括两个数据，一个称为“键”，一个称为“值”。例如：“张三, 92”，“李四, 86”，……，就是一种“姓名-分数”类型的键值对，其中姓名是“键”，分数是“值”
* 向映射中插入的元素总是被按“键”自动排序，这样可以便于今后的快速查找
* 映射中每个元素的“键”都是唯一的，不能相同。插入“键”重复的元素时，新元素将覆盖老元素
* 映射的迭代器类型是双向迭代器
* 映射类map是一个类模板，可使用该类模板定义出不同数据类型的映射对象
* 使用映射类需包含其相应的类声明头文件\<map\>

```cpp
#include <iostream>
#include <map>
#include <string>
using namespace std;
int main()
{
    map <string, int> sim; // 定义1个string-int型映射sim
    // 插入3个映射元素，数值依次为：张三-92, 李四-86, 王五-95
    sim["张三"] = 92; sim["李四"] = 86; sim["王五"] = 95;
    sim["张三"] = 100; // 重复元素：“键”重复的映射元素将自动覆盖之前的老元素
    map <string, int> :: iterator mit; // 定义1个映射类的容器迭代器mit（属于双向迭代器）
    for (mit = sim.begin( ); mit != sim.end( ); mit++) // 通过容器迭代器mit遍历映射
    cout << mit->first << ", " << mit->second << endl; // 显示键（first）和值（second）
    return 0;
}
```