#include <fstream>
#include <iostream>

int main(int argc, char* argv[]) {
	char name[20];
	double price;
	
	std::ifstream fin;
	fin.open("price.txt");//Ĭ��ios::truncģʽ�����ļ������������
	fin.getline(name, 19);
	std::cout << name << std::endl;
	for (int n = 0; n < 2; n++) {
		fin >> name >> price;
		std::cout << name << "," << price << std::endl;
	}
	fin.close();
	return 0;
}