#include <fstream>
#include <iostream>
#include <iomanip>

int main(int argc, char* argv[]) {
	const char* name[] = { "shoudiantong","dianchi" };
	double price[] = { 75.825,4.1 };
	int n;
	//使用显示器对象cout将数据输出到显示器
	std::cout << "商 品 名 称    单 价\n" << std::setiosflags(std::ios::left);
	for (n = 0; n < 2; n++) {
		std::cout << std::setw(13) << name[n]; std::cout << "  ";
		std::cout << std::setw(10) << price[n]; std::cout << std::endl;
	}
	//使用文件输出流类ofstream的文件对象fout将数据输出到文本文件"price.txt"
	std::ofstream fout;
	fout.open("price.txt");//打开文件"price.txt"，如文件不存在则创建新文件
	fout << "商 品 名 称    单 价\n" << std::setiosflags(std::ios::left);//标题行
	for (n = 0; n < 2; n++) {
		fout << std::setw(13) << name[n]; fout << "  ";
		fout << std::setw(6) << price[n]; fout << std::endl;
	}//实测txt编辑器下无法对齐，vs里浏览对齐
	fout.close();
	return 0;
}