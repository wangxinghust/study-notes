#include <iostream>
#include <fstream>

int main(int argc, char* argv[]) {
	char name[20];
	double price;
	std::ifstream fin;
	fin.open("price.dat", std::ios::binary);//�Զ�����ģʽ���ļ�"price.dat"
	for (int n = 0; n < 2; n++) {
		fin.read(name, 7);//������Ʒ����
		fin.read((char*)& price, 8);//���뵥��
		std::cout << name << "," << price << std::endl;
	}
	fin.close();
	return 0;
}