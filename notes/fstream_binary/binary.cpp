#include <iostream>
#include <iomanip>
#include <fstream>

int main(int argc, char* argv[]) {
	const char* name[] = { "手电筒","电池" };
	double price[] = { 75.825,4.1 };
	int n;
	std::cout << "商品名称 单价\n" << std::setiosflags(std::ios::left);
	for (n = 0; n < 2; n++) {
		std::cout << std::setw(8) << name[n]; std::cout << " ";
		std::cout << std::setw(6) << price[n]; std::cout << std::endl;
	}

	std::ofstream fout;
	fout.open("price.dat", std::ios::binary);//以二进制模式打开文件"price.dat" 如果不存在则自动创建
	char str[7];
	for (n = 0; n < 2; n++) {
		strcpy_s(str, name[n]);
		fout.write(str, sizeof(str));//输出商品名称
		fout.write((char*)& price[n], sizeof(double));
	}
	fout.close();//关闭锁打开的文件"price.dat"
	return 0;
}