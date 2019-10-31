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