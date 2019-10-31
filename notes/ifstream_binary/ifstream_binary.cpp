#include <iostream>
#include <fstream>

int main(int argc, char* argv[]) {
	char name[20];
	double price;
	std::ifstream fin;
	fin.open("price.dat", std::ios::binary);//以二进制模式打开文件"price.dat"
	for (int n = 0; n < 2; n++) {
		fin.read(name, 7);//输入商品名称
		fin.read((char*)& price, 8);//输入单价
		std::cout << name << "," << price << std::endl;
	}
	fin.close();
	return 0;
}